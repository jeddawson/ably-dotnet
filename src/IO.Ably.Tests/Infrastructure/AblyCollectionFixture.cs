using System.Collections.Generic;
using System.Linq;
using IO.Ably.Transport;
using Xunit;

namespace IO.Ably.Tests
{
    public class AblyCollectionFixture : ICollectionFixture<AblySandboxFixture> { }

    [CollectionDefinition("AblyRest SandBox Collection")]
    public class SandboxRestFixture : AblyCollectionFixture
    {
    }

    [CollectionDefinition("SandBox Connection")]
    public class SandBoxConnectionFixture : AblyCollectionFixture
    {
    }

    [CollectionDefinition("Presence Sandbox")]
    public class SandBoxPresenceFixture : AblyCollectionFixture
    {
    }

    [CollectionDefinition("Channel SandBox")]
    public class SandBoxChannelFixture : AblyCollectionFixture
    {
    }



    public class Key
    {
        public string KeyName { get; set; }
        public string KeySecret { get; set; }
        public string KeyStr { get; set; }
        public string Capability { get; set; }
    }

    public class TestEnvironmentSettings
    {
        public string AppId { get; set; }
        public List<Key> Keys { get; set; }

        public const string PresenceChannelName = "persisted:presence_fixtures";

        public string FirstValidKey => Keys.FirstOrDefault()?.KeyStr;
        public string KeyWithChannelLimitations => Keys[2].KeyStr;

        public bool Tls { get; set; }
        public string Environment => "sandbox";
        public CipherParams CipherParams { get; set; }

        public TestEnvironmentSettings()
        {
            Keys = new List<Key>();
        }

        internal AblyHttpClient GetHttpClient()
        {
            var ablyHttpOptions = new AblyHttpOptions() { IsSecure = Tls};
            ablyHttpOptions.Host = CreateDefaultOptions().FullRestHost();
            return new AblyHttpClient(ablyHttpOptions);
        }

        public ClientOptions CreateDefaultOptions(string key = null)
        {
            return new ClientOptions() { Key = key ?? FirstValidKey, Tls = Tls, Environment = Environment };
        }
    }
}