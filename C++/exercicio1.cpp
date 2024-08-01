#include <iostream>
using namespace std;

float x;
float y;

main(){
	system("chcp 65001");
	system("color A");
	cout<<"Digite um numero REAL (com . e não com ,): "<<endl;
	cin>>x;
	cout<<"Digite mais um numero REAL: "<<endl;
	cin>>y;
	cout<<"A soma dos numeros é "<<x+y;
}