#include <iostream>
using namespace std;

float calcularArea(float base, float altura) {
    return base * altura / 2;
}

void verificarTriangulo(float a, float b, float c) {
        cout << "Os valores formam um triângulo." << endl;
        float base, altura;
        cout << "Digite o valor da base do triângulo: ";
        cin >> base;
        cout << "Digite o valor da altura do triângulo: ";
        cin >> altura;
        float area = calcularArea(base, altura);
        cout << "A área do triângulo é: " << area << endl;
    } else {
        cout << "Os valores não formam um triângulo." << endl;
    }
}

int main() {
	
	system("chcp 65001");
	system("color A");
	
    float a, b, c;
    cout << "Digite o valor de a: ";
    cin >> a;
    cout << "Digite o valor de b: ";
    cin >> b;
    cout << "Digite o valor de c: ";
    cin >> c;
    verificarTriangulo(a, b, c);
}