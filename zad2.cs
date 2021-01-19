using System;
using System.Text;

class App
{
public static bool Contain(string stringToSearch, string stringToFind)
{
	var maxIndex = stringToSearch.Length - stringToFind.Length;
	// String, which we want to find is bigger than string, which we want to search
	if (maxIndex < 0) return false;
	for (int i = 0; i <= maxIndex; i++)
	{
		int j;
		for (j = 0; j < stringToFind.Length; j++)
			// If we have different letters, stop comparing and go to next iteration of outer loop
			if (stringToSearch[i + j] != stringToFind[j]) break;
			// If we reached last iteration of a loop then we found the string
		if (j == stringToFind.Length) return true;
	}		
// If we reached this point, we didn't find the string
return false;
}

public static int mojIndex(StringBuilder sb, string str, int startIndex)
{            
int index;
int length = str.Length;
int maxSearchLength = (sb.Length - length) + 1;
bool ignoreCase = true;
if (ignoreCase)
{
	for (int i = startIndex; i < maxSearchLength; ++i)
	{
		if (Char.ToLower(sb[i]) == Char.ToLower(str[0]))
		{
			index = 1;
			while ((index < length) && (Char.ToLower(sb[i + index]) == Char.ToLower(str[index])))
				++index;
			if (index == length)
				return i;
		}
	}
	return -1;
}
for (int i = startIndex; i < maxSearchLength; ++i)
{
	if (sb[i] == str[0])
	{
		index = 1;
		while ((index < length) && (sb[i + index] == str[index]))
			++index;

		if (index == length)
			return i;
	}
}
return -1;
}

static string StrReplace(string s, string s1, string s2)
{
	int pozycja=0;
	StringBuilder sb = new StringBuilder(s);
	if(Contain(s, s1))
	{
		pozycja = mojIndex(sb, s1, 0);
		sb.Remove(pozycja, s1.Length);
		sb.Insert(pozycja, s2);
	}
	string zamiana = sb.ToString();
	return zamiana;
}
	
	static void Main()
	{
		string s = "Ala ma kota";
		string s1 = "ma";
		string s2 = "nie ma";
		Console.WriteLine("Przed zamiana: {0}", s);
		Console.WriteLine("Po zamianie: {0}", StrReplace(s, s1, s2));
	}

}