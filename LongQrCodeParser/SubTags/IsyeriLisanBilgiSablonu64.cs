using System.Collections.Generic;
using LongQrCodeParser.HasSubTags;

namespace LongQrCodeParser.SubTags
{
    public class IsyeriLisanBilgiSablonu64 : Tlv, ITlvCollectionData
    {
        public List<Tlv> Tlvs { get; set; }

        public IsyeriLisanBilgiSablonu64()
        {
            Tlvs = new List<Tlv>();
            for (int i = 0; i <= 99; i++)
            {
                Tlvs.Add(new Tlv());
            }
        }
    }
}