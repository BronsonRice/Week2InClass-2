//boilerplate code

using System;

class Program {
  public static void Main (string[] args) {
    
    Console.WriteLine("Week2InClass");
    /*multi lined comments
    dsdsdf
    sdfsd
    */

    //Declariing a variable
    int thumbsup = 0;
    int oranges 200;
    double salary;
    string message= "Hello";
    thumbsup = thumbsup + 1;
    salary =3.99;
    int sum = 0;

    // Arithmetic operators + - * / %
    // Assignment operator =

     sum = oranges + 5;


    //Output statements
     Console.WriteLine("sum=" + sum);
     Console.WriteLine("oranges=" + oranges);

     Console.WriteLine("Enter number of oranges");//Prompt
     oranges = Convert.ToInt32(Console.ReadLine());//Input and Convert to interger 
     oranges = oranges - 1;//Logic
     Console.Writeline("Number of oranges = " + oranges);//Output
  }
}