﻿using TES3Lib.Structures.Base;
using Utility;

namespace TES3Lib.Subrecords.TES3
{
    internal class MAST : Subrecord
    {
        // variable size
        public string Filename { get; set; }

        public MAST(byte[] rawData) : base(rawData)
        {
            var reader = new ByteReader();
            Filename = reader.ReadBytes<string>(base.Data, base.Size);
        }
    }
}
