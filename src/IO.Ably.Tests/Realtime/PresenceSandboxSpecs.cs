﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using IO.Ably.Realtime;
using Xunit;
using Xunit.Abstractions;

namespace IO.Ably.Tests.Realtime
{
    [Collection("Presence Sandbox")]
    [Trait("requires", "sandbox")]
    public class PresenceSandboxSpecs : SandboxSpecs
    {
        [Theory]
        [ProtocolData]
        [Trait("spec", "RTP1")]
        public async Task WhenAttachingToAChannelWithNoMembers_PresenceShouldBeConsideredInSync(Protocol protocol)
        {
            var client = await GetRealtimeClient(protocol);
            var channel = client.Channels.Get(GetTestChannelName());

            await channel.AttachAsync();

            channel.Presence.SyncComplete.Should().BeTrue();
        }

        [Theory]
        [ProtocolData]
        [Trait("spec", "RTP1")]
        public async Task WhenAttachingToAChannelWithMembers_PresenceShouldBeInProgress(Protocol protocol)
        {
            Logger.LogLevel = LogLevel.Debug;
            var testChannel = GetTestChannelName();
            var client = await GetRealtimeClient(protocol);
            var client2 = await GetRealtimeClient(protocol);
            var channel = client.Channels.Get(testChannel);
            List<Task> tasks = new List<Task>();
            for (int count = 1; count < 10; count++)
            {
                tasks.Add(channel.Presence.EnterClientAsync($"client-{count}", null));
            }

            Task.WaitAll(tasks.ToArray());

            var channel2 = client2.Channels.Get(testChannel) as RealtimeChannel;

            bool inSync = channel2.Presence.Map.IsSyncInProgress;
            bool syncComplete = channel2.Presence.SyncComplete;

            channel2.InternalStateChanged += (_, args) =>
            {
                if (args.Current == ChannelState.Attached)
                {
                    inSync = channel2.Presence.Map.IsSyncInProgress;
                    syncComplete = channel2.Presence.SyncComplete;
                }
            };

            await channel2.AttachAsync();

            inSync.Should().BeTrue();
            syncComplete.Should().BeFalse();
        }


        [Theory]
        [ProtocolData]
        public async Task CanSend_EnterWithStringArray(Protocol protocol)
        {
            var client = await GetRealtimeClient(protocol, (opts, _) => opts.ClientId = "test");

            var channel = client.Channels.Get("test" + protocol);

            await channel.Presence.EnterAsync(new [] {"test", "best"});
            
            var presence = await channel.Presence.GetAsync();
            await Task.Delay(2000);
            presence.Should().HaveCount(1);
        }

        [Theory]
        [ProtocolData]
        public async Task Presence_HasCorrectTimeStamp(Protocol protocol)
        {
            var client = await GetRealtimeClient(protocol, (opts, _) => opts.ClientId = "presence-timestamp-test");

            var channel = client.Channels.Get("test".AddRandomSuffix());
            DateTimeOffset? time = null;
            channel.Presence.Subscribe(message =>
            {
                Output.WriteLine($"{message.ConnectionId}:{message.Timestamp}");
                time = message.Timestamp;
                _resetEvent.Set();
            });

            await channel.Presence.EnterAsync(new[] { "test", "best" });

            _resetEvent.WaitOne(2000);
            time.Should().HaveValue();
        }

        public PresenceSandboxSpecs(AblySandboxFixture fixture, ITestOutputHelper output) : base(fixture, output)
        {
            
        }

        private string GetTestChannelName()
        {
            return "presence-" + Guid.NewGuid().ToString().Split('-').First();
        }
    }
}