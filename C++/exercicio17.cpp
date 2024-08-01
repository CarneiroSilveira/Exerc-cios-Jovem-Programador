#include <iostream>
using namespace std;

float aluno[3];
float mediaPonderada;

int main(){
	system("chcp 65001");
	system("color A");
	
	cout<<"\nDigite a nota do aluno! ";
	cin>>aluno[0];
	aluno[0] = aluno[0] * 2;
	cout<<"\nDigite a nota do aluno! ";
	cin>>aluno[1];
	aluno[1] = aluno[1] * 3;
	
	cout<<"\nDigite a nota do aluno! ";
	cin>>aluno[2];
	aluno[2] = aluno[2] * 5;
	
	
	mediaPonderada = (aluno[0] + aluno[1] + aluno[2]) / 10;
	
	cout<<"\nA nota deste aluno é: "<<mediaPonderada;
	
	
}