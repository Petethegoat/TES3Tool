﻿using TES3Lib.Structures.Base;
using Utility;

namespace TES3Lib.Subrecords.STAT
{
    public class MODL : Subrecord
    {
        public string ModelPath { get; set; }

        public MODL(byte[] rawData) : base(rawData)
        {
            var reader = new ByteReader();
            ModelPath = reader.ReadBytes<string>(base.Data, base.Size);
        }
    }
}
