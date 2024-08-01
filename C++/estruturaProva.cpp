#include <iostream>

using namespace std;

main() {
    int op;
    system("chcp 65001");
    system("color A");
    
    do{
        cout<<"\n \t Escolha uma opção a seguir: \n";
        cout<<"\n [1] Exercício 1";
        cout<<"\n [2] Exercício 2";
        cout<<"\n [3] Exercício 3";
        cout<<"\n [4] Exercício 4";
        cout<<"\n [5] Exercício 5";
        cout<<"\n [6] Use a sua criatividade";
        cout<<"\n [7] Encerrar \n";
        cin>>op;
        switch(op) {
            case 1: {
            	//FUP 8
            	int n;
                cout<<"Digite um numero para ver sua tabuada:";
    			cin>>n;

    			cout<<"\nTabuada de Multiplicacão:"<<"\n";
    			for(int i = 0; i <= 10; i+=1) {
        			cout<<n<<" x "<<i<<" = "<<n * i<<"\n";
    			}

    			cout<<"\nTabuada de Adicão:"<<"\n";
    			for(int i = 0; i <= 10; i+=1) {
        			cout<<n<<" + "<<i<<" = "<<n + i<<"\n";
    			}

    			cout<<"\nTabuada de Subtracão:"<<"\n";
    			for(int i = 0; i <= 10; i+=1) {
        			cout<<n<<" - "<<i<<" = "<<n - i<<"\n";
    			}

    			cout<<"\nTabuada de Divisão:"<<"\n";
    			for(int i = 1; i <= 10; i+=1) {
        			cout<<n<<" / "<<i<<" = "<<n / i<<"\n";
    			}
                break;
            };
            case 2: {
            	//FUP 15
                float a, b, c;
			    float base, altura, area;
			    
			    cout<<"\nDigite o valor de a: ";
			    cin>>a;
			    
			    cout<<"\nDigite o valor de b: ";
			    cin>>b;
			    
			    cout<<"\nDigite o valor de c: ";
			    cin>>c;
			
			    if (a < b + c && b < a + c && c < a + b) {
			        
			        cout<<"\nOs valores formam um triângulo. Digite a base";
			        cin>>base;
			        
			        cout<<"\nAgora digite a altura";
			        cin>>altura;
			        
			        area = (base * altura) / 2;
			        
			        cout<<"\nA área do triângulo é: "<<area<<"\n";
			    } else {
			        cout<<"Os valores não formam um triângulo."<<"\n";  
			        cout<<"Valores lidos: a = "<<a<<", b = "<<b<<", c = "<<c<<"\n";
			    }
                break;
            };
            case 3: {
            	// FUP 20
                float ipi = 0.13;
				string codigo1;
				string codigo2;
				float valorUnitario1;
				float valorUnitario2;
				int quantidade1;
				int quantidade2;
				float valorFinal;
				
				cout<<"\nDigite o codigo do primeira peça ";
				cin>>codigo1;
				
				cout<<"\nDigite o valor unitario da primeira peça ";
				cin>>valorUnitario1;
				
				cout<<"\nQuantas peças você vai comprar? ";
				cin>>quantidade1;
				
				cout<<"\nDigite o codigo do segunda peça ";
				cin>>codigo1;
				
				cout<<"\nDigite o valor unitario da segunda peça ";
				cin>>valorUnitario1;
				
				cout<<"\nQuantas peças você vai comprar? ";
				cin>>quantidade1;
				
				valorFinal = (valorUnitario1 * quantidade1 + valorUnitario2 * quantidade2) * (ipi + 1);
				
				cout<<"o valor final da compra das peças foi igual a "<<valorFinal;
                break;
            };
            case 4: {
            	// FUP 25
                int quantidade;
				float alturaTotal;
				float resutado;
				
				cout<<"\nDigite a quantidade de usuários: ";
				cin>>quantidade;
				
				for(int i = 1; i <= quantidade; i++){
					float usuarioAtual;
					cout<<"\nDigite a altura do usuário numero "<<i<<" ";
					cin>>usuarioAtual;
					alturaTotal += usuarioAtual;
				}
				resutado = alturaTotal / quantidade;
				cout<<"A media da altura dos usuários é "<<resutado;
                break;
            };
            case 5: {
            	// FUP 28
            	float nums[10];
			    int negativos = 0;
			    for(int i = 0;i <= 9; i+=1){
			    	cout<<"\nDigite o numero da "<<i+1<<"ª posição: ";
			    	cin>>nums[i];
			        
			    	if(nums[i] < 0){
			        	negativos += 1;
					}
				}
			
				cout<<"\nDos 10 numeros recebidos "<<negativos<<" foram negativos!";
                break;
            };
            case 6: {
                cout<<"Sendo criativo";
                break;
            };
            case 7: {
                cout<<"Finalizando";
                break;
            };
            default:
                cout<<"\nOpção inválida";
                break;
        }
    }while(op != 7);
    cout<<"\n\n\n\n\n - Até mais \n\n\n\n\n";
}

