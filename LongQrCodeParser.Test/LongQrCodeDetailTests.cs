using LongQrCodeParser.HasSubTags;
using NUnit.Framework;

namespace LongQrCodeParser.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string input = @"00020101021126680010TR.COM.BKM060110820012345678901234567890910TDVMAUJ0001001N110203491000234156725195000210020400010312180904121314040202052312345678901234567890ABC0612200529140159071220052915015952041234530394954120000000001235802TR5906ABCDEF6008ISTANBUL6304C2B6";

            //00 02 01 
            //01 02 11
            //26 68 0010TR.COM.BKM060110820012345678901234567890910TDVMAUJ0001001N110203
            //		00 10 TR.COM.BKM
            //		06 01 1
            //		08 20 01234567890123456789
            //		09 10 TDVMAUJ000
            //		10 01 N
            //		11 02 03		
            //491000234156725195000210020400010312180904121314040202052312345678901234567890ABC0612200529140159071220052915015952041234530394954120000000001235802TR5906ABCDEF6008ISTANBUL6304C2B6

            var longQrCodeDetail = LongQrCodeDetailParser.Parse<LongQrCodeDetail>(input);

            Assert.That(longQrCodeDetail, Is.Not.Null);
            Assert.That(longQrCodeDetail.Tlvs, Is.Not.Null);
            Assert.That(longQrCodeDetail.Tlvs[0], Is.Not.Null);
            Assert.That(longQrCodeDetail.Tlvs[0].Tag, Is.EqualTo("00"));
            Assert.That(longQrCodeDetail.Tlvs[0].LengthString, Is.EqualTo("02"));
            Assert.That(longQrCodeDetail.Tlvs[0].Value, Is.EqualTo("01"));
            Assert.That(longQrCodeDetail.Tlvs[26], Is.Not.Null);
            Assert.That(longQrCodeDetail.Tlvs[26].Tag, Is.EqualTo("26"));
            Assert.That(longQrCodeDetail.Tlvs[26].LengthString, Is.EqualTo("68"));
            Assert.That(longQrCodeDetail.Tlvs[26].Value, Is.EqualTo("0010TR.COM.BKM060110820012345678901234567890910TDVMAUJ0001001N110203"));
            var field26 = longQrCodeDetail.Tlvs[26] as IsyeriHesapBilgileri26;
            Assert.That(field26, Is.Not.Null);
            Assert.That(field26.Tlvs[0], Is.Not.Null);
            Assert.That(field26.Tlvs[0].Tag, Is.EqualTo("00"));
            Assert.That(field26.Tlvs[0].LengthString, Is.EqualTo("10"));
            Assert.That(field26.Tlvs[0].Value, Is.EqualTo("TR.COM.BKM"));
            Assert.That(field26.Tlvs[6], Is.Not.Null);
            Assert.That(field26.Tlvs[6].Tag, Is.EqualTo("06"));
            Assert.That(field26.Tlvs[6].LengthString, Is.EqualTo("01"));
            Assert.That(field26.Tlvs[6].Value, Is.EqualTo("1"));
            Assert.That(field26.Tlvs[11], Is.Not.Null);
            Assert.That(field26.Tlvs[11].Tag, Is.EqualTo("11"));
            Assert.That(field26.Tlvs[11].LengthString, Is.EqualTo("02"));
            Assert.That(field26.Tlvs[11].Value, Is.EqualTo("03"));

            Assert.That(longQrCodeDetail.KareKodBicimGostergesi , Is.EqualTo("01"));
            Assert.That(longQrCodeDetail.KareKodTuru , Is.EqualTo("11"));
        }
    }
}