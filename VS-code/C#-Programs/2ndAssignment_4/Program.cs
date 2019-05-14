using System;

namespace _2ndAssignment_4
{
    
    class Program
    {
        public static void print2largest(int []arr, 
									int arr_size) 
	{ 
		int i, first, second; 
	
		//There should be atleast two elements 
		if (arr_size < 2) 
		{ 
		Console.WriteLine(" Invalid Input "); 
			return; 
		} 
	
		first = second = int.MinValue; 
		for (i = 0; i < arr_size ; i++) 
		{ 
			// If current element is smaller than 
			// first then update both first and second 
			if (arr[i] > first) 
			{ 
				second = first; 
				first = arr[i]; 
			} 
	
			// If arr[i] is in between first 
			// and second then update second 
			else if (arr[i] > second && arr[i] != first) 
				second = arr[i]; 
		} 
		
		if (second == int.MinValue) 
			Console.Write("There is no second largest\n"+ 
								" element\n"); 
		else
			Console.Write("The second largest element"+ 
										" is "+ second+"\n"); 
	} 

        static void Main(string[] args)
        {
	        int []arr = {12, 35, 1, 10, 34, 1}; 
			int n = arr.Length; 
			print2largest(arr, n);         
        }
    }
}