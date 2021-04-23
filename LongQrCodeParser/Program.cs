using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongQrCodeParser
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 80; i <= 99; i++)
            {
                Console.WriteLine($"public Tlv SerbestSablon{i.ToString("00")} => Tlvs[{i}];");
            }
        }
    }

}
