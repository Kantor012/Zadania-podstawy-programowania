using System;
using System.Text;

class App
{
struct Punkt
{
	public double x;
	public double y;
}
// ****************************************************
static long Newton(int n, int k)
{
	long  Wynik = 1;
	int i;
	for(i = 1; i <= k; i++){
		Wynik = Wynik * ( n - i + 1 ) / i;
	}
return Wynik;
}
// *****************************************************
static double SumaWzajOdleglosci(Punkt[] t){
	double suma=0;
	System.Collections.Generic.List<double> odl_x = new System.Collections.Generic.List<double>();
	System.Collections.Generic.List<double> odl_y = new System.Collections.Generic.List<double>();
	int i;
	for(i=0;i<t.Length;i++)
		for(int k=i; k<t.Length;k++){
			if(i!=k){
				odl_x.Add(Math.Abs(t[i].x-t[k].x));
				odl_y.Add(Math.Abs(t[i].y-t[k].y));
			}
		}
	double[] odl1_x = odl_x.ToArray();
	double[] odl1_y = odl_y.ToArray();
	for(int n=0; n<Newton(t.Length, 2);n++){
		suma+=Math.Sqrt(odl1_x[n]*odl1_x[n]+odl1_y[n]*odl1_y[n]);
	}
	Console.WriteLine();
	return suma;
}
// ********************************************************	
	static void Main()
	{
		Punkt[] t = new Punkt[3];
		t[0].x=0;	t[0].y=0;
		t[1].x=5;	t[1].y=0;
		t[2].x=10;	t[2].y=0;
		//if(k==0||n==k) Console.WriteLine("1");
		//Console.WriteLine(Newton(n,k));
		Console.WriteLine("Suma ogleglosci wszystkich punktow wynosi: {0}", SumaWzajOdleglosci(t));
	}

}