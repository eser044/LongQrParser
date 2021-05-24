using System;
using System.Collections.Generic;
using LongQrCodeParser.HasSubTags;
using LongQrCodeParser.SubTags;

// ReSharper disable IdentifierTypo

namespace LongQrCodeParser
{
    public class LongQrCodeDetail : ITlvCollectionData
    {
        public List<Tlv> Tlvs { get; set; }
        public Tlv KareKodBicimGostergesi00 => Tlvs.Find(x => x.Tag.Equals("00"));
        public Tlv KareKodTuru01 => Tlvs.Find(x => x.Tag.Equals("01"));
        public Tlv IsyeriHesapBilgileri02 => Tlvs.Find(x => x.Tag.Equals("02"));
        public Tlv IsyeriHesapBilgileri03 => Tlvs.Find(x => x.Tag.Equals("03"));
        public Tlv IsyeriHesapBilgileri04 => Tlvs.Find(x => x.Tag.Equals("04"));
        public Tlv IsyeriHesapBilgileri05 => Tlvs.Find(x => x.Tag.Equals("05"));
        public Tlv IsyeriHesapBilgileri06 => Tlvs.Find(x => x.Tag.Equals("06"));
        public Tlv IsyeriHesapBilgileri07 => Tlvs.Find(x => x.Tag.Equals("07"));
        public Tlv IsyeriHesapBilgileri08 => Tlvs.Find(x => x.Tag.Equals("08"));
        public Tlv IsyeriHesapBilgileri09 => Tlvs.Find(x => x.Tag.Equals("09"));
        public Tlv IsyeriHesapBilgileri10 => Tlvs.Find(x => x.Tag.Equals("10"));
        public Tlv IsyeriHesapBilgileri11 => Tlvs.Find(x => x.Tag.Equals("11"));
        public Tlv IsyeriHesapBilgileri12 => Tlvs.Find(x => x.Tag.Equals("12"));
        public Tlv IsyeriHesapBilgileri13 => Tlvs.Find(x => x.Tag.Equals("13"));
        public Tlv IsyeriHesapBilgileri14 => Tlvs.Find(x => x.Tag.Equals("14"));
        public Tlv IsyeriHesapBilgileri15 => Tlvs.Find(x => x.Tag.Equals("15"));
        public Tlv IsyeriHesapBilgileri16 => Tlvs.Find(x => x.Tag.Equals("16"));
        public Tlv IsyeriHesapBilgileri17 => Tlvs.Find(x => x.Tag.Equals("17"));
        public Tlv IsyeriHesapBilgileri18 => Tlvs.Find(x => x.Tag.Equals("18"));
        public Tlv IsyeriHesapBilgileri19 => Tlvs.Find(x => x.Tag.Equals("19"));
        public Tlv IsyeriHesapBilgileri20 => Tlvs.Find(x => x.Tag.Equals("20"));
        public Tlv IsyeriHesapBilgileri21 => Tlvs.Find(x => x.Tag.Equals("21"));
        public Tlv IsyeriHesapBilgileri22 => Tlvs.Find(x => x.Tag.Equals("22"));
        public Tlv IsyeriHesapBilgileri23 => Tlvs.Find(x => x.Tag.Equals("23"));
        public Tlv IsyeriHesapBilgileri24 => Tlvs.Find(x => x.Tag.Equals("24"));
        public Tlv IsyeriHesapBilgileri25 => Tlvs.Find(x => x.Tag.Equals("25"));
        public IsyeriHesapBilgileri26 IsyeriHesapBilgileri26 => Tlvs.Find(x => x != null ? x.Tag.Equals("26") : false) as IsyeriHesapBilgileri26;
        public Tlv IsyeriHesapBilgileri27 => Tlvs.Find(x => x.Tag.Equals("27"));
        public Tlv IsyeriHesapBilgileri28 => Tlvs.Find(x => x.Tag.Equals("28"));
        public Tlv IsyeriHesapBilgileri29 => Tlvs.Find(x => x.Tag.Equals("29"));
        public IsyeriHesapBilgileri30 IsyeriHesapBilgileri30 => Tlvs.Find(x => x.Tag.Equals("30")) as IsyeriHesapBilgileri30;
        public Tlv IsyeriHesapBilgileri31 => Tlvs.Find(x => x.Tag.Equals("31"));
        public Tlv IsyeriHesapBilgileri32 => Tlvs.Find(x => x.Tag.Equals("32"));
        public Tlv IsyeriHesapBilgileri33 => Tlvs.Find(x => x.Tag.Equals("33"));
        public Tlv IsyeriHesapBilgileri34 => Tlvs.Find(x => x.Tag.Equals("34"));
        public Tlv IsyeriHesapBilgileri35 => Tlvs.Find(x => x.Tag.Equals("35"));
        public Tlv IsyeriHesapBilgileri36 => Tlvs.Find(x => x.Tag.Equals("36"));
        public Tlv IsyeriHesapBilgileri37 => Tlvs.Find(x => x.Tag.Equals("37"));
        public Tlv IsyeriHesapBilgileri38 => Tlvs.Find(x => x.Tag.Equals("38"));
        public Tlv IsyeriHesapBilgileri39 => Tlvs.Find(x => x.Tag.Equals("39"));
        public Tlv IsyeriHesapBilgileri40 => Tlvs.Find(x => x.Tag.Equals("40"));
        public Tlv IsyeriHesapBilgileri41 => Tlvs.Find(x => x.Tag.Equals("41"));
        public Tlv IsyeriHesapBilgileri42 => Tlvs.Find(x => x.Tag.Equals("42"));
        public Tlv IsyeriHesapBilgileri43 => Tlvs.Find(x => x.Tag.Equals("43"));
        public Tlv IsyeriHesapBilgileri44 => Tlvs.Find(x => x.Tag.Equals("44"));
        public Tlv IsyeriHesapBilgileri45 => Tlvs.Find(x => x.Tag.Equals("45"));
        public Tlv IsyeriHesapBilgileri46 => Tlvs.Find(x => x.Tag.Equals("46"));
        public Tlv IsyeriSerbestSablonlari47 => Tlvs.Find(x => x.Tag.Equals("47"));
        public Tlv IsyeriSerbestSablonlari48 => Tlvs.Find(x => x.Tag.Equals("48"));
        public Tlv IsyeriKodu49 => Tlvs.Find(x => x.Tag.Equals("49"));
        public Tlv Konum50 => Tlvs.Find(x => x.Tag.Equals("50"));
        public KareKodKimlikBilgileriSablonu51 KodKimlikBilgileriSablonu51 => Tlvs.Find(x => x.Tag.Equals("51")) as KareKodKimlikBilgileriSablonu51;
        public Tlv IsYeriKategoriKodu52 => Tlvs.Find(x => x.Tag.Equals("52"));
        public Tlv ParaBirimi53 => Tlvs.Find(x => x.Tag.Equals("53"));
        public Tlv Tutar54 => Tlvs.Find(x => x.Tag.Equals("54"));
        public Tlv BahsisVeyaDigerTutarGostergesi55 => Tlvs.Find(x => x.Tag.Equals("55"));
        public Tlv BahsisVeyaDigerTutarDegeriSabit56 => Tlvs.Find(x => x.Tag.Equals("56"));
        public Tlv BahsisVeyaDigerTutarDegeriYuzde57 => Tlvs.Find(x => x.Tag.Equals("57"));
        public Tlv UlkeKodu58 => Tlvs.Find(x => x.Tag.Equals("58"));
        public Tlv IsyeriAdi59 => Tlvs.Find(x => x.Tag.Equals("59"));
        public Tlv IsyeriSehri60 => Tlvs.Find(x => x.Tag.Equals("60"));
        public Tlv PostaKodu61 => Tlvs.Find(x => x.Tag.Equals("61"));
        public EkVeriAlanlariSablonu62 EkVeriAlanlariSablonu62 => Tlvs.Find(x => x.Tag.Equals("62")) as EkVeriAlanlariSablonu62;
        public Tlv Crc63 => Tlvs.Find(x => x.Tag.Equals("63"));
        public IsyeriLisanBilgiSablonu64 IsyeriLisanBilgiSablonu64 => Tlvs.Find(x => x.Tag.Equals("64")) as IsyeriLisanBilgiSablonu64;
        public Tlv EvmCoAyrilmisAlan65 => Tlvs.Find(x => x.Tag.Equals("65"));
        public Tlv EvmCoAyrilmisAlan66 => Tlvs.Find(x => x.Tag.Equals("66"));
        public Tlv EvmCoAyrilmisAlan67 => Tlvs.Find(x => x.Tag.Equals("67"));
        public Tlv EvmCoAyrilmisAlan68 => Tlvs.Find(x => x.Tag.Equals("68"));
        public Tlv EvmCoAyrilmisAlan69 => Tlvs.Find(x => x.Tag.Equals("69"));
        public Tlv EvmCoAyrilmisAlan70 => Tlvs.Find(x => x.Tag.Equals("70"));
        public Tlv EvmCoAyrilmisAlan71 => Tlvs.Find(x => x.Tag.Equals("71"));
        public Tlv EvmCoAyrilmisAlan72 => Tlvs.Find(x => x.Tag.Equals("72"));
        public Tlv EvmCoAyrilmisAlan73 => Tlvs.Find(x => x.Tag.Equals("73"));
        public Tlv EvmCoAyrilmisAlan74 => Tlvs.Find(x => x.Tag.Equals("74"));
        public Tlv EvmCoAyrilmisAlan75 => Tlvs.Find(x => x.Tag.Equals("75"));
        public Tlv EvmCoAyrilmisAlan76 => Tlvs.Find(x => x.Tag.Equals("76"));
        public Tlv EvmCoAyrilmisAlan77 => Tlvs.Find(x => x.Tag.Equals("77"));
        public Tlv EvmCoAyrilmisAlan78 => Tlvs.Find(x => x.Tag.Equals("78"));
        public Tlv EvmCoAyrilmisAlan79 => Tlvs.Find(x => x.Tag.Equals("79"));
        public Tlv SerbestSablon80 => Tlvs.Find(x => x.Tag.Equals("80"));
        public Tlv SerbestSablon81 => Tlvs.Find(x => x.Tag.Equals("81"));
        public Tlv SerbestSablon82 => Tlvs.Find(x => x.Tag.Equals("82"));
        public Tlv SerbestSablon83 => Tlvs.Find(x => x.Tag.Equals("83"));
        public Tlv SerbestSablon84 => Tlvs.Find(x => x.Tag.Equals("84"));
        public Tlv SerbestSablon85 => Tlvs.Find(x => x.Tag.Equals("85"));
        public Tlv SerbestSablon86 => Tlvs.Find(x => x.Tag.Equals("86"));
        public Tlv SerbestSablon87 => Tlvs.Find(x => x.Tag.Equals("87"));
        public Tlv SerbestSablon88 => Tlvs.Find(x => x.Tag.Equals("88"));
        public Tlv SerbestSablon89 => Tlvs.Find(x => x.Tag.Equals("89"));
        public Tlv SerbestSablon90 => Tlvs.Find(x => x.Tag.Equals("90"));
        public Tlv SerbestSablon91 => Tlvs.Find(x => x.Tag.Equals("91"));
        public Tlv SerbestSablon92 => Tlvs.Find(x => x.Tag.Equals("92"));
        public Tlv SerbestSablon93 => Tlvs.Find(x => x.Tag.Equals("93"));
        public Tlv SerbestSablon94 => Tlvs.Find(x => x.Tag.Equals("94"));
        public Tlv SerbestSablon95 => Tlvs.Find(x => x.Tag.Equals("95"));
        public Tlv SerbestSablon96 => Tlvs.Find(x => x.Tag.Equals("96"));
        public Tlv SerbestSablon97 => Tlvs.Find(x => x.Tag.Equals("97"));
        public Tlv SerbestSablon98 => Tlvs.Find(x => x.Tag.Equals("98"));
        public Tlv SerbestSablon99 => Tlvs.Find(x => x.Tag.Equals("99"));

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