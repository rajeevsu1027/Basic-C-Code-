// Write a C# Sharp program to swap two numbers.


using System;

namespace MyCoding 
{
class Swap
{
	static void Main(string[] args)
    {	
      Console.WriteLine("Input the numbers to be swapped "); 
      int a = Convert.ToInt32(Console.ReadLine());
	  int b = Convert.ToInt32(Console.ReadLine());
	  Console.WriteLine("Input numbers are before swapping  : "+a +" "+b); 
	  myswap(a,b);
      Console.ReadKey();	  
    }
	
	public static void myswap(int x , int y)
	{
		x = x + y ;
		y = x - y;
		x = x - y;
		Console.WriteLine("After Swapping the values are : "+x + " " + y);
	}
}
}