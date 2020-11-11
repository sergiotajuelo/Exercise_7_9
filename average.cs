public class Average 
{ 
 
	public static void Main() 
	{ 
 
		double sum = 0, number_user, numberCounter = 0, average; 
		string final; 
 
		Console.Write("Insert a mark: "); 
		final = Console.ReadLine(); 	 
 
		// if the mark isn't an end then we pass it to double to work with it 
		while (final != "end") 
		{ 
			number_user = Convert.ToDouble(final); 
			numberCounter++; 
 
			sum += number_user; 
 
			Console.Write("Insert a mark: "); 
			final = Console.ReadLine(); 
		} 
 
		if (numberCounter != 0) 
		{ 
			average = sum / numberCounter; 
			Console.WriteLine("The average is {0}.", average); 
		} 
	} 
} 
