using System;
class problem7{
	static bool isPrime(int a){
		for(int ii=2;ii<a/2;ii+=2){
			if(a%ii==0){
				return false;
			}
		}//for
		return true;
	}//isPrime
	static void Main(){
		
	}//Main
}
