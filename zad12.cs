using System;
using System.Text;

class App
{

static int IsSorted(int[] t)
{
	int[] tab = new int[t.Length];
	int wynik=-1, wynik1=0, wynik2=0, wynik3=0, wynik4=0;
	int n;
	for( n=0;n<t.Length;n++){
		tab[n]=t[n];
	}
	Array.Sort(tab); // posortowane rosnaco
	for(int i=0;i<t.Length;i++)
	{
		if(tab[i]==t[i]) wynik1+=1;
		if(tab[i]==t[t.Length-i-1]) wynik2+=1;
		if(tab[i]==t[t.Length-1]) wynik3+=1;
		else wynik4+=1;
	}
	if(wynik3==t.Length) return 3;
	if(wynik1==t.Length) return 1;	
	else if(wynik2==t.Length) return 2;
	else if(tab!=t) return 0;
	else return wynik;
}
// ********************************************************	
	static void Main()
	{
		int[] t1 = {1,3,2,4,4,5,6,6,7,8};
		int[] t2 = {8,7,6,5,5,5,4,4,3,2};
		int[] t3 = {1,2,3,4,4,5,6,7,7,8};
		int[] t4 = {1,1,1,1};
		Console.WriteLine("t1: " + IsSorted(t1));
		Console.WriteLine("t2: " + IsSorted(t2));
		Console.WriteLine("t3: " + IsSorted(t3));
		Console.WriteLine("t4: " + IsSorted(t4));
	}
}