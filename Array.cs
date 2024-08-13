using System;
class Array
{
	public static void Main()
	{
		ArrayList arraylist = new ArrayList();
		Console.Write("Enter the elements you want add");
		int numberOfElements=int.Parse(Console.ReadLine());

		for(int i=0;i<numberOfElements;i++)
		{
		Console.Write("Enter element {i+1}:");
		string input=Console.ReadLine();
		ArrayList.Add(input);
		}

		Console.WriteLine("elements in ArryList");
		foreach(var item in ArrayList)
		{
			Console.WriteLine(item);
		}
	}
}

		
	
