using System;

namespace c
{
    class Program
    {
     public static void staircase(int sayi)
    {
        int[] sayilar = new int[sayi];

        for (int i = 0; i < sayi; i++)
        {
            sayilar[i] = i;
        }



        foreach (var item in sayilar)
        {
            if(item%2==0)
            {
            Console.WriteLine(item);
            }
        }
        
    }

    static void Main(string[] args)
    {
        int n= Convert.ToInt32(Console.ReadLine().Trim());
        
        staircase(n);
         
        

    }
        
        
      
    }
    
}