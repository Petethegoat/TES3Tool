﻿using TES3Lib.Structures.Base;
using Utility;

namespace TES3Lib.Subrecords.NPC_
{
    public class DODT : Subrecord
    {
        public DODT(byte[] rawData) : base(rawData)
        {
            var reader = new ByteReader();
        }
    }
}