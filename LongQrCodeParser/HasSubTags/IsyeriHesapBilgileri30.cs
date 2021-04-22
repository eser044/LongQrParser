using System;
using System.Collections.Generic;

namespace LongQrCodeParser.HasSubTags
{
    public class IsyeriHesapBilgileri30 : Tlv, ITlvCollectionData
    {
        public List<Tlv> Tlvs { get; set; }

        public IsyeriHesapBilgileri30()
        {
            Tlvs = new List<Tlv>();
            for (int i = 0; i <= 20; i++)
            {
                Tlvs.Add(new Tlv());
            }
        }
    }
}