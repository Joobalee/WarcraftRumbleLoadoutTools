using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarcraftRumbleLoadoutTools
{
    public class ProtobufTool
    {
        public static List<KeyValuePair<byte, byte>> ProcessProtobufMessage(byte[] protobufData, int depth = 0)
        {

            var message = new CodedInputStream(protobufData);

            var values = new List<KeyValuePair<byte, byte>>();
            while (!message.IsAtEnd)
            {
                var tag = message.ReadTag();
                var fieldNumber = WireFormat.GetTagFieldNumber(tag);
                var wireType = WireFormat.GetTagWireType(tag);

                switch (wireType)
                {
                    case WireFormat.WireType.LengthDelimited:
                        //Read message recursively
                        byte[] nestedMessageData = message.ReadBytes().ToByteArray();
                        values = values.Concat(ProcessProtobufMessage(nestedMessageData, depth + 1)).ToList();
                        break;

                    case WireFormat.WireType.Varint:

                        values.Add(new KeyValuePair<byte, byte>((byte)fieldNumber, (byte)message.ReadInt32()));
                        break;
                    default:
                        throw new NotSupportedException($"Unsupported wire type: {wireType}");
                }
            }
            return values;
        }
    }
}
