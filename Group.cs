using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Group[] groups;
            string str, indexstr;
            int count;
            int index;
            
            do
            {
                Console.WriteLine("Sayi daxil edin: ");
                str = Console.ReadLine();
                count = Convert.ToInt32(str);

            } while (count<0);

            groups.Length = count;
            for (int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine($"{i+1}.ci indexsi daxil edin");
                indexstr = Console.ReadLine();
                index = Convert.ToInt32(indexstr);//burdan sonrasi yaza bilmedim

            }


           
        }
    }
}
