
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int birthDate;
        int age ;
        int year; // değişken tanımladık.
        
         Console.WriteLine ("Hangi yilda dogdunuz?");
         birthDate = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Hangi yildasiniz ?");
    
        year = Convert.ToInt32(Console.ReadLine());
        //değişkenimize klavyeden alacağımız verinin atamasını gerçekleştirdik
        age = year - birthDate;
        Console.WriteLine (age +" yasindasiniz");
      
    }
}