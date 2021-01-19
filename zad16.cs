using System;
using System.Text;

class App
{


static int[] ZnajdzDlugosci(string[] t)
{
	string tekst;
	int liczZnakow;
	int[] dlugosci = new int[t.Length];
	for(int i=0; i<t.Length;i++){
		liczZnakow=0;
		tekst=t[i];
		while( !( String.IsNullOrEmpty(tekst) ) ){
				liczZnakow+=1;
				tekst=tekst.Remove((tekst.Length)-1);
		}
		dlugosci[i]=liczZnakow;
	}
	return dlugosci;
}
// ********************************************************	
	static void Main()
	{
		string[] ts = {"Ala", "ma", "kota"};
		int[] td = ZnajdzDlugosci(ts);
		for(int i=0; i<td.Length; i++) Console.Write("{0} ", td[i]);
	}
}