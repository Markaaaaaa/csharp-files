using System;
class Program {
  public static void Main (string[] args) {
   
  
    int a,b;
    Console.WriteLine("Enter your number");
    a= Convert.ToInt32(Console.ReadLine());
    b= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter your arithmeticoperation");
    string arithmeticoperation=Console.ReadLine();
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
      default: Console.WriteLine("other choice");
        break;
    }
  }
}
