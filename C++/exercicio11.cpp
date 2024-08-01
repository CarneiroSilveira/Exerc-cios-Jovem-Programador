#include <iostream>
using namespace std;

string sinal;

int main(){
	system("chcp 65001");
	system("color A");
	
	cout<<"\nDigite a operação a ser realizada(*,/,-,+) ";
	cin>>sinal;
		
	if(sinal == "/"){
		
		float num1, num2;
		
		cout<<"\nDigite o primeiro numero";
		cin>>num1;
		
		cout<<"\nDigite o segundo numero";
		cin>>num2;
		
		cout<<"O resultado da divisão é igual a "<<num1/num2<<"!";
	}
	
	else if(sinal == "+"){
		
		float num1, num2;
		
		cout<<"\nDigite o primeiro numero";
		cin>>num1;
		
		cout<<"\nDigite o segundo numero";
		cin>>num2;
		
		cout<<"O resultado da soma é "<<num1+num2<<"!";
	}
	
	else if(sinal == "-"){
		
		float num1, num2;
		
		cout<<"\nDigite o primeiro numero";
		cin>>num1;
		
		cout<<"\nDigite o segundo numero";
		cin>>num2;
		
		cout<<"O resultado da subtração é "<<num1-num2<<"!";
	}
	
	else if(sinal == "+"){
		
		float num1, num2;
		
		cout<<"\nDigite o primeiro numero";
		cin>>num1;
		
		cout<<"\nDigite o segundo numero";
		cin>>num2;
		
		cout<<"O resultado da soma é "<<num1+num2<<"!";
	}
	
	else if(sinal == "*"){
		
		float num1, num2;
		
		cout<<"\nDigite o primeiro numero";
		cin>>num1;
		
		cout<<"\nDigite o segundo numero";
		cin>>num2;
		
		cout<<"O resultado da multiplicação é "<<num1*num2<<"!";
	}
}