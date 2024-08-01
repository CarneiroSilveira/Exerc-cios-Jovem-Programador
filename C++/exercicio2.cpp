#include <iostream>
using namespace std;

float valorDaHora;
float horas;

main(){
	system("chcp 65001");
	system("color A");
	
	cout<<"Qual o valor da hora do trabalhador? "<<endl;
	cin>>valorDaHora;
	cout<<"E quantas horas ele fez nesse mes? "<<endl;
	cin>>horas;
	cout<<"O valor a ser recebido no final do mês é! "<<valorDaHora*horas<<endl;
}