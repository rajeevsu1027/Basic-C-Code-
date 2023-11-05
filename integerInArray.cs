// Write a C# Sharp program to check if a specified number is present in a given array of integers.

using System;

namespace MyCoding 
{
class integerInArray
{
	static void Main(string[] args)
    {	
      Console.WriteLine("Input number of elements "); 
      int b = Convert.ToInt32(Console.ReadLine());
	  int[] a = new int[b];
      for(int i=0 ; i < b ; i++)
	  {
        a[i] = Convert.ToInt32(Console.ReadLine());  	 
      }		  
      int[] myArr = a;
	  bool exist = checkIntegerInArray(myArr,6);
	  Console.WriteLine("Input key status in Array is  "+exist); 
	  //Console.ReadKey();	  
    }
	
	public static bool checkIntegerInArray(int[] x,int k )
	{
		for(int j = 0; j < x.Length ;j++)
		{
			if (x[j] == k) return true ;
			
		}	
		return false;
	}
}
}