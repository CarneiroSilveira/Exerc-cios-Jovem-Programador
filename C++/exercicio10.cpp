#include <iostream>
using namespace std;

char sex;
float num, imc;

int main(){
	system("chcp 65001");
	system("color A");
	
	cout<<"\nQual o sexo do usuário? (h ou m) ";
	cin>>sex;
	
	cout<<"\nAgora diga qual é a altura deste usuário! ";
	cin>>num;
	
	if(sex == 'h'){
		imc = (72.7*num)-58;
		cout<<"\nO índice de massa corporal do usuário é igual a "<<imc;
	}
	
	else if(sex == 'm'){
		imc = (62.1*num)-44.7;
		cout<<"\nO índice de massa corporal do usuário é igual a "<<imc;
	}
	
}