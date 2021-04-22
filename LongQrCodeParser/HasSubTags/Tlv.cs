namespace LongQrCodeParser.HasSubTags
{

    public class Tlv // TODO olacak Tlv<T>
    {
        public int Length { get; set; }
        public string Tag { get; set; }
        public string Value { get; set; }


        public string LengthString => Length.ToString("00");
    }
}
