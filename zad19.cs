using System;
using System.Text;

class App
{
	
	static string LiczbaSlownie(uint x){
		string s1 = x.ToString();
		char[] chars = s1.ToCharArray();
		Array.Reverse(chars);
		string s= new string(chars);
		StringBuilder liczba= new StringBuilder();
		int dlugosc = s.Length;
		while(dlugosc>0){
			switch(dlugosc){
				case 10:
					if(s[9]=='1') liczba.Append("jeden ");
					else if(s[9]=='2') liczba.Append("dwa ");
					else if(s[9]=='3') liczba.Append("trzy ");
					else if(s[9]=='4') liczba.Append("cztery ");
					dlugosc=dlugosc-1;
					if(s[9]=='1') liczba.Append("miliard ");
					else if(s[9]=='1'||s[9]=='1'||s[9]=='1') liczba.Append("miliardy ");
					break;
				case 9:
					if(s[8]=='1') liczba.Append("sto ");
					else if(s[8]=='2') liczba.Append("dwieście ");
					else if(s[8]=='3') liczba.Append("trzysta ");
					else if(s[8]=='4') liczba.Append("czterysta ");
					else if(s[8]=='5') liczba.Append("pięćset ");
					else if(s[8]=='6') liczba.Append("sześćset ");
					else if(s[8]=='7') liczba.Append("siedemset ");
					else if(s[8]=='8') liczba.Append("osiemset ");
					else if(s[8]=='9') liczba.Append("dziewięćset ");
					dlugosc=dlugosc-1;
					if(s[8]!='0' && s[7]=='0' && s[6]=='0') liczba.Append("milionów ");
					break;
				case 8:
					if(s[7]=='1')
						switch(s[6]){
							case '0': liczba.Append("dziesięć "); break;
							case '1': liczba.Append("jedenaście "); break;
							case '2': liczba.Append("dwanaście "); break;
							case '3': liczba.Append("trzynaście "); break;
							case '4': liczba.Append("czternaście "); break;
							case '5': liczba.Append("piętnaście "); break;
							case '6': liczba.Append("szesnaście "); break;
							case '7': liczba.Append("siedemnaście "); break;
							case '8': liczba.Append("osiemnaście "); break;
							case '9': liczba.Append("dziewiętnaście "); break;
							default: break;
						}
					switch(s[7]){
						case '2': liczba.Append("dwadzieścia "); break;
						case '3': liczba.Append("trzydzieści "); break;
						case '4': liczba.Append("czterdzieści "); break;
						case '5': liczba.Append("pięćdziesiąt "); break;
						case '6': liczba.Append("sześćdziesiąt "); break;
						case '7': liczba.Append("siedemdziesiąc "); break;
						case '8': liczba.Append("osiemdziesiąt "); break;
						case '9': liczba.Append("dziewięćdziesiąt "); break;
					}
					if(s[7]=='2'||s[7]=='3'||s[7]=='4'||s[7]=='5'||s[7]=='6'||s[7]=='7'||s[7]=='8'||s[7]=='9')
						switch(s[6]){
							case '1': liczba.Append("jeden "); break;
							case '2': liczba.Append("dwa "); break;
							case '3': liczba.Append("trzy "); break;
							case '4': liczba.Append("cztery "); break;
							case '5': liczba.Append("pięć "); break;
							case '6': liczba.Append("sześć "); break;
							case '7': liczba.Append("siedem "); break;
							case '8': liczba.Append("osiem "); break;
							case '9': liczba.Append("dziewięć "); break;
							default: break;
						}
					if(s[6]=='2'||s[6]=='3'||s[6]=='4') liczba.Append("miliony ");
					else liczba.Append("milionów ");
					dlugosc=dlugosc-2;
					break;
				case 7:
					if(s[6]=='1') liczba.Append("jeden ");
					else if(s[6]=='2') liczba.Append("dwa ");
					else if(s[6]=='3') liczba.Append("trzy ");
					else if(s[6]=='4') liczba.Append("cztery ");
					else if(s[6]=='5') liczba.Append("pięć ");
					else if(s[6]=='6') liczba.Append("sześć ");
					else if(s[6]=='7') liczba.Append("siedem ");
					else if(s[6]=='8') liczba.Append("osiem ");
					else if(s[6]=='9') liczba.Append("dziewięć ");
					dlugosc=dlugosc-1;
					if(s[6]=='1') liczba.Append("milion ");
					else if(s[6]=='2'||s[6]=='3'||s[6]=='4') liczba.Append("miliony ");
					else if(s[6]!='0') liczba.Append("milionów ");
					break;
				case 6:
					if(s[5]=='1') liczba.Append("sto ");
					else if(s[5]=='2') liczba.Append("dwieście ");
					else if(s[5]=='3') liczba.Append("trzysta ");
					else if(s[5]=='4') liczba.Append("czterysta ");
					else if(s[5]=='5') liczba.Append("pięćset ");
					else if(s[5]=='6') liczba.Append("sześćset ");
					else if(s[5]=='7') liczba.Append("siedemset ");
					else if(s[5]=='8') liczba.Append("osiemset ");
					else if(s[5]=='9') liczba.Append("dziewięćset ");
					dlugosc=dlugosc-1;
					if(s[5]!='0' && s[4]=='0' && s[3]=='0') liczba.Append("tysięcy");
					break;
				case 5:
					if(s[4]=='1')
						switch(s[3]){
							case '0': liczba.Append("dziesięć "); break;
							case '1': liczba.Append("jedenaście "); break;
							case '2': liczba.Append("dwanaście "); break;
							case '3': liczba.Append("trzynaście "); break;
							case '4': liczba.Append("czternaście "); break;
							case '5': liczba.Append("piętnaście "); break;
							case '6': liczba.Append("szesnaście "); break;
							case '7': liczba.Append("siedemnaście "); break;
							case '8': liczba.Append("osiemnaście "); break;
							case '9': liczba.Append("dziewiętnaście "); break;
							default: break;
						}
					switch(s[4]){
						case '2': liczba.Append("dwadzieścia "); break;
						case '3': liczba.Append("trzydzieści "); break;
						case '4': liczba.Append("czterdzieści "); break;
						case '5': liczba.Append("pięćdziesiąt "); break;
						case '6': liczba.Append("sześćdziesiąt "); break;
						case '7': liczba.Append("siedemdziesiąc "); break;
						case '8': liczba.Append("osiemdziesiąt "); break;
						case '9': liczba.Append("dziewięćdziesiąt "); break;
					}
					if(s[4]=='2'||s[4]=='3'||s[4]=='4'||s[4]=='5'||s[4]=='6'||s[4]=='7'||s[4]=='8'||s[4]=='9')
						switch(s[3]){
							case '1': liczba.Append("jeden "); break;
							case '2': liczba.Append("dwa "); break;
							case '3': liczba.Append("trzy "); break;
							case '4': liczba.Append("cztery "); break;
							case '5': liczba.Append("pięć "); break;
							case '6': liczba.Append("sześć "); break;
							case '7': liczba.Append("siedem "); break;
							case '8': liczba.Append("osiem "); break;
							case '9': liczba.Append("dziewięć "); break;
							default: break;
						}
					dlugosc=dlugosc-2;
					if(s[4]=='1') liczba.Append("tysięcy ");
					else if(s[3]=='2'||s[3]=='3'||s[3]=='4') liczba.Append("tysiące ");
					else if(s[4]!='0') liczba.Append("tysięcy ");
					break;
				case 4:
					if(s[3]=='1') liczba.Append("jeden ");
					else if(s[3]=='2') liczba.Append("dwa ");
					else if(s[3]=='3') liczba.Append("trzy ");
					else if(s[3]=='4') liczba.Append("cztery ");
					else if(s[3]=='5') liczba.Append("pięć ");
					else if(s[3]=='6') liczba.Append("sześć ");
					else if(s[3]=='7') liczba.Append("siedem ");
					else if(s[3]=='8') liczba.Append("osiem ");
					else if(s[3]=='9') liczba.Append("dziewięć ");
					dlugosc=dlugosc-1;
					if(s[3]=='1') liczba.Append("tysiąc ");
					else if (s[3]=='2'||s[3]=='3'||s[3]=='4') liczba.Append("tysiące ");
					else if (s[3]!='0') liczba.Append("tysięcy ");
					break;
				case 3:
					if(s[2]=='1') liczba.Append("sto ");
					else if(s[2]=='2') liczba.Append("dwieście ");
					else if(s[2]=='3') liczba.Append("trzysta ");
					else if(s[2]=='4') liczba.Append("czterysta ");
					else if(s[2]=='5') liczba.Append("pięćset ");
					else if(s[2]=='6') liczba.Append("sześćset ");
					else if(s[2]=='7') liczba.Append("siedemset ");
					else if(s[2]=='8') liczba.Append("osiemset ");
					else if(s[2]=='9') liczba.Append("dziewięćset ");
					dlugosc=dlugosc-1;
					break;
				case 2:
					if(s[1]=='1')
						switch(s[0]){
							case '0': liczba.Append("dziesięć "); break;
							case '1': liczba.Append("jedenaście "); break;
							case '2': liczba.Append("dwanaście "); break;
							case '3': liczba.Append("trzynaście "); break;
							case '4': liczba.Append("czternaście "); break;
							case '5': liczba.Append("piętnaście "); break;
							case '6': liczba.Append("szesnaście "); break;
							case '7': liczba.Append("siedemnaście "); break;
							case '8': liczba.Append("osiemnaście "); break;
							case '9': liczba.Append("dziewiętnaście "); break;
							default: break;
						}
					switch(s[1]){
						case '2': liczba.Append("dwadzieścia "); break;
						case '3': liczba.Append("trzydzieści "); break;
						case '4': liczba.Append("czterdzieści "); break;
						case '5': liczba.Append("pięćdziesiąt "); break;
						case '6': liczba.Append("sześćdziesiąt "); break;
						case '7': liczba.Append("siedemdziesiąc "); break;
						case '8': liczba.Append("osiemdziesiąt "); break;
						case '9': liczba.Append("dziewięćdziesiąt "); break;
					}
					if(s[1]=='2'||s[1]=='3'||s[1]=='4'||s[1]=='5'||s[1]=='6'||s[1]=='7'||s[1]=='8'||s[10]=='9')
						switch(s[0]){
							case '1': liczba.Append("jeden "); break;
							case '2': liczba.Append("dwa "); break;
							case '3': liczba.Append("trzy "); break;
							case '4': liczba.Append("cztery "); break;
							case '5': liczba.Append("pięć "); break;
							case '6': liczba.Append("sześć "); break;
							case '7': liczba.Append("siedem "); break;
							case '8': liczba.Append("osiem "); break;
							case '9': liczba.Append("dziewięć "); break;
							default: break;
						}
					dlugosc=dlugosc-2;
					break;
				case 1:
				if(s[0]=='1') liczba.Append("jeden");
				else if(s[0]=='2') liczba.Append("dwa");
				else if(s[0]=='3') liczba.Append("trzy");
				else if(s[0]=='4') liczba.Append("cztery");
				else if(s[0]=='5') liczba.Append("pięć");
				else if(s[0]=='6') liczba.Append("sześć");
				else if(s[0]=='7') liczba.Append("siedem");
				else if(s[0]=='8') liczba.Append("osiem");
				else if(s[0]=='9') liczba.Append("dziewięć");
				else if(s[0]=='0') liczba.Append("zero");
				dlugosc=dlugosc-1;
				break;
				default: dlugosc=dlugosc-1; break;
			}
		}
		string liczbaString = liczba.ToString();
		return liczbaString;
	}

	static void Main()
	{
		uint x=1555555555;
		uint y=3777;
		uint z=2345234;
		Console.WriteLine("Liczba: {0}", x);
		Console.WriteLine("Słowanie: {0}\n", LiczbaSlownie(x));
		Console.WriteLine("Liczba: {0}", y);
		Console.WriteLine("Słowanie: {0}\n", LiczbaSlownie(y));
		Console.WriteLine("Liczba: {0}", z);
		Console.WriteLine("Słowanie: {0}\n", LiczbaSlownie(z));
	}

}