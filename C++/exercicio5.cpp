#include <iostream>
using namespace std;

float milhas;

main(){
	system("chcp 65001");
	system("color A");
	
	cout<<"Diga a quantidade de milhas!"<<endl;
	cin>>milhas;
	cout<<"Convertendo para quilometros temos: "<<milhas*1.609344<<" Kms";
}