using System;

public class Substring_broken
{
	public static void Main()
	{
		string text = Console.ReadLine();
		int jump = int.Parse(Console.ReadLine());

		const char Search = 'p';
		bool hasMatch = false;

		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] == Search)
			{
				hasMatch = true;

                if(jump + i + 1 <= text.Length)
                {
                    Console.WriteLine(text.Substring(i, jump + 1));
                }
                else
                {
                    Console.WriteLine(text.Substring(i));
                }
				i += jump;
			}
		}

		if (!hasMatch)
		{
			Console.WriteLine("no");
		}
	}
}
