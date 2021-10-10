using System;
using System.Linq;
class Program {
  public static void Main (string[] args) {



    double[] celsius= new double[7];
    double[] farenheit= new double[7];

    for(int pos=0; pos < 7; pos++){
          
      Console.WriteLine("Enter temperature in Celsius.");
      celsius[pos] = Convert.ToDouble(Console.ReadLine());

      farenheit[pos] = celsius[pos] * 1.8 + 32;
    

    }
   
   Console.WriteLine("Temperature in farenheit.");
     Array.Sort(farenheit);
     
   foreach (int item in farenheit){
    Console.WriteLine(item);
  
   }
  double sum = farenheit.Sum();
  double avg = sum/7;
  Console.WriteLine("Average weekly temperature is " + avg + " degrees farenheit.");
  }
  }
