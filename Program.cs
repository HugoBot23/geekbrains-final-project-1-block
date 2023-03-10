string[] FilterByMaxLength(string[] strs, int maxLength)
{
	string[] res = { };

	for (int i = 0; i < strs.Length; i++)
	{
		if (strs[i].Length <= maxLength)
		{
			var temp = new string[res.Length + 1];
			res.CopyTo(temp, 0);
			res = temp;
			res[res.Length - 1] = strs[i];
		}
	}

	return res;
}

void PrintStrings(string[] strs)
{
	Console.Write("[");
	for (int i = 0; i < strs.Length; i++)
	{
		Console.Write($"\"{strs[i]}\"");
		if (i < strs.Length - 1)
		{
			Console.Write(", ");
		}
	}

	Console.WriteLine("]");
}

string[] strs = { "hello", "2", "world", ":-)" };

string[] res = FilterByMaxLength(strs, 3);
PrintStrings(res);
