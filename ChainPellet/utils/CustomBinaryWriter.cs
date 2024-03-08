using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ChainPellet.utils
{
    public class CustomBinaryWriter : BinaryWriter
    {
        bool bigEndian;
        public CustomBinaryWriter(System.IO.Stream stream, bool isBigEndian) : base(stream)
        {
            bigEndian = isBigEndian;
        }
        public override void Write(ushort value)
        {
            Span<byte> buffer = stackalloc byte[sizeof(ushort)];
            if (bigEndian) BinaryPrimitives.WriteUInt16BigEndian(buffer, value);
            else BinaryPrimitives.WriteUInt16LittleEndian(buffer, value);
            OutStream.Write(buffer);
        }
        public override void Write(int value)
        {
            Span<byte> buffer = stackalloc byte[sizeof(int)];
            if (bigEndian) BinaryPrimitives.WriteInt32BigEndian(buffer, value);
            else BinaryPrimitives.WriteInt32LittleEndian(buffer, value);
            OutStream.Write(buffer);
        }
        public override void Write(uint value)
        {
            Span<byte> buffer = stackalloc byte[sizeof(uint)];
            if (bigEndian) BinaryPrimitives.WriteUInt32BigEndian(buffer, value);
            else BinaryPrimitives.WriteUInt32LittleEndian(buffer, value);
            OutStream.Write(buffer);
        }
        public override void Write(float value)
        {
            Span<byte> buffer = stackalloc byte[sizeof(float)];
            if (bigEndian) BinaryPrimitives.WriteSingleBigEndian(buffer, value);
            else BinaryPrimitives.WriteSingleLittleEndian(buffer, value);
            OutStream.Write(buffer);
        }
        public void Write32String(string value)
        {
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < value.Length; i++)
            {
                base.Write(buffer[i]);
            }
            for (int i = 0; i < (32 - value.Length); i++)
            {
                base.Write((byte)0);
            }
        }
    }
}
