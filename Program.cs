using System;
using System.Diagnostics;
namespace DataType
{
  public class Ticket
  {
    public void Ticekts()
    {   
        bool isStudent = false;
        int age= 10;
        if(age <0){
        Console.WriteLine("Invalid age");
            return;
        }
        
        if(age >=0 && age < 13 ||isStudent)
        Console.WriteLine("Price $8");
        
        else if (age >=13 && age < 64)
        Console.WriteLine("Price $10");

        else if (age >= 64)
        Console.WriteLine("Price $7");
    }
  }
  class Program {
    static void Main (string[] args){
    Ticket ticke = new Ticket();
     ticke.Ticekts();
    }
  }
}