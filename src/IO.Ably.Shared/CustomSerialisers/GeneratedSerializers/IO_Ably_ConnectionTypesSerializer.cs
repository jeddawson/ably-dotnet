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

#if MSGPACK
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    public class IO_Ably_ConnectionTypesSerializer : MsgPack.Serialization.MessagePackSerializer<IO.Ably.ConnectionTypes> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<IO.Ably.ResourceCount> _serializer1;
        
        public IO_Ably_ConnectionTypesSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<string>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<IO.Ably.ResourceCount>(schema1);
        }
        
        protected override void PackToCore(MsgPack.Packer packer, IO.Ably.ConnectionTypes objectTree) {
            packer.PackMapHeader(3);
            this._serializer0.PackTo(packer, "all");
            this._serializer1.PackTo(packer, objectTree.All);
            this._serializer0.PackTo(packer, "plain");
            this._serializer1.PackTo(packer, objectTree.Plain);
            this._serializer0.PackTo(packer, "tls");
            this._serializer1.PackTo(packer, objectTree.Tls);
        }
        
        protected override IO.Ably.ConnectionTypes UnpackFromCore(MsgPack.Unpacker unpacker)
        {
            IO.Ably.ConnectionTypes result = default(IO.Ably.ConnectionTypes);
            result = new IO.Ably.ConnectionTypes();
            int itemsCount0 = default(int);
            itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            for (int i = 0; (i < itemsCount0); i = (i + 1))
            {
                string key = default(string);
                string nullable2 = default(string);
                nullable2 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker,
                    typeof(IO.Ably.ConnectionTypes), "MemberName");
                if (((nullable2 == null)
                     == false))
                {
                    key = nullable2;
                }
                else
                {
                    throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                }
                if ((key == "tls"))
                {
                    IO.Ably.ResourceCount nullable5 = default(IO.Ably.ResourceCount);
                    if ((unpacker.Read() == false))
                    {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                    }
                    if (((unpacker.IsArrayHeader == false)
                         && (unpacker.IsMapHeader == false)))
                    {
                        nullable5 = this._serializer1.UnpackFrom(unpacker);
                    }
                    else
                    {
                        MsgPack.Unpacker disposable4 = default(MsgPack.Unpacker);
                        disposable4 = unpacker.ReadSubtree();
                        try
                        {
                            nullable5 = this._serializer1.UnpackFrom(disposable4);
                        }
                        finally
                        {
                            if (((disposable4 == null)
                                 == false))
                            {
                                disposable4.Dispose();
                            }
                        }
                    }
                    if (((nullable5 == null)
                         == false))
                    {
                        result.Tls = nullable5;
                    }
                }
                else
                {
                    if ((key == "plain"))
                    {
                        IO.Ably.ResourceCount nullable4 = default(IO.Ably.ResourceCount);
                        if ((unpacker.Read() == false))
                        {
                            throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                        }
                        if (((unpacker.IsArrayHeader == false)
                             && (unpacker.IsMapHeader == false)))
                        {
                            nullable4 = this._serializer1.UnpackFrom(unpacker);
                        }
                        else
                        {
                            MsgPack.Unpacker disposable3 = default(MsgPack.Unpacker);
                            disposable3 = unpacker.ReadSubtree();
                            try
                            {
                                nullable4 = this._serializer1.UnpackFrom(disposable3);
                            }
                            finally
                            {
                                if (((disposable3 == null)
                                     == false))
                                {
                                    disposable3.Dispose();
                                }
                            }
                        }
                        if (((nullable4 == null)
                             == false))
                        {
                            result.Plain = nullable4;
                        }
                    }
                    else
                    {
                        if ((key == "all"))
                        {
                            IO.Ably.ResourceCount nullable3 = default(IO.Ably.ResourceCount);
                            if ((unpacker.Read() == false))
                            {
                                throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                            }
                            if (((unpacker.IsArrayHeader == false)
                                 && (unpacker.IsMapHeader == false)))
                            {
                                nullable3 = this._serializer1.UnpackFrom(unpacker);
                            }
                            else
                            {
                                MsgPack.Unpacker disposable2 = default(MsgPack.Unpacker);
                                disposable2 = unpacker.ReadSubtree();
                                try
                                {
                                    nullable3 = this._serializer1.UnpackFrom(disposable2);
                                }
                                finally
                                {
                                    if (((disposable2 == null)
                                         == false))
                                    {
                                        disposable2.Dispose();
                                    }
                                }
                            }
                            if (((nullable3 == null)
                                 == false))
                            {
                                result.All = nullable3;
                            }
                        }
                        else
                        {
                            unpacker.Skip();
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
#endif
}
