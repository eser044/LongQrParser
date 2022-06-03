using System.Collections.Generic;

namespace LongQrCodeParser.SubTlv
{
    public class KareKodKimlikBilgileriSablonu51 : Tlv, ITlvCollectionData
    {
        public List<Tlv> Tlvs { get; set; }

        public Tlv SurumNumarasi00 => Tlvs[0];
        public Tlv KarekodUreticiKodu02 => Tlvs[2];
        public Tlv KarekodReferansNumarasi03 => Tlvs[3];
        public Tlv TerminalTipi04 => Tlvs[4];
        public Tlv TerminalCihazSeriNumarasi05 => Tlvs[5];
        public Tlv OlusturulmaZamani06 => Tlvs[6];
        public Tlv SonGecerlilikZamani07 => Tlvs[7];

        public Tlv Field01 => Tlvs[1];


        public KareKodKimlikBilgileriSablonu51()
        {
            Tlvs = new List<Tlv>();
            for (int i = 0; i <= 7; i++)
            {
                Tlvs.Add(new Tlv());
            }
        }
    }
}