using System;
using System.Text;

class App
{
static void ZnajdzParzyste(string fname1, string fname2)
{
	string[] lines1 = System.IO.File.ReadAllLines(fname1);
	int[] intarray = new int[lines1.Length];
	int i;
	if(System.IO.File.Exists(fname2))
		System.IO.File.Delete(fname2);
	for (i=0;i<lines1.Length;i++){
		intarray[i]=Convert.ToInt32(lines1[i]);
		Console.WriteLine(intarray[i]);
		
		if(intarray[i] % 2 == 0)
			using (System.IO.StreamWriter w = System.IO.File.AppendText(fname2))
			{
				w.WriteLine(intarray[i]);
			}
		//File.AppendAllText(fname2, intarray[i]);
	}
}
// ********************************************************	
	static void Main()
	{
		ZnajdzParzyste("znajdz_parzyste_input.txt","znajdz_parzyste_output.txt");
	}

}