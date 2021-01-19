using System;
using System.Text;

class App
{
	
static bool SprawdzTekst(string s1, string s2)
{
	int m = s2.Length;
	int n = s1.Length;
	for (int i = 0; i<=n-m; i++) {
		int j;
		for (j = 0; j < m; j++)
			if(s1[i+j] != s2[j])
				break;
		if (j == m)
			return true;
		
	}
	return false;
}
	
	static void Main()
	{
		string s1="Kot pije mleko";
		string s2="mlko";
		Console.WriteLine("Czy tekst: {0} zawiera się w tekście {1} ?\n {2}", s2, s1, SprawdzTekst(s1, s2));
	}

}