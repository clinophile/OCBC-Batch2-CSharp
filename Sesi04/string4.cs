using System;


    public class string4{
        public static void Main(string[] args)
        {
            string stringawal = "C# membuat string mudah.";

            string substr = stringawal.Substring(5, 12);

            Console.WriteLine("stringawal: "+stringawal);
            Console.WriteLine("substring: "+substr);
        }
    }
