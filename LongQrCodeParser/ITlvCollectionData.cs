using System.Collections.Generic;

namespace LongQrCodeParser
{
    public interface ITlvCollectionData
    {
        List<Tlv> Tlvs { get; set; }
    }
}