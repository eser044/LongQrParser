namespace LongQrCodeParser
{

    public class Tlv // TODO olacak Tlv<T>
    {
        public int Length { get; set; }
        public string Tag { get; set; }
        public string Value { get; set; }
        public string LengthString => Length > 0 ? Length.ToString("00") : null;

        public override string ToString()
        {
            return $"{Tag}{LengthString}{Value}";
        }
        public string FormatedToString()
        {
            return $"Tag : {Tag}   Length : {LengthString}   Value : {Value}";
        }
    }
}
