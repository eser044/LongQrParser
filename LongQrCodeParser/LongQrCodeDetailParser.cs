using System;
using System.Collections.Generic;
using System.Linq;
using LongQrCodeParser.HasSubTags;
using LongQrCodeParser.SubTags;

namespace LongQrCodeParser
{
    public static class LongQrCodeDetailParser
    {
        public static T Parse<T>(string input) where T :  ITlvCollectionData, new()
        {
            var tlvList = SplitToTlvFields(input);
            var collectionData = new T();
            for (var i = 0; i < collectionData.Tlvs.Count; i++)
            {
                var dataTlv = collectionData.Tlvs[i];
                var find = tlvList?.Find(x => x.Tag.Equals(i.ToString("00")));

                Tlv parsed;
                if (dataTlv is IsyeriHesapBilgileri26) parsed = Parse<IsyeriHesapBilgileri26>(find?.Value);
                else if (dataTlv is IsyeriHesapBilgileri30) parsed = Parse<IsyeriHesapBilgileri30>(find?.Value);
                else if (dataTlv is KareKodKimlikBilgileriSablonu51) parsed = Parse<KareKodKimlikBilgileriSablonu51>(find?.Value);
                else if (dataTlv is EkVeriAlanlariSablonu62) parsed = Parse<EkVeriAlanlariSablonu62>(find?.Value);
                else if (dataTlv is IsyeriLisanBilgiSablonu64) parsed = Parse<IsyeriLisanBilgiSablonu64>(find?.Value);
                else parsed = find;

                int index = i;
                if (find != null)
                    index = Convert.ToInt32(find.Tag);

                collectionData.Tlvs[index] = parsed;
                if (find != null)
                {
                    collectionData.Tlvs[index].Value = find.Value;
                    collectionData.Tlvs[index].Tag = find.Tag;
                    collectionData.Tlvs[index].Length = find.Length;
                }
            }

            return collectionData;
        }

        public static List<Tlv> SplitToTlvFields(string input)
        {
            var tlvs = new List<Tlv>();
            SplitToTlvFields(input, tlvs);
            return tlvs;
        }

        private static void SplitToTlvFields(string input, List<Tlv> tlvs)
        {
            if (!string.IsNullOrEmpty(input))
            {
                var tlv = new Tlv();
                SetTlvValue(input, tlv);
                tlvs.Add(tlv);
                var tostring = $"{tlv.Tag}{tlv.LengthString}{tlv.Value}";
                var subInput = input.Substring(tostring.Length, input.Length - tostring.Length);
                SplitToTlvFields(subInput, tlvs);
            }
        }

        private static void SetTlvValue(string input, Tlv tlv)
        {
            tlv.Tag = input.Substring(0, 2);
            var length = input.Substring(tlv.Tag.Length, 2);

            if (string.IsNullOrEmpty(length))
                throw new ArgumentNullException($"Length is Null Or Empty");
            if (!length.Trim().All(char.IsNumber))
                throw new ArgumentException("Length is Not Numeric");

            tlv.Length = Convert.ToInt32(length);
            tlv.Value = input.Substring((tlv.Tag.Length + tlv.LengthString.Length), tlv.Length);
        }
    }
}