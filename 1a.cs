using System;

class Square
{
	public static void Main(string[] args) {
		
		string  input = Console.ReadLine();
		string[] arr = input.Split(new char[] {' '});

		int m = Int32.Parse(arr[0]);
		int n = Int32.Parse(arr[1]);
		int a = Int32.Parse(arr[2]);

		for(int i = 0; i < Int32.MaxValue; i++) {
			int s = i * a * a;

			if(s > m * n && 
				(i == 1 || i % 2 == 0) && 
				(i * a >= m && i * a >= n))

				Console.Write(i);
				return;
			}
		}

		return;
	}
}
