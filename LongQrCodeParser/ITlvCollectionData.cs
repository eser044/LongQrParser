using System.Collections.Generic;
using LongQrCodeParser.HasSubTags;

namespace LongQrCodeParser
{
    public interface ITlvCollectionData
    {
        List<Tlv> Tlvs { get; set; }
    }
}