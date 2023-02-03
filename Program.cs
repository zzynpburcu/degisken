using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            string  strdeger= "20";
            int intdeger=20;

            string deger= intdeger.ToString()+strdeger;
            Console.WriteLine(deger); //  Çıktısı 2020

            int deger1= intdeger+Convert.ToInt32(strdeger);
            Console.WriteLine(deger1); //  Çıktısı 40

            int deger2= intdeger+int.Parse(strdeger);
            Console.WriteLine(deger2); //  Çıktısı 40

            string datetime=DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime); //   Çıktısı 03.02.2023

            string datetime1=DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime1); //   Çıktısı 03/02/2023

            string datetime2=DateTime.Now.ToString("HH:mm");
            Console.WriteLine(datetime2);  //   Çıktısı 02:04
        }
    }
}
