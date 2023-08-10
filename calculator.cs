using System; 
using System.Linq; 
using System.Collections.Generic;
using CSharpShellCore; 

public static class Program 
{ 
public static void Main() 
{
		float oneNum;
		float twoNum;
		float result;
		
		string oper;
		
		Console.Write("Write the first number(The fraction must be written with \",\"): ");
		oneNum = Convert.ToSingle(Console.ReadLine());
		
		Console.Write("Write an operator(+,-,*,/): ");
		oper = Console.ReadLine();
		
		Console.Write("Write the second number(The fraction must be written with \",\"): ");
		twoNum = Convert.ToSingle(Console.ReadLine());
		
		if (oper == "+")
		{
			result = oneNum + twoNum;
			Console.WriteLine(result);
		}
		
		else if (oper == "-")
		{
			result = oneNum - twoNum;
			Console.WriteLine(result);
		}
		
		else if (oper == "*")
		{
			result = oneNum * twoNum;
			Console.WriteLine(result);
		}
		
		else if (oper == "/")
		{
			result = oneNum / twoNum;
			Console.WriteLine(result);
		}
		else
		{
			Console.WriteLine("Sorry, but you entered the wrong operator");
		}
		 
} 
} 
