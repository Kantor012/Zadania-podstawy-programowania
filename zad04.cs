using System;
using System.Text;

class App
{
	
	static void Reverse(int[] t)
{
	int poczatek = 0;
	int koniec = t.Length - 1;
	do {
		int temp = t[poczatek];
		t[poczatek] = t[koniec];
		t[koniec] = temp;
	} while(++poczatek < --koniec);
}
	
	static void Main()
	{
		int[] t = {4,5,3,1,6,2};
		int k=t.Length;
		for(int i=0; i<k; i++) Console.Write("{0}, ",t[i]);
		Console.Write("\n");
		Reverse(t);
		for(int i=0; i<k; i++) Console.Write("{0}, ",t[i]);
		
	}

}