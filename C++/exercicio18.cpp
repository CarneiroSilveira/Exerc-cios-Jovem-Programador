#include <iostream>
using namespace std;

float fabricacao;
float impostos = 0.45;
float distribuidor = 0.28;
float valorFinal;


int main(){
	system("chcp 65001");
	system("color A");
	
	cout<<"qual é o valor de fabricação do veiculo? ";
	cin>>fabricacao;
	
	valorFinal = fabricacao + (impostos * fabricacao) + (distribuidor * fabricacao);
	
	cout<<"O valor do veiculo pro consumidor final sera "<<valorFinal;
}