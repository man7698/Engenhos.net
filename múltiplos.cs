using System;

public class multiplos
{
    static public void Main ()
    {
        Console.WriteLine ("digite o valor");
        int valor = int.Parse(Console.ReadLine());
        int a = 3; 
        int b = 5; 
        int resp = 0;
        for(int i = 0; i < valor; i++)
        { 
           if(i % a == 0 || i % b == 0)
           {
              resp += i;
           } 
         
        } 
        
        Console.WriteLine("A soma dos multiplos de 3 e 5 é "+ resp.ToString());
    }

}
