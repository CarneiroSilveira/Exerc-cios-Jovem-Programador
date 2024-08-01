#include <iostream>
using namespace std;

int aluno1, aluno2, aluno3, media;

int main(){
	system("chcp 65001");
	system("color A");
	
	cout<<"\nDigite a media do primeiro aluno";
	cin>>aluno1;
	
	cout<<"\nDigite a media do segundo aluno";
	cin>>aluno2;
	
	cout<<"\nDigite a media do terceiro aluno";
	cin>>aluno2;
	
	media = (aluno1 + aluno2 + aluno3)/3;
	
	if(media >= 7){
		cout<<"\nAprovado";
	}
	else if(media < 7 && media >= 5){
		cout<<"\nRecuperação";
	}
	else if(media < 5){
		cout<<"\nReprovado";
	}
}

//34316615