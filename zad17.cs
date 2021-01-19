using System;
using System.Text;
using System.Collections.Generic;

class App
{
	
public static bool Contain(string stringToSearch, string stringToFind)
{
  var maxIndex = stringToSearch.Length - stringToFind.Length;
  // String, which we want to find is bigger than string, which we want to search
  if (maxIndex < 0) return false;

  for (int i = 0; i <= maxIndex; i++)
  {
    int j;
    for (j = 0; j < stringToFind.Length; j++)
      // If we have different letters, stop comparing and go to next iteration of outer loop
      if (stringToSearch[i + j] != stringToFind[j]) break;
    // If we reached last iteration of a loop then we found the string
    if (j == stringToFind.Length) return true;
  }

  // If we reached this point, we didn't find the string
  return false;
}

static List<int> ZnajdzLinie(string fname, string s)
{
	string line;
	string[] lines1 = System.IO.File.ReadAllLines(fname);
	List<int> numLines = new List<int>();
	for(int i=0;i<lines1.Length;i++)
	{
		line=lines1[i];
		if(Contain(line, s))
			numLines.Add(i+1);
	}
	
	
	return numLines;
}

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
		string fname = "test1.txt";
		string s = "ma";
		List<int> plik = ZnajdzLinie(fname, s);
		for(int i=0;i<plik.Count;i++) Console.Write("{0} ", plik[i]);
	}
}