
using System;
using System.Collections.Generic;
using System.Linq;

public class Medium
{
    public static void Main(string[] args)
    {
        // metin alma
         Console.WriteLine ("Bir Metin Giriniz\n");
         string text= Console.ReadLine();
         
         // harfleri tekrarlarının tutulacağı dic. yapısını tanımladık.
         Dictionary<char, int> letterRepeat = new Dictionary<char, int>();
        
        //döngü ile metin içinde gezecek
        foreach (char character in text)
        {
            // Harf olup olmadığı kontrol
            if(char.IsLetter(character))
            {
                // Harf küçültme işlemi
                char lowerCharacter = char.ToLower(character);

                // Sözlükte harf kontrolü
                if(letterRepeat.ContainsKey(lowerCharacter))
                {
                    // varsa tekrar sayısını arttır.
                    letterRepeat[lowerCharacter]++;
                }
                else
                {
                    letterRepeat[lowerCharacter] = 1;       
                    }
            }
        }
        
        // Azalan sıraya göre sırala ve value değerini ayır.
       char mostRepeatCharacter = letterRepeat.OrderByDescending(pair => pair.Value).First().Key;

        // Ekrana yazdır.
       Console.WriteLine($" Most repetitive letter : {mostRepeatCharacter}");
    }
}
