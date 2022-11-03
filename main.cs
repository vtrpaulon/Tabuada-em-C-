using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Tabuada 1-10");
		int x, y;
		for(x=1; x<=10; x++){
      for(y=1; y<=10; y++){
        int res = x * y;				
        Console.WriteLine(x + " x " + y + " = " + res);
      }
    }
  }
}