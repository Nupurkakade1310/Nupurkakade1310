class Add
{
    	int x, y;
    	double f;
    	string s;

	public Add(int a, double b)
    	{
		x = a;
        	f = b;
    	}

	public Add(int a, string b)
    	{
        	y = a;
        	s = b;
    	}

	public void show()
    	{
        	System.Console.WriteLine("1st constructor (int + float): {0}", (x + f));
    	}

    	public void show1()
    	{
        	System.Console.WriteLine("2nd constructor (int + string): {0}", (s + y));
    	}
	public void Fun()
	{
		System.Console.WriteLine("Enter an integer:");
	        int inputInt =  System.Convert.ToInt32( System.Console.ReadLine());
	
	        System.Console.WriteLine("Enter a floating-point number:");
        	double inputDouble =  System.Convert.ToDouble( System.Console.ReadLine());

	        //Add g = new Add(inputInt, inputDouble);
        	//g.show();
	
        	System.Console.WriteLine("\nEnter another integer:");
        	int anotherInt =  System.Convert.ToInt32( System.Console.ReadLine());

	        System.Console.WriteLine("Enter a string:");
        	string inputString =  System.Console.ReadLine();

	        Add q = new Add(anotherInt, inputString);
        	q.show1();

	        System.Console.ReadLine();
	}
}

class Prac2b3 
{
    	public static void Main()
    	{
		Add obj=new Add();
		obj.Fun();
    	}
}
