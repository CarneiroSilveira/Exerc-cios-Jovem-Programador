#include <iostream>
using namespace std;

float persona1, persona2, persona3, persona4, persona5;

main(){
	system("chcp 65001");
	system("color A");
	
	cout<<"Qual o peso da primeira perssoa? "<<endl;
	cin>>persona1;
	
	cout<<"Qual o peso da segunda pessoa? "<<endl;
	cin>>persona2;
	
	cout<<"Qual o peso da terceira pessoa?"<<endl;
	cin>>persona3;
	
	cout<<"Qual o peso da quarta pessoa?"<<endl;
	cin>>persona4;
	
	cout<<"Qual o peso da quinta pessoa?"<<endl;
	cin>>persona5;


	cout<<"a media dos pessos dessas pessoas é igual a: "<<(persona1 + persona2 + persona3 + persona4 + persona5)/5<<endl;
	
}