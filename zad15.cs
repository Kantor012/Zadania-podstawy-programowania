using System;
using System.Text;
using System.Linq;
class App
{
struct Punkt
{
	public double x;
	public double y;
}

static double ObwodWielokata(Punkt[] t){
	double suma=0;
	double temp;
	double[] odleglosci = new double[t.Length];
	System.Collections.Generic.List<double> odl = new System.Collections.Generic.List<double>();
	for(int i=0;i<t.Length;i++)
		for(int j=i;j<t.Length;j++){
			if(j<t.Length-1)
				odl.Add(Math.Sqrt(Math.Pow(t[j].x-t[j+1].x,2)+Math.Pow(t[j].y-t[j+1].y,2)));
			else
				odl.Add(Math.Sqrt(Math.Pow(t[j].x-t[0].x,2)+Math.Pow(t[j].y-t[0].y,2)));
			if(j==t.Length-1){
				temp = Double.MaxValue;
				foreach(double a in odl)
					if(a<=temp)
						temp = a;
				odleglosci[i] = temp;
			}

		}
	for(int i=0; i<odleglosci.Length;i++)
		suma+=odleglosci[i];
	return suma;
}
// ********************************************************	
	static void Main()
	{
		Punkt[] t = new Punkt[4];
		t[0].x=0; t[0].y=2;
		t[1].x=2; t[1].y=0;
		t[2].x=0; t[2].y=0;
		t[3].x=2; t[3].y=2;
		//t[4].x=5; t[4].y=5;
		//t[4].x=4; t[4].y=16;
		//t[5].x=5; t[5].y=25;
		//t[6].x=6; t[6].y=36;
		Console.WriteLine("Obwód wielokąta wynosi: {0}", ObwodWielokata(t));
	}

}