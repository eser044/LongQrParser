using LongQrCodeParser.HasSubTags;
using LongQrCodeParser.SubTags;
using NUnit.Framework;

namespace LongQrCodeParser.Test
{
    public class LongQrCodeDetailTests
    {
        [Test]
        public void BkmQRTest1()
        {
            //00 02 01 
            //01 02 11
            //26 68 0010TR.COM.BKM060110820012345678901234567890910TDVMAUJ0001001N110203
            //		00 10 TR.COM.BKM
            //		06 01 1
            //		08 20 01234567890123456789
            //		09 10 TDVMAUJ000
            //		10 01 N
            //		11 02 03		
            //49 10 0023415672
            //51 95 000210020400010312180904121314040202052312345678901234567890ABC06122005291401590712200529150159
            //      00 02 10
            //      02 04 0001
            //      03 12 180904121314
            //      04 02 02
            //      05 23 12345678901234567890ABC
            //      06 12 200529140159
            //      07 12 200529150159
            //52 04 1234
            //53 03 949
            //54 12 000000000123
            //58 02 TR
            //59 06 ABCDEF
            //60 08 ISTANBUL
            //63 04 C2B6

            string input = @"00020101021126680010TR.COM.BKM060110820012345678901234567890910TDVMAUJ0001001N110203491000234156725195000210020400010312180904121314040202052312345678901234567890ABC0612200529140159071220052915015952041234530394954120000000001235802TR5906ABCDEF6008ISTANBUL6304C2B6";

            var longQrCodeDetail = LongQrCodeDetailParser.Parse<LongQrCodeDetail>(input);

            Assert.That(longQrCodeDetail, Is.Not.Null);
            Assert.That(longQrCodeDetail.KareKodBicimGostergesi00, Is.Not.Null);
            Assert.That(longQrCodeDetail.KareKodBicimGostergesi00.Tag, Is.EqualTo("00"));
            Assert.That(longQrCodeDetail.KareKodBicimGostergesi00.LengthString, Is.EqualTo("02"));
            Assert.That(longQrCodeDetail.KareKodBicimGostergesi00.Value, Is.EqualTo("01"));

            Assert.That(longQrCodeDetail.KareKodTuru01, Is.Not.Null);
            Assert.That(longQrCodeDetail.KareKodTuru01.Tag, Is.EqualTo("01"));
            Assert.That(longQrCodeDetail.KareKodTuru01.LengthString, Is.EqualTo("02"));
            Assert.That(longQrCodeDetail.KareKodTuru01.Value, Is.EqualTo("11"));

            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.Tag, Is.EqualTo("26"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.LengthString, Is.EqualTo("68"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.Value, Is.EqualTo("0010TR.COM.BKM060110820012345678901234567890910TDVMAUJ0001001N110203"));

            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.EvrenselKimlik00, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.EvrenselKimlik00.Tag, Is.EqualTo("00"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.EvrenselKimlik00.LengthString, Is.EqualTo("10"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.EvrenselKimlik00.Value, Is.EqualTo("TR.COM.BKM"));

            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.IslemTipi06.Tag, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.IslemTipi06.Tag, Is.EqualTo("06"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.IslemTipi06.LengthString, Is.EqualTo("01"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.IslemTipi06.Value, Is.EqualTo("1"));

            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.OzetGuvenlikDegeri08.Tag, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.OzetGuvenlikDegeri08.Tag, Is.EqualTo("08"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.OzetGuvenlikDegeri08.LengthString, Is.EqualTo("20"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.OzetGuvenlikDegeri08.Value, Is.EqualTo("01234567890123456789"));

            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.Semalar09.Tag, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.Semalar09.Tag, Is.EqualTo("09"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.Semalar09.LengthString, Is.EqualTo("10"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.Semalar09.Value, Is.EqualTo("TDVMAUJ000"));

            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.Marka10.Tag, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.Marka10.Tag, Is.EqualTo("10"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.Marka10.LengthString, Is.EqualTo("01"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.Marka10.Value, Is.EqualTo("N"));

            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.TaksitSayisi11.Tag, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.TaksitSayisi11.Tag, Is.EqualTo("11"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.TaksitSayisi11.LengthString, Is.EqualTo("02"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri26.TaksitSayisi11.Value, Is.EqualTo("03"));

            Assert.That(longQrCodeDetail.IsyeriKodu49, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsyeriKodu49.Tag, Is.EqualTo("49"));
            Assert.That(longQrCodeDetail.IsyeriKodu49.LengthString, Is.EqualTo("10"));
            Assert.That(longQrCodeDetail.IsyeriKodu49.Value, Is.EqualTo("0023415672"));

            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51, Is.Not.Null);
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.Tag, Is.EqualTo("51"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.LengthString, Is.EqualTo("95"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.Value, Is.EqualTo("000210020400010312180904121314040202052312345678901234567890ABC06122005291401590712200529150159"));

            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.SurumNumarasi00, Is.Not.Null);
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.SurumNumarasi00.Tag, Is.EqualTo("00"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.SurumNumarasi00.LengthString, Is.EqualTo("02"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.SurumNumarasi00.Value, Is.EqualTo("10"));

            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.KarekodUreticiKodu02, Is.Not.Null);
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.KarekodUreticiKodu02.Tag, Is.EqualTo("02"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.KarekodUreticiKodu02.LengthString, Is.EqualTo("04"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.KarekodUreticiKodu02.Value, Is.EqualTo("0001"));

            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.KarekodReferansNumarasi03, Is.Not.Null);
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.KarekodReferansNumarasi03.Tag, Is.EqualTo("03"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.KarekodReferansNumarasi03.LengthString, Is.EqualTo("12"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.KarekodReferansNumarasi03.Value, Is.EqualTo("180904121314"));

            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.TerminalTipi04, Is.Not.Null);
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.TerminalTipi04.Tag, Is.EqualTo("04"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.TerminalTipi04.LengthString, Is.EqualTo("02"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.TerminalTipi04.Value, Is.EqualTo("02"));

            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.TerminalCihazSeriNumarasi05, Is.Not.Null);
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.TerminalCihazSeriNumarasi05.Tag, Is.EqualTo("05"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.TerminalCihazSeriNumarasi05.LengthString, Is.EqualTo("23"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.TerminalCihazSeriNumarasi05.Value, Is.EqualTo("12345678901234567890ABC"));

            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.OlusturulmaZamani06, Is.Not.Null);
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.OlusturulmaZamani06.Tag, Is.EqualTo("06"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.OlusturulmaZamani06.LengthString, Is.EqualTo("12"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.OlusturulmaZamani06.Value, Is.EqualTo("200529140159"));

            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.SonGecerlilikZamani07, Is.Not.Null);
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.SonGecerlilikZamani07.Tag, Is.EqualTo("07"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.SonGecerlilikZamani07.LengthString, Is.EqualTo("12"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.SonGecerlilikZamani07.Value, Is.EqualTo("200529150159"));


            Assert.That(longQrCodeDetail.IsYeriKategoriKodu52, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsYeriKategoriKodu52.Tag, Is.EqualTo("52"));
            Assert.That(longQrCodeDetail.IsYeriKategoriKodu52.LengthString, Is.EqualTo("04"));
            Assert.That(longQrCodeDetail.IsYeriKategoriKodu52.Value, Is.EqualTo("1234"));

            Assert.That(longQrCodeDetail.ParaBirimi53, Is.Not.Null);
            Assert.That(longQrCodeDetail.ParaBirimi53.Tag, Is.EqualTo("53"));
            Assert.That(longQrCodeDetail.ParaBirimi53.LengthString, Is.EqualTo("03"));
            Assert.That(longQrCodeDetail.ParaBirimi53.Value, Is.EqualTo("949"));

            Assert.That(longQrCodeDetail.Tutar54, Is.Not.Null);
            Assert.That(longQrCodeDetail.Tutar54.Tag, Is.EqualTo("54"));
            Assert.That(longQrCodeDetail.Tutar54.LengthString, Is.EqualTo("12"));
            Assert.That(longQrCodeDetail.Tutar54.Value, Is.EqualTo("000000000123"));

            Assert.That(longQrCodeDetail.UlkeKodu58, Is.Not.Null);
            Assert.That(longQrCodeDetail.UlkeKodu58.Tag, Is.EqualTo("58"));
            Assert.That(longQrCodeDetail.UlkeKodu58.LengthString, Is.EqualTo("02"));
            Assert.That(longQrCodeDetail.UlkeKodu58.Value, Is.EqualTo("TR"));

            Assert.That(longQrCodeDetail.IsyeriAdi59, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsyeriAdi59.Tag, Is.EqualTo("59"));
            Assert.That(longQrCodeDetail.IsyeriAdi59.LengthString, Is.EqualTo("06"));
            Assert.That(longQrCodeDetail.IsyeriAdi59.Value, Is.EqualTo("ABCDEF"));

            Assert.That(longQrCodeDetail.IsyeriSehri60, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsyeriSehri60.Tag, Is.EqualTo("60"));
            Assert.That(longQrCodeDetail.IsyeriSehri60.LengthString, Is.EqualTo("08"));
            Assert.That(longQrCodeDetail.IsyeriSehri60.Value, Is.EqualTo("ISTANBUL"));

            Assert.That(longQrCodeDetail.Crc63, Is.Not.Null);
            Assert.That(longQrCodeDetail.Crc63.Tag, Is.EqualTo("63"));
            Assert.That(longQrCodeDetail.Crc63.LengthString, Is.EqualTo("04"));
            Assert.That(longQrCodeDetail.Crc63.Value, Is.EqualTo("C2B6"));
        }

        [Test]
        public void FastQRTest1()
        {
            //00 02 01
            //01 02 12
            //30 92 0016TR.GOV.TCMB.FAST0126TR1234567890123456789012340202012032E200C014A30EFCDC7E9F379CE0766A68
            //      00 16 TR.GOV.TCMB.FAST
            //      01 26 TR123456789012345678901234
            //      02 02 01
            //      20 32 E200C014A30EFCDC7E9F379CE0766A68
            //49 10 0023415672
            //50 16 3993942332851791
            //51 91 00021002040010030823451017040202052312345678901234567890ABC06122007291530590712200729163059
            //      00 02 10
            //      02 04 0010
            //      03 08 23451017
            //      04 02 02
            //      05 23 12345678901234567890ABC
            //      06 12 200729153059
            //      07 12 200729163059
            //52 04 5499
            //53 03 949
            //54 12 000000015050
            //58 02 TR
            //59 08 ABC GIDA
            //60 08 ÝSTANBUL
            //61 05 34100
            //62 75 0111TLK0123040502129031250750000306AVMSTR0410231563412306100518894111080209
            //      01 11 TLK01230405
            //      02 12 903125075000
            //      03 06 AVMSTR
            //      04 10 2315634123
            //      06 10 0518894111
            //      08 02 09
            //63 04 513B

            string input = @"00020101021230920016TR.GOV.TCMB.FAST0126TR1234567890123456789012340202012032E200C014A30EFCDC7E9F379CE0766A684910002341567250163993942332851791519100021002040010030823451017040202052312345678901234567890ABC0612200729153059071220072916305952045499530394954120000000150505802TR5908ABC GIDA6008ÝSTANBUL61053410062750111TLK0123040502129031250750000306AVMSTR04102315634123061005188941110802096304513B";

            var longQrCodeDetail = LongQrCodeDetailParser.Parse<LongQrCodeDetail>(input);

            Assert.That(longQrCodeDetail, Is.Not.Null);
            Assert.That(longQrCodeDetail.KareKodBicimGostergesi00, Is.Not.Null);
            Assert.That(longQrCodeDetail.KareKodBicimGostergesi00.Tag, Is.EqualTo("00"));
            Assert.That(longQrCodeDetail.KareKodBicimGostergesi00.LengthString, Is.EqualTo("02"));
            Assert.That(longQrCodeDetail.KareKodBicimGostergesi00.Value, Is.EqualTo("01"));

            Assert.That(longQrCodeDetail.KareKodTuru01, Is.Not.Null);
            Assert.That(longQrCodeDetail.KareKodTuru01.Tag, Is.EqualTo("01"));
            Assert.That(longQrCodeDetail.KareKodTuru01.LengthString, Is.EqualTo("02"));
            Assert.That(longQrCodeDetail.KareKodTuru01.Value, Is.EqualTo("12"));

            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.Tag, Is.EqualTo("30"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.LengthString, Is.EqualTo("92"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.Value, Is.EqualTo("0016TR.GOV.TCMB.FAST0126TR1234567890123456789012340202012032E200C014A30EFCDC7E9F379CE0766A68"));

            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.EvrenselKimlik00, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.EvrenselKimlik00.Tag, Is.EqualTo("00"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.EvrenselKimlik00.LengthString, Is.EqualTo("16"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.EvrenselKimlik00.Value, Is.EqualTo("TR.GOV.TCMB.FAST"));

            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.IsyeriIban01.Tag, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.IsyeriIban01.Tag, Is.EqualTo("01"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.IsyeriIban01.LengthString, Is.EqualTo("26"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.IsyeriIban01.Value, Is.EqualTo("TR123456789012345678901234"));

            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.KareKodAkýsTuru02.Tag, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.KareKodAkýsTuru02.Tag, Is.EqualTo("02"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.KareKodAkýsTuru02.LengthString, Is.EqualTo("02"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.KareKodAkýsTuru02.Value, Is.EqualTo("01"));

            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.OzetGuvenlikHashDegeri20.Tag, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.OzetGuvenlikHashDegeri20.Tag, Is.EqualTo("20"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.OzetGuvenlikHashDegeri20.LengthString, Is.EqualTo("32"));
            Assert.That(longQrCodeDetail.IsyeriHesapBilgileri30.OzetGuvenlikHashDegeri20.Value, Is.EqualTo("E200C014A30EFCDC7E9F379CE0766A68"));

            Assert.That(longQrCodeDetail.IsyeriKodu49, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsyeriKodu49.Tag, Is.EqualTo("49"));
            Assert.That(longQrCodeDetail.IsyeriKodu49.LengthString, Is.EqualTo("10"));
            Assert.That(longQrCodeDetail.IsyeriKodu49.Value, Is.EqualTo("0023415672"));

            Assert.That(longQrCodeDetail.Konum50, Is.Not.Null);
            Assert.That(longQrCodeDetail.Konum50.Tag, Is.EqualTo("50"));
            Assert.That(longQrCodeDetail.Konum50.LengthString, Is.EqualTo("16"));
            Assert.That(longQrCodeDetail.Konum50.Value, Is.EqualTo("3993942332851791"));

            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51, Is.Not.Null);
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.Tag, Is.EqualTo("51"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.LengthString, Is.EqualTo("91"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.Value, Is.EqualTo("00021002040010030823451017040202052312345678901234567890ABC06122007291530590712200729163059"));

            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.SurumNumarasi00, Is.Not.Null);
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.SurumNumarasi00.Tag, Is.EqualTo("00"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.SurumNumarasi00.LengthString, Is.EqualTo("02"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.SurumNumarasi00.Value, Is.EqualTo("10"));

            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.KarekodUreticiKodu02, Is.Not.Null);
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.KarekodUreticiKodu02.Tag, Is.EqualTo("02"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.KarekodUreticiKodu02.LengthString, Is.EqualTo("04"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.KarekodUreticiKodu02.Value, Is.EqualTo("0010"));

            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.KarekodReferansNumarasi03, Is.Not.Null);
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.KarekodReferansNumarasi03.Tag, Is.EqualTo("03"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.KarekodReferansNumarasi03.LengthString, Is.EqualTo("08"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.KarekodReferansNumarasi03.Value, Is.EqualTo("23451017"));

            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.TerminalTipi04, Is.Not.Null);
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.TerminalTipi04.Tag, Is.EqualTo("04"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.TerminalTipi04.LengthString, Is.EqualTo("02"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.TerminalTipi04.Value, Is.EqualTo("02"));

            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.TerminalCihazSeriNumarasi05, Is.Not.Null);
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.TerminalCihazSeriNumarasi05.Tag, Is.EqualTo("05"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.TerminalCihazSeriNumarasi05.LengthString, Is.EqualTo("23"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.TerminalCihazSeriNumarasi05.Value, Is.EqualTo("12345678901234567890ABC"));

            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.OlusturulmaZamani06, Is.Not.Null);
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.OlusturulmaZamani06.Tag, Is.EqualTo("06"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.OlusturulmaZamani06.LengthString, Is.EqualTo("12"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.OlusturulmaZamani06.Value, Is.EqualTo("200729153059"));

            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.SonGecerlilikZamani07, Is.Not.Null);
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.SonGecerlilikZamani07.Tag, Is.EqualTo("07"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.SonGecerlilikZamani07.LengthString, Is.EqualTo("12"));
            Assert.That(longQrCodeDetail.KodKimlikBilgileriSablonu51.SonGecerlilikZamani07.Value, Is.EqualTo("200729163059"));

            Assert.That(longQrCodeDetail.IsYeriKategoriKodu52, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsYeriKategoriKodu52.Tag, Is.EqualTo("52"));
            Assert.That(longQrCodeDetail.IsYeriKategoriKodu52.LengthString, Is.EqualTo("04"));
            Assert.That(longQrCodeDetail.IsYeriKategoriKodu52.Value, Is.EqualTo("5499"));

            Assert.That(longQrCodeDetail.ParaBirimi53, Is.Not.Null);
            Assert.That(longQrCodeDetail.ParaBirimi53.Tag, Is.EqualTo("53"));
            Assert.That(longQrCodeDetail.ParaBirimi53.LengthString, Is.EqualTo("03"));
            Assert.That(longQrCodeDetail.ParaBirimi53.Value, Is.EqualTo("949"));

            Assert.That(longQrCodeDetail.Tutar54, Is.Not.Null);
            Assert.That(longQrCodeDetail.Tutar54.Tag, Is.EqualTo("54"));
            Assert.That(longQrCodeDetail.Tutar54.LengthString, Is.EqualTo("12"));
            Assert.That(longQrCodeDetail.Tutar54.Value, Is.EqualTo("000000015050"));

            Assert.That(longQrCodeDetail.UlkeKodu58, Is.Not.Null);
            Assert.That(longQrCodeDetail.UlkeKodu58.Tag, Is.EqualTo("58"));
            Assert.That(longQrCodeDetail.UlkeKodu58.LengthString, Is.EqualTo("02"));
            Assert.That(longQrCodeDetail.UlkeKodu58.Value, Is.EqualTo("TR"));

            Assert.That(longQrCodeDetail.IsyeriAdi59, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsyeriAdi59.Tag, Is.EqualTo("59"));
            Assert.That(longQrCodeDetail.IsyeriAdi59.LengthString, Is.EqualTo("08"));
            Assert.That(longQrCodeDetail.IsyeriAdi59.Value, Is.EqualTo("ABC GIDA"));

            Assert.That(longQrCodeDetail.IsyeriSehri60, Is.Not.Null);
            Assert.That(longQrCodeDetail.IsyeriSehri60.Tag, Is.EqualTo("60"));
            Assert.That(longQrCodeDetail.IsyeriSehri60.LengthString, Is.EqualTo("08"));
            Assert.That(longQrCodeDetail.IsyeriSehri60.Value, Is.EqualTo("ÝSTANBUL"));

            Assert.That(longQrCodeDetail.PostaKodu61, Is.Not.Null);
            Assert.That(longQrCodeDetail.PostaKodu61.Tag, Is.EqualTo("61"));
            Assert.That(longQrCodeDetail.PostaKodu61.LengthString, Is.EqualTo("05"));
            Assert.That(longQrCodeDetail.PostaKodu61.Value, Is.EqualTo("34100"));

            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62, Is.Not.Null);
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.Tag, Is.EqualTo("62"));
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.LengthString, Is.EqualTo("75"));
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.Value, Is.EqualTo("0111TLK0123040502129031250750000306AVMSTR0410231563412306100518894111080209"));

            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.FaturaNumarasi01, Is.Not.Null);
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.FaturaNumarasi01.Tag, Is.EqualTo("01"));
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.FaturaNumarasi01.LengthString, Is.EqualTo("11"));
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.FaturaNumarasi01.Value, Is.EqualTo("TLK01230405"));

            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.MusterininTelefonNumarasý02, Is.Not.Null);
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.MusterininTelefonNumarasý02.Tag, Is.EqualTo("02"));
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.MusterininTelefonNumarasý02.LengthString, Is.EqualTo("12"));
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.MusterininTelefonNumarasý02.Value, Is.EqualTo("903125075000"));

            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.MagazaEtiketi03, Is.Not.Null);
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.MagazaEtiketi03.Tag, Is.EqualTo("03"));
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.MagazaEtiketi03.LengthString, Is.EqualTo("06"));
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.MagazaEtiketi03.Value, Is.EqualTo("AVMSTR"));

            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.MusteriSadakatNumarasi04, Is.Not.Null);
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.MusteriSadakatNumarasi04.Tag, Is.EqualTo("04"));
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.MusteriSadakatNumarasi04.LengthString, Is.EqualTo("10"));
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.MusteriSadakatNumarasi04.Value, Is.EqualTo("2315634123"));

            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.MusteriNumarasi06, Is.Not.Null);
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.MusteriNumarasi06.Tag, Is.EqualTo("06"));
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.MusteriNumarasi06.LengthString, Is.EqualTo("10"));
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.MusteriNumarasi06.Value, Is.EqualTo("0518894111"));

            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.OdemeAmaci08, Is.Not.Null);
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.OdemeAmaci08.Tag, Is.EqualTo("08"));
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.OdemeAmaci08.LengthString, Is.EqualTo("02"));
            Assert.That(longQrCodeDetail.EkVeriAlanlariSablonu62.OdemeAmaci08.Value, Is.EqualTo("09"));

            Assert.That(longQrCodeDetail.Crc63, Is.Not.Null);
            Assert.That(longQrCodeDetail.Crc63.Tag, Is.EqualTo("63"));
            Assert.That(longQrCodeDetail.Crc63.LengthString, Is.EqualTo("04"));
            Assert.That(longQrCodeDetail.Crc63.Value, Is.EqualTo("513B"));
        }
    }
}