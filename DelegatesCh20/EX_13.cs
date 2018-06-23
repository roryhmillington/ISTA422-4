using System;

using System.Collections.Generic;

using System.Security.Cryptography;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ex13_Cipher

{

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter plain Text");

            string plain_text = Console.ReadLine();

            Console.WriteLine($"You entered [{plain_text}]");



            Console.WriteLine("Enter your key as an upper case letter");

            string key = Console.ReadLine();

            Console.WriteLine($"You entered [{key}]");





            //Go to Clean Method



            int[] clean_text = Clean(plain_text);

            int enc_length = 0;



            for (int i = 0; i < clean_text.Length; i++)

            {

                Console.Write($"[{clean_text[i]}] ");

                if (clean_text[i] >= 65 || clean_text[i] <= 90) 

                {

                    enc_length++;

                }

            }

            Console.WriteLine();





            int[] clean_key = Clean(key);



            for (int i = 0; i < clean_key.Length; i++)

            {

                Console.Write($"Clean Key: [{clean_key[i]}] ");

                string encrypted = Encrypted(clean_text, clean_key, enc_length);

            }

            Console.WriteLine();

        }



        static string Encrypted(int[] clean_text, int[] clean_key, int len)

        {

            //int len = clean_text.Length;

            int[] encrypted = new int[len];



            for (int i = 0; i < len; i++)

            {

                encrypted[i] = clean_text[i] + clean_key[0] - 64;

                if(encrypted[i]>90)

                {

                    encrypted[i] -= 26;

                }

            }

            char[] char_result = new char[len];

            for (int i = 0; i < len; i++)

            {

                char_result[i] = (char)encrypted[i];

            }

            string result = new string(char_result);//adds char together to make new string

            return result;

        }



        static int[] Clean(string input)

        {

            int[] result = new int[input.Length];

            for (int i = 0, j = -1; i < input.Length; i++)

            {

                int c = (int)input[i];

                if (c > 90)

                {

                    c -= 32;

                }

                if (c < 65 || c > 90)

                {

                    continue;

                }

                else

                {

                    result[++j] = c;

                }



                Console.WriteLine($"{c} == {input[i]} == " + $" {(char)c} == {result[j]} ");

            }

            return result;

        }

    }

}