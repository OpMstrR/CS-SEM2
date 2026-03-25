using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ModulkStetyi
{

    

    class FileOperations
    {

        public delegate int TextOperation(string text);


        internal static string ProcessFile(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string content = sr.ReadToEnd();
                return content;
            }
            
        }
        internal static int Symbols(string filePath)
        {

                string content = ProcessFile(filePath);
                int new_symb = 0;
               
                foreach (char str in content)
                {
                    string str_conv = str.ToString();
                    new_symb++;
                }

                Console.WriteLine("Кількість символів:");
                return new_symb;

            
        }
        internal static string UpperCase(string filePath)
        {
            string content = ProcessFile(filePath);
 
            return content.ToUpper();
            
               
        }




        internal static int Words(string filePath)
        {

            string content = ProcessFile(filePath);

            int new_word = 0;
                /*
                int test = 0;
                int test2 = 0;
                int test3 = 0;
                */
                int start = 1;


            foreach (char str in content)
            {
                string str_conv = str.ToString();
                if ((str_conv == " ") || (str_conv == "\n"))
                {
                    new_word++;
                }


                if ((str_conv == " ") && (start == 1))
                {
                    new_word++;
                    start = 0;
                    continue;
                }
                
            }
            Console.WriteLine("Кількість слів:");
            return new_word;
            /*

            if ((str_conv == " ") && (test ==1))
            {
                test = 0;
                continue;
            }

            if ((str_conv == "\n") && (test2 == 1))
            {
                test2 = 0;
                continue;
            }

            if ((str_conv == ".") && (test3 == 1))
            {
                test2 = 0;
                continue;
            }

            if (str_conv == " ")
            {
                new_word++;
                test = 1;
            }

            if (str_conv == "\n")
            {
                new_word++;
                test2 = 1;
            }


            if (str_conv == ".")
            {
                new_word++;
                test3 = 1;
            }
            */






        }
    }
}
