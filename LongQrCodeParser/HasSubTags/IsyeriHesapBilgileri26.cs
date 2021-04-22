using System.Collections.Generic;

namespace LongQrCodeParser.HasSubTags
{
    public class IsyeriHesapBilgileri26 : Tlv, ITlvCollectionData
    {
        public List<Tlv> Tlvs { get; set; }

        public IsyeriHesapBilgileri26()
        {
            Tlvs = new List<Tlv>();
            for (int i = 0; i <= 13; i++)
            {
                Tlvs.Add(new Tlv());
            }
        }
    }
}