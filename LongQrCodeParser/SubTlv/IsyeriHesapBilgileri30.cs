using System.Collections.Generic;

namespace LongQrCodeParser.SubTlv
{
    public class IsyeriHesapBilgileri30 : Tlv, ITlvCollectionData
    {
        public List<Tlv> Tlvs { get; set; }

        public Tlv EvrenselKimlik00 => Tlvs[0];
        public Tlv IsyeriIban01 => Tlvs[1];
        public Tlv KareKodAkısTuru02 => Tlvs[2];
        public Tlv OzetGuvenlikHashDegeri20 => Tlvs[20];

        public Tlv Field03 => Tlvs[3];
        public Tlv Field04 => Tlvs[4];
        public Tlv Field05 => Tlvs[5];
        public Tlv Field06 => Tlvs[6];
        public Tlv Field07 => Tlvs[7];
        public Tlv Field08 => Tlvs[8];
        public Tlv Field09 => Tlvs[9];
        public Tlv Field10 => Tlvs[10];
        public Tlv Field11 => Tlvs[11];
        public Tlv Field12 => Tlvs[12];
        public Tlv Field13 => Tlvs[13];
        public Tlv Field14 => Tlvs[14];
        public Tlv Field15 => Tlvs[15];
        public Tlv Field16 => Tlvs[16];
        public Tlv Field17 => Tlvs[17];
        public Tlv Field18 => Tlvs[18];
        public Tlv Field19 => Tlvs[19];

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