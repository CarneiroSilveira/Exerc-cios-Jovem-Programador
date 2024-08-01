#include <iostream>
using namespace std;

float num;

int main(){
	system("chcp 65001");
	system("color A");
	
	cout<<"\nDigite um numero";
	cin>>num;
	
	if(num < 0){
		cout<<"\nEsse numero é negativo";
	}
	else if(num >= 0){
		cout<<"\nEsse numero é positivo";
	}
	
}