using System;
using System.Text;

class App
{
public static bool Contain(string s1, string s2)
{
	var maxIndex = s1.Length - s2.Length;
	if (maxIndex < 0) return false;
	for (int i = 0; i <= maxIndex; i++)
	{
		int j;
		for (j = 0; j < s2.Length; j++)
			if (s1[i + j] != s2[j]) break;
		if (j == s2.Length) return true;
	}
return false;
}

public static int mojIndex(StringBuilder sb, string str, int startIndex)
{            
int index;
int strDlugosc = str.Length;
int maxFindLen = (sb.Length - strDlugosc) + 1;
bool ignoreCase = true;
if (ignoreCase)
{
	for (int i = startIndex; i < maxFindLen; ++i)
	{
		if (Char.ToLower(sb[i]) == Char.ToLower(str[0]))
		{
			index = 1;
			while ((index < strDlugosc) && (Char.ToLower(sb[i + index]) == Char.ToLower(str[index])))
				++index;
			if (index == strDlugosc)
				return i;
		}
	}
	return -1;
}
for (int i = startIndex; i < maxFindLen; ++i)
{
	if (sb[i] == str[0])
	{
		index = 1;
		while ((index < strDlugosc) && (sb[i + index] == str[index]))
			++index;

		if (index == strDlugosc)
			return i;
	}
}
return -1;
}

static bool isStrLike(string s, string s1)
{
}
	
	static void Main()
	{
		string s = "Ala ma kota";
		string s1 = "*ma*";

		Console.WriteLine("Przed zamiana: {0}", isStrLike(s, s1));

	}

}