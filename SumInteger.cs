//  Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum.
using System;

namespace MyCoding 
{
class SumInteger
{
	static void Main(string[] args)
    {	
      Console.WriteLine("Input the numbers to calculate sum"); 
      int a = Convert.ToInt32(Console.ReadLine());
	  int b = Convert.ToInt32(Console.ReadLine());
	  int sum = sumlogic(a,b);
	  Console.WriteLine("Sum of Input numbers are : "+sum); 
	  Console.ReadKey();	  
    }
	
	public static int sumlogic(int x , int y)
	{
		if( x == y){
			return  (x+y)*3 ;
		}
		else {
			return x+y ;
		}
		
		return -1;
	}
}
}