using System;
using System.Collections.Generic;
using LongQrCodeParser.HasSubTags;

// ReSharper disable IdentifierTypo

namespace LongQrCodeParser
{
    public class LongQrCodeDetail : ITlvCollectionData
    {
        public List<Tlv> Tlvs { get; set; }

        public string KareKodBicimGostergesi => Tlvs[0].Value;
        public string KareKodTuru => Tlvs[1].Value;

        public LongQrCodeDetail()
        {
            Tlvs = new List<Tlv>();
            for (int i = 0; i <= 25; i++)
            {
                Tlvs.Add(new Tlv()); // TODO buradaki new'lemeler sadece tip'i belirtmek için yapıldı, farklı şekilde yapılmalı see TODO #B
            }

            Tlvs.Add(new IsyeriHesapBilgileri26());
            Tlvs.Add(new Tlv());
            Tlvs.Add(new Tlv());
            Tlvs.Add(new Tlv());
            Tlvs.Add(new IsyeriHesapBilgileri30());

            for (int i = 30; i < 66; i++)
            {
                Tlvs.Add(new Tlv());
            }
        }

        // TODO #B burası kullanılacak
        private static Dictionary<int, Type> _mappings;
        static Dictionary<int, Type> GetTypeMappings()
        {
            if (_mappings == null)
            {
                var typeMappings = new Dictionary<int, Type>();

                for (int i = 0; i <= 25; i++)
                {
                    typeMappings.Add(i, typeof(Tlv));
                }

                typeMappings.Add(26, typeof(IsyeriHesapBilgileri26));
                typeMappings.Add(27, typeof(Tlv));
                typeMappings.Add(28, typeof(Tlv));
                typeMappings.Add(29, typeof(Tlv));
                typeMappings.Add(30, typeof(IsyeriHesapBilgileri30));

                for (int i = 30; i < 66; i++)
                {
                    typeMappings.Add(i, typeof(Tlv));
                }

                _mappings = typeMappings;
            }
            return _mappings;
        }


    }
}