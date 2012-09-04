using System;
using System.Text.RegularExpressions;

public class SpreadSheets {

	public static void Main(string[] args) {
		int n = Int32.Parse(Console.ReadLine());
		Regex r = new Regex("R[0-9]+C[0-9]+");

		for(int i = 0; i < n; i ++) {
			string s = Console.ReadLine();

			if(r.IsMatch(s)) {
				string result = "";
				Regex r1 = new Regex("[R|C]");
				string[] ss = r1.Replace(s ," ").Trim().Split(new char[] {' '});
				int c = Int32.Parse(ss[1]);
				//NOTE
				while(c > 0) {
					c--;
					result = (char) (c % 26 + 'A') + result;
					c /=26;
				}
				result += ss[0];
				Console.WriteLine(result);
			}
			else {
				Regex r1 = new Regex("[0-9]");
				string c = r1.Replace(s, "");
				r1 = new Regex("[A-Z]");
				string row = r1.Replace(s, "");

				int num = 0;
				for (int j = 0; j < c.Length; j++) {
					num = num * 26 + (c[j] - 'A' + 1);
				}

				Console.WriteLine("R" + row +  "C" + num);
			}
		}
	}
}
