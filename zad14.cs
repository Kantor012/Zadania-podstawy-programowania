using System;
using System.Text;

class App
{
	
	static void PokazPary(int[] t)
{
	int n = t.Length;
	Array.Sort(t, 0, n); // na wypadek nieposortowanej tablicy
	for (int i=0; i<t.Length; i++)
		for (int j=i+1; j<t.Length; j++) {
			Console.Write("{0}, {1}\n", t[i], t[j]);
		}
}
	
	static void Main()
	{
	int[] t = {4,1,2,7,12,32,22,13,54,31};
	PokazPary(t);
	}

}