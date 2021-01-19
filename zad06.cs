using System;
using System.Text;

class App
{
	
static string WyczyscTekst(string s1, string s2)
{
	StringBuilder sb1 = new StringBuilder(s1);
	for(int i=0; i<s2.Length;i++){
		int k=0;
		while(k<sb1.Length)
		{
			if(sb1[k]==s2[i]){
				sb1.Remove(k, 1);
			}
			else
			k++;
		}
	}
	return sb1.ToString();
}
	
	static void Main()
	{
		string s2 = "l a";
		string s1 = "ola to ala, a ala to ola";
		Console.WriteLine(WyczyscTekst(s1, s2));
	}

}