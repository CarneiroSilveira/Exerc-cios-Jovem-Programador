#include <iostream>
using namespace std;

int num1, num2;

int main(){
	system("chcp 65001");
	system("color A");
	
	cout<<"\nDigite o primeiro numero ";
	cin>>num1;
	
	cout<<"\nDigite o segundo numero ";
	cin>>num2;
	
	if(num1 > num2){
		cout<<"O primeiro numero é maior que o segundo! ";
	}
	
	else if(num1 > num2){
		cout<<"O segundo é maior que o primeiro! ";
	}
	else{
		cout<<"Os numeros são iguais!";
	}
	
}