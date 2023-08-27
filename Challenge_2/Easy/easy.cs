using System;

public class Easy
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine ("Please enter a positive number greater than 0.");
        // Input alınıp tipi düzeltildi.
        int number = Convert.ToInt32(Console.ReadLine());
        
        if(number > 0)
        {
            if(number == 2)
            {
            Console.WriteLine("The number is prime");
            }
            if(number == 1)
            {
                Console.WriteLine("The number is not prime");
            }else
            {
            int count = 2;
            bool isPrime = true;
            
            // Döngü
            while(count < number)
            {
                if(number % count == 0)
                {
                    isPrime= false;
                    break;
                }
                count ++;
            }
            
            if (isPrime)
            {
                Console.WriteLine("The number is prime.");
            }
            else
            {
                Console.WriteLine("The number is not prime.");
            }
            }
        }else
        {
            Console.WriteLine ("Please enter a positive number greater than 0.");
        }
}
}