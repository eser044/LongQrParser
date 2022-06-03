using LongQrCodeParser.SubTlv;
using System;
using System.Collections.Generic;

namespace LongQrCodeParser
{
    public class LongQrCodeDetail : ITlvCollectionData
    {
        public List<Tlv> Tlvs { get; set; }

        public Tlv KareKodBicimGostergesi00 => Tlvs[0];
        public Tlv KareKodTuru01 => Tlvs[1];
        public Tlv IsyeriHesapBilgileri02 => Tlvs[2];
        public Tlv IsyeriHesapBilgileri03 => Tlvs[3];
        public Tlv IsyeriHesapBilgileri04 => Tlvs[4];
        public Tlv IsyeriHesapBilgileri05 => Tlvs[5];
        public Tlv IsyeriHesapBilgileri06 => Tlvs[6];
        public Tlv IsyeriHesapBilgileri07 => Tlvs[7];
        public Tlv IsyeriHesapBilgileri08 => Tlvs[8];
        public Tlv IsyeriHesapBilgileri09 => Tlvs[9];
        public Tlv IsyeriHesapBilgileri10 => Tlvs[10];
        public Tlv IsyeriHesapBilgileri11 => Tlvs[11];
        public Tlv IsyeriHesapBilgileri12 => Tlvs[12];
        public Tlv IsyeriHesapBilgileri13 => Tlvs[13];
        public Tlv IsyeriHesapBilgileri14 => Tlvs[14];
        public Tlv IsyeriHesapBilgileri15 => Tlvs[15];
        public Tlv IsyeriHesapBilgileri16 => Tlvs[16];
        public Tlv IsyeriHesapBilgileri17 => Tlvs[17];
        public Tlv IsyeriHesapBilgileri18 => Tlvs[18];
        public Tlv IsyeriHesapBilgileri19 => Tlvs[19];
        public Tlv IsyeriHesapBilgileri20 => Tlvs[20];
        public Tlv IsyeriHesapBilgileri21 => Tlvs[21];
        public Tlv IsyeriHesapBilgileri22 => Tlvs[22];
        public Tlv IsyeriHesapBilgileri23 => Tlvs[23];
        public Tlv IsyeriHesapBilgileri24 => Tlvs[24];
        public Tlv IsyeriHesapBilgileri25 => Tlvs[25];
        public IsyeriHesapBilgileri26 IsyeriHesapBilgileri26 => Tlvs[26] as IsyeriHesapBilgileri26;
        public Tlv IsyeriHesapBilgileri27 => Tlvs[27];
        public Tlv IsyeriHesapBilgileri28 => Tlvs[28];
        public Tlv IsyeriHesapBilgileri29 => Tlvs[29];
        public IsyeriHesapBilgileri30 IsyeriHesapBilgileri30 => Tlvs[30] as IsyeriHesapBilgileri30;
        public Tlv IlgiliMesajReferansi31 => Tlvs[31];
        public Tlv IsyeriHesapBilgileri32 => Tlvs[32];
        public Tlv IsyeriHesapBilgileri33 => Tlvs[33];
        public Tlv IsyeriHesapBilgileri34 => Tlvs[34];
        public Tlv IsyeriHesapBilgileri35 => Tlvs[35];
        public Tlv IsyeriHesapBilgileri36 => Tlvs[36];
        public Tlv IsyeriHesapBilgileri37 => Tlvs[37];
        public Tlv IsyeriHesapBilgileri38 => Tlvs[38];
        public Tlv IsyeriHesapBilgileri39 => Tlvs[39];
        public Tlv IsyeriHesapBilgileri40 => Tlvs[40];
        public Tlv IsyeriHesapBilgileri41 => Tlvs[41];
        public Tlv IsyeriHesapBilgileri42 => Tlvs[42];
        public Tlv IsyeriHesapBilgileri43 => Tlvs[43];
        public Tlv IsyeriHesapBilgileri44 => Tlvs[44];
        public Tlv IsyeriHesapBilgileri45 => Tlvs[45];
        public Tlv IsyeriHesapBilgileri46 => Tlvs[46];
        public Tlv IsyeriSerbestSablonlari47 => Tlvs[47];
        public Tlv IsyeriSerbestSablonlari48 => Tlvs[48];
        public Tlv IsyeriKodu49 => Tlvs[49];
        public Tlv Konum50 => Tlvs[50];
        public KareKodKimlikBilgileriSablonu51 KodKimlikBilgileriSablonu51 => Tlvs[51] as KareKodKimlikBilgileriSablonu51;
        public Tlv IsYeriKategoriKodu52 => Tlvs[52];
        public Tlv ParaBirimi53 => Tlvs[53];
        public Tlv Tutar54 => Tlvs[54];
        public Tlv BahsisVeyaDigerTutarGostergesi55 => Tlvs[55];
        public Tlv BahsisVeyaDigerTutarDegeriSabit56 => Tlvs[56];
        public Tlv BahsisVeyaDigerTutarDegeriYuzde57 => Tlvs[57];
        public Tlv UlkeKodu58 => Tlvs[58];
        public Tlv IsyeriAdi59 => Tlvs[59];
        public Tlv IsyeriSehri60 => Tlvs[60];
        public Tlv PostaKodu61 => Tlvs[61];
        public EkVeriAlanlariSablonu62 EkVeriAlanlariSablonu62 => Tlvs[62] as EkVeriAlanlariSablonu62;
        public Tlv Crc63 => Tlvs[63];
        public IsyeriLisanBilgiSablonu64 IsyeriLisanBilgiSablonu64 => Tlvs[64] as IsyeriLisanBilgiSablonu64;
        public Tlv EvmCoAyrilmisAlan65 => Tlvs[65];
        public Tlv EvmCoAyrilmisAlan66 => Tlvs[66];
        public Tlv EvmCoAyrilmisAlan67 => Tlvs[67];
        public Tlv EvmCoAyrilmisAlan68 => Tlvs[68];
        public Tlv EvmCoAyrilmisAlan69 => Tlvs[69];
        public Tlv EvmCoAyrilmisAlan70 => Tlvs[70];
        public Tlv EvmCoAyrilmisAlan71 => Tlvs[71];
        public Tlv EvmCoAyrilmisAlan72 => Tlvs[72];
        public Tlv EvmCoAyrilmisAlan73 => Tlvs[73];
        public Tlv EvmCoAyrilmisAlan74 => Tlvs[74];
        public Tlv EvmCoAyrilmisAlan75 => Tlvs[75];
        public Tlv EvmCoAyrilmisAlan76 => Tlvs[76];
        public Tlv EvmCoAyrilmisAlan77 => Tlvs[77];
        public Tlv EvmCoAyrilmisAlan78 => Tlvs[78];
        public Tlv EvmCoAyrilmisAlan79 => Tlvs[79];
        public Tlv SerbestSablon80 => Tlvs[80];
        public Tlv SerbestSablon81 => Tlvs[81];
        public Tlv SerbestSablon82 => Tlvs[82];
        public Tlv SerbestSablon83 => Tlvs[83];
        public Tlv SerbestSablon84 => Tlvs[84];
        public Tlv SerbestSablon85 => Tlvs[85];
        public Tlv SerbestSablon86 => Tlvs[86];
        public Tlv SerbestSablon87 => Tlvs[87];
        public Tlv SerbestSablon88 => Tlvs[88];
        public Tlv SerbestSablon89 => Tlvs[89];
        public Tlv SerbestSablon90 => Tlvs[90];
        public Tlv SerbestSablon91 => Tlvs[91];
        public Tlv SerbestSablon92 => Tlvs[92];
        public Tlv SerbestSablon93 => Tlvs[93];
        public Tlv SerbestSablon94 => Tlvs[94];
        public Tlv SerbestSablon95 => Tlvs[95];
        public Tlv SerbestSablon96 => Tlvs[96];
        public Tlv SerbestSablon97 => Tlvs[97];
        public Tlv SerbestSablon98 => Tlvs[98];
        public Tlv SerbestSablon99 => Tlvs[99];

        public LongQrCodeDetail()
        {
            Tlvs = new List<Tlv>();
            for (int i = 0; i <= 99; i++)
            {
                if (i == 26) Tlvs.Add(new IsyeriHesapBilgileri26());
                else if (i == 30) Tlvs.Add(new IsyeriHesapBilgileri30());
                else if (i == 51) Tlvs.Add(new KareKodKimlikBilgileriSablonu51());
                else if (i == 62) Tlvs.Add(new EkVeriAlanlariSablonu62());
                else if (i == 64) Tlvs.Add(new IsyeriLisanBilgiSablonu64());
                else Tlvs.Add(new Tlv());
            }
        }

        // TODO #B burası kullanılacak
        private static Dictionary<int, Type> _mappings;

        static Dictionary<int, Type> GetTypeMappings()
        {
            if (_mappings == null)
            {
                var typeMappings = new Dictionary<int, Type>();

                for (int i = 0; i <= 99; i++)
                {
                    if (i == 26) typeMappings.Add(26, typeof(IsyeriHesapBilgileri26));
                    else if (i == 30) typeMappings.Add(30, typeof(IsyeriHesapBilgileri30));
                    else if (i == 51) typeMappings.Add(51, typeof(KareKodKimlikBilgileriSablonu51));
                    else if (i == 62) typeMappings.Add(62, typeof(EkVeriAlanlariSablonu62));
                    else if (i == 64) typeMappings.Add(64, typeof(IsyeriLisanBilgiSablonu64));
                    else typeMappings.Add(i, typeof(Tlv));
                }

                _mappings = typeMappings;
            }

            return _mappings;
        }
    }
}