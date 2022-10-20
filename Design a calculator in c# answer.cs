using System;
class Program {
  public static void Main (string[] args) {
   
  Console.WriteLine("Enter your arithmeticoperation");
    string arithmeticoperation=Console.ReadLine();
int a=20, b=10;
    switch(arithmeticoperation )
    {
      case "+" : Console.WriteLine((a+b));
        break;
      case "-" : Console.WriteLine((a-b));
        break;
      case "*" : Console.WriteLine((a*b)); 
        break;
      case "/" : Console.WriteLine((a/b));
        break;
      case "%" : Console.WriteLine((a%b));
        break;
    }
  }
}
