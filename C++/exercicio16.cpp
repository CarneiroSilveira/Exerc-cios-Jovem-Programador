#include <iostream>
using namespace std;

string cpf;
int dependentes;
float salario, imposto;
float salarioMinimo = 1412;
float porcentagem = 0.05;
bool mock = true;

int main(){
	system("chcp 65001");
	system("color A");
	
	cout<<"Irá usar mock?";
	cin>>mock;
	
	if (mock == 0){
		cout<<"\nDigite o numero do CPF do contribuinte! ";
		cin>>cpf;
	
		cout<<"\nAgora digite o salario na carteira de trabalho ";
		cin>>salario;
	
		cout<<"\nQuantos dependentes o contribuinte tem? ";
		cin>>dependentes;
	}
	
	else if(mock == 1){
		cpf = "40028922";
		salario = 10000;
		dependentes = 1;
	}
	
	float descontosPendentes = porcentagem * salarioMinimo * dependentes;
	float salarioLiquido = salario - descontosPendentes;
	
	if(salario < salarioMinimo*2){
		cout<<"O usuário do CPF "<<cpf<<" está Isento";
	}
	
	else if(salario > salarioMinimo*2 && salario <= salarioMinimo*3){
		imposto = porcentagem*salarioLiquido;
		if(imposto > 0){
			cout<<"O usuário do CPF "<<cpf<<" Tera que pagar "<<porcentagem*100<<"% de do salario totalizando "<<imposto<<" de imposto";	
		}
		else if(imposto <= 0){
			cout<<"O usuário do CPF "<<cpf<<" está Isento";
		}
	}
	
	else if(salario > salarioMinimo*3 && salario <= salarioMinimo*5){
		porcentagem = porcentagem*2;
		imposto = porcentagem*salarioLiquido;
		if(imposto > 0){
			cout<<"O usuário do CPF "<<cpf<<" Tera que pagar "<<porcentagem*100<<"% de do salario totalizando "<<imposto<<" de imposto";		
		}
		else if(imposto <= 0){
			cout<<"O usuário do CPF "<<cpf<<" está Isento";
		}
	}
	
	else if(salario > salarioMinimo*5 && salario <= salarioMinimo*7){
		porcentagem = porcentagem*3;
		imposto = porcentagem*salarioLiquido;
		if(imposto > 0){
			cout<<"O usuário do CPF "<<cpf<<" Tera que pagar "<<porcentagem*100<<"% de do salario totalizando "<<imposto<<" de imposto";	
		}
		else if(imposto <= 0){
			cout<<"O usuário do CPF "<<cpf<<" está Isento";
		}
	}
	
	else if(salario > salarioMinimo*7){
		porcentagem = porcentagem*4;
		imposto = porcentagem*salarioLiquido;
		if(imposto > 0){
			cout<<"O usuário do CPF "<<cpf<<" Tera que pagar "<<porcentagem*100<<"% de do salario totalizando "<<imposto<<" de imposto";	
		}
		else if(imposto <= 0){
			cout<<"O usuário do CPF "<<cpf<<" está Isento";
		}
	}
}

// Neste exercicio eu utilizei o chat gpt para calcular a porcentagem de um jeito eficiente.



//A representação em Ponto Flutuante é o modo como o computador representa números reais.
//O conjunto dos números reais é aquele que abrange os números racionais e irracionais. Por exemplo o número 32,864 é um número real pois faz parte do conjunto dos números racionais. Ou seja nós humanos representamos os números racionais assim:
//xx,yyyy


//Onde xx é a parte inteira e yyyy é a parte fracionaria (que pode assumir um número infinito)
//Mas os computadores não podem representar números reais dessa forma, pois seria muito complicado. Assim os computadores adotam um outro método de representação de números reais: a notação científica. Na notação científica um número é definido da seguinte forma:

//Valor  X  Base^Expoente


//Por exemplo o número 52,258 é representado na notação científica como 0,52258 X 10^2. Obviamente, o computador faz isso usando o sistema binário e seguindo regras precisas.