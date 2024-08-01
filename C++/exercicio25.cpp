#include <iostream>
using namespace std;

int quantidade;
float alturaTotal;
float resutado;

int main(){
	system("chcp 65001");
	system("color A");
	
	cout<<"\nDigite a quantidade de usuários: ";
	cin>>quantidade;
	
	for(int i = 1; i <= quantidade; i++){
		float usuarioAtual;
		cout<<"\nDigite a altura do usuário numero "<<i<<" ";
		cin>>usuarioAtual;
		alturaTotal += usuarioAtual;
	}
	resutado = alturaTotal / quantidade;
	cout<<"A media da altura dos usuários é "<<resutado;
}