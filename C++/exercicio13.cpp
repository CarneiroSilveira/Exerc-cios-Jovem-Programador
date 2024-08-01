#include <iostream>
using namespace std;

int num;

int main(){
	system("chcp 65001");
	system("color A");
	
	cout<<"\nDigite um numero";
	cin>>num;
	
	if(num % 2 == 0){
		cout<<"\nEsté numero é par";
	}
	
	
	else{
		cout<<"\nEsté numero é impar";
	}
}