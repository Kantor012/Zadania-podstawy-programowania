using System;
using System.Text;

class App
{
	
	struct Punkt
	{
		public double x;
		public double y;
	}

	static double SumaOdleglosci(Punkt[] t)
	{
		double suma=0;
		for(int i=0; i<t.Length; i++){
			suma+=Math.Sqrt(t[i].x * t[i].x + t[i].y * t[i].y);
		}
		return suma;
	}
	
	static void Main()
	{
		Punkt[] t = new Punkt[3];
		t[0].x=0; t[0].y=12;
		t[1].x=3; t[1].y=4;
		t[2].x=16; t[2].y=2;
		Console.WriteLine("Suma wynosi: {0}", SumaOdleglosci(t));
	}

}