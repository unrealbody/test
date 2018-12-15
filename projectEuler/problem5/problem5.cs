using System;

class problem5{
	static bool isBiggest(int ii){
		for(int jj=ii+1;jj<=20;jj++){
			if(jj%ii == 0){
				return false;
			}//if
		}//for
		return true;
	}//isBiggest
	static void Main(){
		int total=1;
		for(int ii=2;ii<=20;ii++){
			if(isBiggest(ii)){
				Console.WriteLine(ii);
				total*=ii;
			}//if
		}//for
		Console.WriteLine(total);
	}//Main
}//class
