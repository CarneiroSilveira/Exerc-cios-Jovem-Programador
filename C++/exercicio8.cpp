#include <iostream>
using namespace std;

int n;


int main() {

	system("chcp 65001");
	system("color A");
	
    cout<<"Digite um numero para ver sua tabuada:";
    cin>>n;

    cout<<"\nTabuada de Multiplicacão:"<<endl;
    for(int i = 0; i <= 10; ++i) {
        cout<<n<<" x "<<i<<" = "<<n * i<<endl;
    }

    cout<<"\nTabuada de Adicão:"<<endl;
    for(int i = 0; i <= 10; ++i) {
        cout<<n<<" + "<<i<<" = "<<n + i<<endl;
    }

    cout<<"\nTabuada de Subtracão:"<<endl;
    for(int i = 0; i <= 10; ++i) {
        cout<<n<<" - "<<i<<" = "<<n - i<<endl;
    }

    cout<<"\nTabuada de Divisão:"<<endl;
    for(int i = 1; i <= 10; ++i) {
        cout<<n<<" / "<<i<<" = "<<n / i<<endl;
    }
	
	
	// Esse eu não vou mentir fiz o codigo pelo chat gpt. Motivo preguisa de fazer sem o for.
}