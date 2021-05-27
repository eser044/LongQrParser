using System.Collections.Generic;
using LongQrCodeParser.HasSubTags;

namespace LongQrCodeParser.SubTags
{
    public class IsyeriHesapBilgileri26 : Tlv, ITlvCollectionData
    {
        public List<Tlv> Tlvs { get; set; }

        public Tlv EvrenselKimlik00 => Tlvs[0];
        public Tlv IslemTipi06 => Tlvs[6];
        public Tlv OzetGuvenlikDegeri08 => Tlvs[8];
        public Tlv Semalar09 => Tlvs[9];
        public Tlv Marka10 => Tlvs[10];
        public Tlv TaksitSayisi11 => Tlvs[11];
        public Tlv Rrn13 => Tlvs[13];

        public Tlv Field01 => Tlvs[1];
        public Tlv Field02 => Tlvs[2];
        public Tlv Field03 => Tlvs[3];
        public Tlv Field04 => Tlvs[4];
        public Tlv Field05 => Tlvs[5];
        public Tlv Field07 => Tlvs[7];
        public Tlv Field12 => Tlvs[12];

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