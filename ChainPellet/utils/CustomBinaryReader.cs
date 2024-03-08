using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPellet.utils
{
    internal class CustomBinaryReader : BinaryReader
    {
        bool bigEndian;
        public CustomBinaryReader(System.IO.Stream stream, bool isBigEndian) : base(stream)
        {
            bigEndian = isBigEndian;
        }
        public override Int16 ReadInt16()
        {
            var data = base.ReadBytes(2);
            if (bigEndian) Array.Reverse(data);
            return BitConverter.ToInt16(data, 0);
        }
        public override UInt16 ReadUInt16()
        {
            var data = base.ReadBytes(2);
            if (bigEndian) Array.Reverse(data);
            return BitConverter.ToUInt16(data, 0);
        }
        public override UInt32 ReadUInt32()
        {
            var data = base.ReadBytes(4);
            if (bigEndian) Array.Reverse(data);
            return BitConverter.ToUInt32(data, 0);
        }
        public override Single ReadSingle()
        {
            var data = base.ReadBytes(4);
            if (bigEndian) Array.Reverse(data);
            return BitConverter.ToSingle(data, 0);
        }
    }
}
