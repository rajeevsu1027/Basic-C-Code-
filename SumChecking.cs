//Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20.

using System;

namespace MyCoding 
{
class SumChecking
{
	static void Main(string[] args)
    {	
      Console.WriteLine("Input the numbers to calculate sum"); 
      int a = Convert.ToInt32(Console.ReadLine());
	  int b = Convert.ToInt32(Console.ReadLine());
	  bool sum = sumlogic(a,b);
	  Console.WriteLine("Sum of Input numbers are : "+sum); 
	  Console.ReadKey();	  
    }
	
	public static bool sumlogic(int x , int y)
	{
		int c = x + y;
		if((c == 20) || ( x == 20) || (y == 20)){
			return true ;
		}
		
		
		return false;
	}
}
}