﻿using TES3Lib.Structures.Base;
using Utility;

namespace TES3Lib.Subrecords.REFR
{
    public class FLTV : Subrecord
    {
        public int LockLevel { get; set; }

        public FLTV(byte[] rawData) : base(rawData)
        {
            var reader = new ByteReader();
            LockLevel = reader.ReadBytes<int>(base.Data);
        }
    }
}
