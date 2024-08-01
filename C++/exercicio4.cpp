#include <iostream>
using namespace std;

float celsius;

main(){
	system("chcp 65001");
	system("color A");
	
	cout<<"Quantos graus celsius está fazendo hoje?"<<endl;
	cin>>celsius;
	
	cout<<"Hoje está fazendo "<<(9*celsius + 160)/5<<" graus Fahrenheit"<<endl;
}