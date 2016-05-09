﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IO.Ably.CustomSerialisers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class IO_Ably_MessageTrafficSerializer : MsgPack.Serialization.MessagePackSerializer<IO.Ably.MessageTraffic> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<IO.Ably.MessageTypes> _serializer1;
        
        public IO_Ably_MessageTrafficSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<string>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<IO.Ably.MessageTypes>(schema1);
        }
        
        protected override void PackToCore(MsgPack.Packer packer, IO.Ably.MessageTraffic objectTree) {
            packer.PackMapHeader(5);
            this._serializer0.PackTo(packer, "All");
            this._serializer1.PackTo(packer, objectTree.All);
            this._serializer0.PackTo(packer, "HttpStream");
            this._serializer1.PackTo(packer, objectTree.HttpStream);
            this._serializer0.PackTo(packer, "Push");
            this._serializer1.PackTo(packer, objectTree.Push);
            this._serializer0.PackTo(packer, "Realtime");
            this._serializer1.PackTo(packer, objectTree.Realtime);
            this._serializer0.PackTo(packer, "Rest");
            this._serializer1.PackTo(packer, objectTree.Rest);
        }
        
        protected override IO.Ably.MessageTraffic UnpackFromCore(MsgPack.Unpacker unpacker) {
            IO.Ably.MessageTraffic result = default(IO.Ably.MessageTraffic);
            result = new IO.Ably.MessageTraffic();
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                IO.Ably.MessageTypes nullable = default(IO.Ably.MessageTypes);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(0);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable = this._serializer1.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                        disposable = unpacker.ReadSubtree();
                        try {
                            nullable = this._serializer1.UnpackFrom(disposable);
                        }
                        finally {
                            if (((disposable == null) 
                                        == false)) {
                                disposable.Dispose();
                            }
                        }
                    }
                }
                if (((nullable == null) 
                            == false)) {
                    result.All = nullable;
                }
                unpacked = (unpacked + 1);
                IO.Ably.MessageTypes nullable0 = default(IO.Ably.MessageTypes);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(1);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable0 = this._serializer1.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                        disposable0 = unpacker.ReadSubtree();
                        try {
                            nullable0 = this._serializer1.UnpackFrom(disposable0);
                        }
                        finally {
                            if (((disposable0 == null) 
                                        == false)) {
                                disposable0.Dispose();
                            }
                        }
                    }
                }
                if (((nullable0 == null) 
                            == false)) {
                    result.HttpStream = nullable0;
                }
                unpacked = (unpacked + 1);
                IO.Ably.MessageTypes nullable1 = default(IO.Ably.MessageTypes);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(2);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable1 = this._serializer1.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable1 = default(MsgPack.Unpacker);
                        disposable1 = unpacker.ReadSubtree();
                        try {
                            nullable1 = this._serializer1.UnpackFrom(disposable1);
                        }
                        finally {
                            if (((disposable1 == null) 
                                        == false)) {
                                disposable1.Dispose();
                            }
                        }
                    }
                }
                if (((nullable1 == null) 
                            == false)) {
                    result.Push = nullable1;
                }
                unpacked = (unpacked + 1);
                IO.Ably.MessageTypes nullable2 = default(IO.Ably.MessageTypes);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(3);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable2 = this._serializer1.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable2 = default(MsgPack.Unpacker);
                        disposable2 = unpacker.ReadSubtree();
                        try {
                            nullable2 = this._serializer1.UnpackFrom(disposable2);
                        }
                        finally {
                            if (((disposable2 == null) 
                                        == false)) {
                                disposable2.Dispose();
                            }
                        }
                    }
                }
                if (((nullable2 == null) 
                            == false)) {
                    result.Realtime = nullable2;
                }
                unpacked = (unpacked + 1);
                IO.Ably.MessageTypes nullable3 = default(IO.Ably.MessageTypes);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(4);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable3 = this._serializer1.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable3 = default(MsgPack.Unpacker);
                        disposable3 = unpacker.ReadSubtree();
                        try {
                            nullable3 = this._serializer1.UnpackFrom(disposable3);
                        }
                        finally {
                            if (((disposable3 == null) 
                                        == false)) {
                                disposable3.Dispose();
                            }
                        }
                    }
                }
                if (((nullable3 == null) 
                            == false)) {
                    result.Rest = nullable3;
                }
                unpacked = (unpacked + 1);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable4 = default(string);
                    nullable4 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(IO.Ably.MessageTraffic), "MemberName");
                    if (((nullable4 == null) 
                                == false)) {
                        key = nullable4;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "Rest")) {
                        IO.Ably.MessageTypes nullable9 = default(IO.Ably.MessageTypes);
                        if ((unpacker.Read() == false)) {
                            throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                        }
                        if (((unpacker.IsArrayHeader == false) 
                                    && (unpacker.IsMapHeader == false))) {
                            nullable9 = this._serializer1.UnpackFrom(unpacker);
                        }
                        else {
                            MsgPack.Unpacker disposable8 = default(MsgPack.Unpacker);
                            disposable8 = unpacker.ReadSubtree();
                            try {
                                nullable9 = this._serializer1.UnpackFrom(disposable8);
                            }
                            finally {
                                if (((disposable8 == null) 
                                            == false)) {
                                    disposable8.Dispose();
                                }
                            }
                        }
                        if (((nullable9 == null) 
                                    == false)) {
                            result.Rest = nullable9;
                        }
                    }
                    else {
                        if ((key == "Realtime")) {
                            IO.Ably.MessageTypes nullable8 = default(IO.Ably.MessageTypes);
                            if ((unpacker.Read() == false)) {
                                throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                            }
                            if (((unpacker.IsArrayHeader == false) 
                                        && (unpacker.IsMapHeader == false))) {
                                nullable8 = this._serializer1.UnpackFrom(unpacker);
                            }
                            else {
                                MsgPack.Unpacker disposable7 = default(MsgPack.Unpacker);
                                disposable7 = unpacker.ReadSubtree();
                                try {
                                    nullable8 = this._serializer1.UnpackFrom(disposable7);
                                }
                                finally {
                                    if (((disposable7 == null) 
                                                == false)) {
                                        disposable7.Dispose();
                                    }
                                }
                            }
                            if (((nullable8 == null) 
                                        == false)) {
                                result.Realtime = nullable8;
                            }
                        }
                        else {
                            if ((key == "Push")) {
                                IO.Ably.MessageTypes nullable7 = default(IO.Ably.MessageTypes);
                                if ((unpacker.Read() == false)) {
                                    throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                                }
                                if (((unpacker.IsArrayHeader == false) 
                                            && (unpacker.IsMapHeader == false))) {
                                    nullable7 = this._serializer1.UnpackFrom(unpacker);
                                }
                                else {
                                    MsgPack.Unpacker disposable6 = default(MsgPack.Unpacker);
                                    disposable6 = unpacker.ReadSubtree();
                                    try {
                                        nullable7 = this._serializer1.UnpackFrom(disposable6);
                                    }
                                    finally {
                                        if (((disposable6 == null) 
                                                    == false)) {
                                            disposable6.Dispose();
                                        }
                                    }
                                }
                                if (((nullable7 == null) 
                                            == false)) {
                                    result.Push = nullable7;
                                }
                            }
                            else {
                                if ((key == "HttpStream")) {
                                    IO.Ably.MessageTypes nullable6 = default(IO.Ably.MessageTypes);
                                    if ((unpacker.Read() == false)) {
                                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                                    }
                                    if (((unpacker.IsArrayHeader == false) 
                                                && (unpacker.IsMapHeader == false))) {
                                        nullable6 = this._serializer1.UnpackFrom(unpacker);
                                    }
                                    else {
                                        MsgPack.Unpacker disposable5 = default(MsgPack.Unpacker);
                                        disposable5 = unpacker.ReadSubtree();
                                        try {
                                            nullable6 = this._serializer1.UnpackFrom(disposable5);
                                        }
                                        finally {
                                            if (((disposable5 == null) 
                                                        == false)) {
                                                disposable5.Dispose();
                                            }
                                        }
                                    }
                                    if (((nullable6 == null) 
                                                == false)) {
                                        result.HttpStream = nullable6;
                                    }
                                }
                                else {
                                    if ((key == "All")) {
                                        IO.Ably.MessageTypes nullable5 = default(IO.Ably.MessageTypes);
                                        if ((unpacker.Read() == false)) {
                                            throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                                        }
                                        if (((unpacker.IsArrayHeader == false) 
                                                    && (unpacker.IsMapHeader == false))) {
                                            nullable5 = this._serializer1.UnpackFrom(unpacker);
                                        }
                                        else {
                                            MsgPack.Unpacker disposable4 = default(MsgPack.Unpacker);
                                            disposable4 = unpacker.ReadSubtree();
                                            try {
                                                nullable5 = this._serializer1.UnpackFrom(disposable4);
                                            }
                                            finally {
                                                if (((disposable4 == null) 
                                                            == false)) {
                                                    disposable4.Dispose();
                                                }
                                            }
                                        }
                                        if (((nullable5 == null) 
                                                    == false)) {
                                            result.All = nullable5;
                                        }
                                    }
                                    else {
                                        unpacker.Skip();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}
