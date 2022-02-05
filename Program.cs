using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datentypen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datentypen geben an, welche Art von Wert gespeichert werden.

            //Numerische Datentypen (Ganzzahlen)
            //byte              (0 - 255) 8bit,
            byte zahl1 = 200;
            //short             (-32.768 - 32767) 16bit,
            short zahl2 = -20000;
            //int               (-2.147.483.648 - 2.147.483.647) 32bit,
            int zahl3 = -2000000;
            //long              (-9.223.372.036.854.775.808 - 9.223.372.036.854.775.807) 64bit, 
            long zahl4 = -333333333333;
            //sbyte             (-128 - 127) 8bit,
            sbyte zahl5 = -3;
            //ushort            (0 - 65.535) 16bit,
            ushort zahl6 = 40000;
            //uint              (0 - 4.294.967.295) 32bit,
            uint zahl7 = 405905405;
            //ulong             (0 - 18.446.744.073.709.551.615) 64bit
            ulong zahl8 = 10234223424423423424;

            //Fließkommazahlen
            //float             -3,402823E+38 - 3,402823E+39 4Bytes
            //double            -1,79769313486232E+308 - 1,79769313486232E+308 8Bytes
            //decimal           -79228162514264337593543950335 - 79228162514264337593543950335 16Bytes

            //Andere Datentypen
            //Bool(Boolean)     True oder False Ausgabe
            //String            Textwerte (Bsp: "Hallo Welt")
            //Char              Einzelne Textzeichen (Bsp. ,B')

            //Console.WriteLine(Datentyp.MinValue);
            //Console.WriteLine(Datentyp.MaxValue);

            Console.WriteLine(zahl1);
            Console.WriteLine(zahl2);
            Console.WriteLine(zahl3);
            Console.WriteLine(zahl4);
            Console.WriteLine(zahl5);
            Console.WriteLine(zahl6);
            Console.WriteLine(zahl7);
            Console.WriteLine(zahl8);

            Console.ReadKey();
        }
    }
}
