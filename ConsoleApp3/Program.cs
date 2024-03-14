using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Code:
            //    try
            //    {

            //        Console.WriteLine("N ededini daxil edin");
            //        int n = Convert.ToInt32(Console.ReadLine());

            //        for (int j = 1; j <= n; j++)
            //        {
            //            for (int i = 1; i <= n; i++)
            //            {
            //                Console.WriteLine("{0}x{1}={2}", i, j, (i * j));
            //            }
            //        }
            //        Console.ReadLine();
            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("Emeliyyat dogru deyil");
            //        goto Code;

            //    }


            //-------


            //string[] names = { "Ulduz", "Fatma", "Umud", "Uğur" };


            //Console.WriteLine("Adinda u herfi olanlar:");
            //for (int i = 0; i < names.Length; i++)
            //{
            //    string name = names[i];
            //    bool u = false;
            //    foreach (char harf in name)
            //    {
            //        if (harf == 'u' || harf == 'U')
            //        {
            //            u = true;
            //            break;
            //        }
            //    }

            //    if (u)
            //    {
            //        Console.WriteLine(name);


            //        string newname = "";
            //        foreach (char harf in name)
            //        {
            //            if (harf == 'u')
            //                newname += 'e';
            //            else if (harf == 'U')
            //                newname += 'E';
            //            else
            //                newname += harf;
            //        }
            //        Console.WriteLine("Deyisdikden sonra: " + newname);


            //        names[i] = newname;
            //    }
            //}


            //Console.WriteLine("Massivin yeni hali");
            //foreach (string item in names)
            //{
            //    Console.WriteLine(item);
            //}









            //int[] arr = { 1, 23, 3, 4, 25, 6, 9, 7, 11 };


            //int arrayuzunluq = arr.Length / 3;
            //int kalan = arr.Length % 3;


            //int Index = 0;
            //for (int i = 0; i < 3; i++)
            //{

            //    int parca = arrayuzunluq + (i < kalan ? 1 : 0);


            //    Console.Write($"Massiv {i + 1}: ");
            //    for (int j = 0; j < parca; j++)
            //    {
            //        Console.Write(arr[Index + j] + " ");
            //    }
            //    Console.WriteLine();


            //    Index += parca;
        }
    }
}
