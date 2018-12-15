using System;

namespace problem3{
class  problem3{
	static void Main(string[] args)
	{
		long bigNumber = 600851475143; 
		long ii = 3;
		for(;ii<bigNumber;ii+=2){
			if(bigNumber%ii==0){
				bigNumber /= ii;
			}
		}
		Console.WriteLine(ii);
	}
}
}
