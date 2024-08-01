#include <iostream>
using namespace std;

int num;

int main(){
	system("chcp 65001");
	system("color A");
	
	cout<<"\nDigite um numero: ";
	cin>>num;
	
	for(int i = 0; i <= 10; i++){
		cout<<"\n"<<num<<" X "<<i<<" = "<<num*i<<endl;
	}
}