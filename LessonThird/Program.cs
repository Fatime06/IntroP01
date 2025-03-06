using System.Collections;

class Shopping 
{
	static void Main()
	{
		ArrayList product = new ArrayList();

		bool shopping = true;

		while (shopping)
		{
			Console.WriteLine("Insert an option!");
			Console.WriteLine("1. Add Item!");
			Console.WriteLine("2. Show List!");
			Console.WriteLine("3. Check Item!");
			Console.WriteLine("4. Exit");

			int input = Convert.ToInt32(Console.ReadLine());

			switch (input)
			{
				case 1:
					Console.WriteLine("Insert the Item: ");
					string item = Console.ReadLine();
					product.Add(item);
					Console.WriteLine($"{item} Added to the List");
					break;
				case 2:
					Console.WriteLine("Show the List");
					if (product.Count == 0) 
					Console.WriteLine("The List is Empty!");
					else
						foreach (var shopItem in product)
						{
							Console.WriteLine("- " + shopItem);
						}
							break;
				case 3:
					Console.WriteLine("Insert Item for Checking");
					string checkItem = Console.ReadLine();
					if (product.Contains(checkItem))
						Console.WriteLine($"'{checkItem}' is available.");
					else
						Console.WriteLine($"'{checkItem}' isn't available.");
					break;

				case 4:
					shopping = false;
					Console.WriteLine("Exciting");
					break;

				default:
					Console.WriteLine("Invalid option. Please try again.");
					break;
			}
		}
	}
}
