using System;

class Program {
  public static void Main (string[] args) {
    int[] primes = new int[9];
    

    for(int i =2; i<10000; i++)
    {
      for(int j =2; j<i; i++)
      {
        if (i%j!=0)
        {
          primes[i] = i;
        }
       
          
      }
      if(primes[i]!=0)
      {
        Console.WriteLine(primes[i]);
      }
    }
    
    
  }
}