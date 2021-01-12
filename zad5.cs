using System;
using System.Text;

class App
{
	
	static string Sklej(string[] t, char c)
{
	StringBuilder t1 = new StringBuilder();
	for (int i=0; i<t.Length; i++){
		if(i<t.Length-1)
			t1.Append(t[i]).Append(c);
		else
			t1.Append(t[i]);
	}
	return t1.ToString();
}
	
	static void Main()
	{
		char c='+';
		string[] t = {"ola","ania","weronika","anna","justyna","joanna"};
		Console.WriteLine(Sklej(t, c));
	}

}