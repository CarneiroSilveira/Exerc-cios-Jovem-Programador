#include <iostream>
using namespace std;

float q;
int m, c;

int main() {
	
	system("chcp 65001");
	system("color A");
	
	cout<<"Digite quantos quilometros teremos que calcular: ";
	cin>>q;
	
	m = q * 1000;
	c = (q * 1000 - m) * 100;
	
	cout<<"\nO resultado do calculo foi: "<<m<<" Metros e "<<c<<" Centimetros."<<endl;
}