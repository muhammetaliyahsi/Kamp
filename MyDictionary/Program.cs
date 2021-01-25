using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> sozluk = new MyDictionary<int,string>();
            sozluk.Add(0, "Muhammet");
            sozluk.Add(1, "Ali");
            sozluk.Add(2, "Yahşi");
            Console.WriteLine(sozluk.keys[0]+" : "+ sozluk.values[0]);
            Console.WriteLine(sozluk.keys[1] + " : " + sozluk.values[1]);
            Console.WriteLine(sozluk.keys[2] + " : " + sozluk.values[2]);
        }
    }
}
