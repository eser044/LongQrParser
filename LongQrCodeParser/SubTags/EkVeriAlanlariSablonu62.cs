using System.Collections.Generic;
using LongQrCodeParser.HasSubTags;

namespace LongQrCodeParser.SubTags
{
    public class EkVeriAlanlariSablonu62 : Tlv, ITlvCollectionData
    {
        public List<Tlv> Tlvs { get; set; }


        public Tlv FaturaNumarasi01 => Tlvs[1];
        public Tlv MusterininTelefonNumarası02 => Tlvs[2];
        public Tlv MagazaEtiketi03 => Tlvs[3];
        public Tlv MusteriSadakatNumarasi04 => Tlvs[4];
        public Tlv MusteriNumarasi06 => Tlvs[6];
        public Tlv OdemeAmaci08 => Tlvs[8];
        public Tlv EkTuketiciVerileri09 => Tlvs[9];

        public Tlv Field00 => Tlvs[0];
        public Tlv Field05 => Tlvs[5];
        public Tlv Field07 => Tlvs[7];

        public EkVeriAlanlariSablonu62()
        {
            Tlvs = new List<Tlv>();
            for (int i = 0; i <= 9; i++)
            {
                Tlvs.Add(new Tlv());
            }
        }
    }
}