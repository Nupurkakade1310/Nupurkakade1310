using System;
using System.Collections;

class Array1
{
    public static void Main(string[] args)
    {
        ArrayList obj=new ArrayList();

        while(true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.List");
            Console.WriteLine("3.Count");
            Console.WriteLine("4.Reverse");
            Console.WriteLine("5.Sort");
            Console.WriteLine("6.Remove");
            Console.WriteLine("7.Remove by Index");
            Console.WriteLine("8.Find the index");
            Console.WriteLine("9.Exit");
            
            Console.WriteLine("Enter your choice");
            int choice;

            if(!int.TryParse(Console.ReadLine(),out choice))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter element to add:");
                    string Eadd = Console.ReadLine();
                    obj.Add(Eadd);
                    Console.WriteLine(Eadd+"added to list");
                    break;

                case 2:
                    Console.WriteLine("Array List");
                    foreach(var item in obj)
                    {
                        Console.WriteLine(item);
                    }
		    break;

		case 3:
		    Console.WriteLine("number of elements in list:"+obj.Count);
		    break;

		case 4:
		    Console.WriteLine("the list has been Reversed:");
		    obj.Reverse();
		    break;

		case 5:
		    Console.WriteLine("the list has been Sorted:");
		    obj.Sort();
		    break;

		

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}