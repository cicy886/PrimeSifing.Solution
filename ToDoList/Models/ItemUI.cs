using System;
using System.Collections.Generic;

class ItemUI{

    static void PrimeNumer(int number){
        //init empty integer list
        //for loop to number from user
      for (int i=2; i <= number; i++){
        if (i == 2 || i == 3 || i == 5 || i == 7){
          Console.WriteLine(i + " is prime.");   
        } else if (i %2 != 0 && i %3 != 0 && i %5 != 0 && i %7 != 0){
          Console.WriteLine(i + " is prime.");   
        }
      }
    }

    static void Main(){
        Console.Clear();
        Console.WriteLine("Please enter an interger:");
        string userInput = Console.ReadLine();
        int intUserInput = int.Parse(userInput);
        PrimeNumer(intUserInput);
    }
}