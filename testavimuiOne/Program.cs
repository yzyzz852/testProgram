using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testavimuiOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 9, c = 12, d = 22, e = 13;
            int[] arr = {a, b, c, d, e};
            
            Console.WriteLine("Irasyti skaiciu: ");
            List<String> testOne = new List<string>();
            List<String> testTwo = new List<string>();
            testTwo.Add("a");
            testOne.Add("a");
            testTwo.Add("a");
            testOne.Add("b");

            string inputString = "080400000113FC208DFF000F14F650209CCA80006F00D60400040004030101150316030001460000015D0000000113FC17610B000F14FFE0209CC580006E00C00500010004030101150316010001460000015E0000000113FC284945000F150F00209CD200009501080400000004030101150016030001460000015D0000000113FC267C5B000F150A50209CCCC0009300680400000004030101150016030001460000015B0004";
            var bytes = new byte[inputString.Length / 2];
            var howMuchBytes = new byte[inputString.Length / 2];
            string test = bytes.ToString();
            Enumerable.SequenceEqual(testOne, testTwo);
            //Console.WriteLine(Enumerable.SequenceEqual(testOne, testTwo));
            for (int i = 0; i < testOne.Count; i++)
            {
                for (int j = 0; i < testTwo.Count; i++)
                {
                    Console.WriteLine(Enumerable.SequenceEqual(testOne[i], testTwo[j]));
                }
            }

            //for (var i = 0; i < inputString.Length; i++)
            //{
            //    howMuchBytes[i / 2] = Convert.ToByte(inputString.Substring(i, 2), 16);
            //    Console.WriteLine(howMuchBytes);
            //}

            //for (var i = 0; i < inputString.Length; i++)
            //{
            //    bytes[i / 2] = Convert.ToByte(inputString.Substring(i, 2), 16);
            //    Console.WriteLine(bytes);
            //}



            //DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            //double dz = double.Parse("255141322525");  // Or avoid parsing if possible :)
            //Console.Write(dt.AddMilliseconds(dz));


            string stringArray ="08010000015908178fd8000f0fcaf1209a953c006900dd0e0022000e050101f0015001150351220142375308c700000036f10000601a520000000053000069de54000000205500000387570d4a9e50640000006f0001";
            byte[] bytesArray = Encoding.ASCII.GetBytes(stringArray);

            //Console.WriteLine(StringToByteArray(stringArray));

            //string input = "AA 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF";
            //byte[] bytess = input.Split().Select(s => Convert.ToByte(s, 16)).ToArray();

            //Console.WriteLine(Convert.ToString(bytess));
            //foreach (var v in bytesArray)
            //{
            //    Console.WriteLine(v);
            //}

            var parts = stringArray.SplitInParts(2);
            Console.WriteLine(String.Join(", 0x", parts));
            var testx = String.Join(", 0x", parts);


            Console.ReadLine();
        }//psvm

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
        }

        
    }//class

    static class StringExtensions
    {

        public static IEnumerable<String> SplitInParts(this String s, Int32 partLength)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (partLength <= 0)
                throw new ArgumentException("Part length has to be positive.", "partLength");

            for (var i = 0; i < s.Length; i += partLength)
                yield return s.Substring(i, Math.Min(partLength, s.Length - i));
        }

    }
}//namespace


















/* 1-2 *********************************
 * 
 * *************************208psl 1
 * 
 * 
 * 
 * *******************************************5
 * int? skaicius = int.Parse(Console.ReadLine());

            switch (skaicius)
            {
                case 1:
                    Console.WriteLine("Vienas");
                    break;
                case 2:
                    Console.WriteLine("Du");
                    break;
                case 3:
                    Console.WriteLine("Trys");
                    break;
                case 4:
                    Console.WriteLine("Keturi");
                    break;
                case 5:
                    Console.WriteLine("Penki");
                    break;
                case 6:
                    Console.WriteLine("Sesi");
                    break;
                case 7:
                    Console.WriteLine("Septyni");
                    break;
                case 8:
                    Console.WriteLine("Astuoni");
                    break;
                case 9:
                    Console.WriteLine("Devyni");
                    break;
                case 10:
                    Console.WriteLine("Desim");
                    break;
            }

 * 
 * 
 * 
 * ***************************************10
 * Console.WriteLine("Kiek points: ");
            int test = int.Parse(Console.ReadLine());
            Console.WriteLine(test);
            if (1 <= test && test <= 3)
            {
                Console.WriteLine("Total: "+ test * 10);
            }
            else if (4 <= test && test <= 6)
            {
                Console.WriteLine("Total: " + test * 100);
            }
            else if (7 <= test && test <= 9)
            {
                Console.WriteLine("Total: " + test * 1000);
            }
            else
            {
                Console.WriteLine("blogas tasku kiekis (tarp 0 ir 9)");
            }
 * 
 * 
 * ****************************8
 *  Console.WriteLine("Pasirinkite: ");
            Console.WriteLine("1 - INT");
            Console.WriteLine("2 - DOUBLE");
            Console.WriteLine("3 - STRING");
            test = int.Parse(Console.ReadLine());
            switch (test)
            {
                case 1:
                    Console.WriteLine("INT");
                    break;
                case 2:
                    Console.WriteLine("DOUBLE");
                    break;
                case 3:
                    Console.WriteLine("STRING");
                    break;
            }
 * 
 * 
 * 
 * 
 * 
 * 
 * 
            int a = 8, b = 6;
            Console.WriteLine("A: "+a+" B: "+b);
            if (a > b)
            {
                int laikinas;
                laikinas = a;
                a = b;
                b = laikinas;
                Console.WriteLine("A: " + a + " B: " + b);
            }
            else
            {
                Console.WriteLine("Viskas ok");
            }

 * 
 * 
 * 
 * 
 *             int a = 10, b = 9, c = 12;
            int[] arr = {a, b, c};

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Array.Sort(arr);
            Console.WriteLine(arr);

            Console.WriteLine("******************************");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Array.Reverse(arr);
            Console.WriteLine("******************************");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

 * 
 * 
 * 
 * 
 * * 
*****************************2 *
* if (a > b && a > c)
            {
                Console.WriteLine("A " +a);
            }
            else if(b>a && b>c)
            {
                Console.WriteLine("B " + b);
            }
            else
            {
                Console.WriteLine("C " + c);
            }

            Console.ReadLine();
 *  int number;
            int x = 5;
            Console.WriteLine("Insert number: ");
            number = Convert.ToInt32(Console.ReadLine());

            
            if (number % x == 0 && number % x == 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.ReadLine();
            Console.ReadLine();
Console.ReadLine();


    *4444444444444444444
    *             //int number;
            //Console.WriteLine("Insert number: ");
            //number = Convert.ToInt32(Console.ReadLine());
            //byte[] intBytes = BitConverter.GetBytes(number);

            //if (BitConverter.IsLittleEndian)
            //    Array.Reverse(intBytes);

            //byte[] result = intBytes;

            //var input = result;
            //var result1 = string.Concat(input.Select(b => Convert.ToString(b, 2)));
            //Console.WriteLine(BitConverter.ToString(result));
            //Console.WriteLine(result1);

            //Console.ReadLine();


    *************************5
     static void Main(string[] args)
        {
            int a, b, h;
            Console.WriteLine("Ivesti a: ");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ivesti b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ivesti auksti: ");
            h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Plotas lygus: " + skaicevimai(a,b,h));


            Console.ReadLine();
        }//psvm

        public static int skaicevimai(int a, int b, int h)
        {
            int m = (a + b) / 2;
            int s = m * h;
            return s;
        }

    **********************7
    *    float ratio = 0.17f;
            float manWeigt = 63f;
            float inMoon =manWeigt -(manWeigt * ratio);
            Console.WriteLine(inMoon);




            Console.ReadLine();


    *********************************************10
    *    int keturzenklis, a, b, c, d;
            Console.WriteLine("Yrasyti 4-zenkli skaiciu: ");
            keturzenklis = Convert.ToInt32(Console.ReadLine());
            d = (keturzenklis % 10);
            c = (keturzenklis / 10) % 10;
            b = (keturzenklis / 100) % 10;
            a = (keturzenklis / 1000) % 10;
            Console.WriteLine("A: " +a+ " B: " +b+ " C: " +c+ " D: " +d);
            Console.WriteLine("Suma: "+ (a+b+c+d));
            Console.WriteLine("Reversed: " +d+c+b+a);
            Console.WriteLine("Paskutinio skaitments swap i pirma: "+d+b+c+a);
            Console.WriteLine("Swap treces su antruoju: " +a+c+b+d);

            Console.ReadLine();



    ***************************************192psl 5 uzduot
    *     int one, two, counter = 0;
            List<int> listOfInts = new List<int>();
            Console.WriteLine("Pirmas skaitmo: ");
            one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Antras skaitmuo: ");
            two = Convert.ToInt32(Console.ReadLine());

            for (int i = one; i <= two; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                    listOfInts.Add(i);
                }
            }
            Console.WriteLine("isviso dalinasi (is 5) : " + counter);
            foreach (var v in listOfInts)
            {
                Console.WriteLine(v);
            }

            Console.ReadLine();
            **************************************6
            * int a, b = 0;
            Console.WriteLine("Irasyti skaicius (1-a, 2-b)");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Didesnis skaitmuo yra: " + Math.Max(a,b));
            Console.WriteLine("Mazesnis skaitmuo yra: " + Math.Min(a, b));
            Console.ReadLine();


    *******************9
    * int howMuch,a = 0 ,b = 0;
           
           // a = int.Parse(Console.ReadLine());
           // b = int.Parse(Console.ReadLine());
            Console.WriteLine("kiek bus skaitmenu");
            howMuch = int.Parse(Console.ReadLine());
            int[] mebers = new int[howMuch];
            Console.WriteLine("Irasyti:");
            for (int i = 0; i < howMuch; i++)
            {
                mebers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ivesti skaitmenys");
            for (int i = 0; i < mebers.Length; i++)
            {
                Console.WriteLine(i+" Member is: " + mebers[i] );
                a = a + mebers[i];
            }
            Console.WriteLine("Ju suma lygi: "+a);
            Console.ReadLine();
*/
