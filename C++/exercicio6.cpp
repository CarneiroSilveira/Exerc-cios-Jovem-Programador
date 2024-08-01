#include <iostream>
using namespace std;

int segundos, h, m, s, resto;

int main() {
	
	system("chcp 65001");
	system("color A");

	cout<<"Digite os segundos "<<endl;
    cin>>segundos;
    h = segundos / 3600;
    resto = segundos % 3600;
    m = resto / 60;
    s = resto % 60;
    
    cout<<"Convertendo os segundos em Horas minutos e segundos obitemos o segunte resultado: "<<h<<":"<<m<<":"<<s<<endl;
}