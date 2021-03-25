/*
distancia < = raio (ponto dentro)
distancai > raio ( ponto fora )
area = pi raio ²
perimetro = 2 pi raio
distancia = sqrt (xp - xc)² + (yp-yc)²
Esse sisteminha calcula o raio, dois pontos dentro do circulo no plano cartesiano, e mais outros dois pontos pra verificar se eles estão dentro ou fora do Círculo.
*/
#include <iostream>
#include <cmath>

using namespace std;

class Circulo{
    public: double raio, area, perimetro, pontoX_circulo, pontoY_circulo;
    double pontoX_fora, pontoY_fora;

    void calculo_raio(){ // Recebe o raio do círculo e calcula a área.
        cout << "Digite o raio: " <<endl;
        cin >> raio;
        area = 3.14 * pow(raio,2);
    }
    void calculo_perimetro(){ // cálculo do perímetro do círculo
        perimetro = (2 * 3.14) * raio;
    }
    void calculo_pontos(){
        cout << "Digite o ponto X dentro do círculo: " << endl;
        cin >> pontoX_circulo;

        cout << "Digite o ponto Y dentro do círculo: " <<endl;
        cin >> pontoY_circulo;

        cout<<"Digite o ponto X fora do círculo: " <<endl;
        cin >> pontoX_fora;

        cout<<"Digite o ponto Y fora do circulo: " <<endl;
        cin >> pontoY_fora;        
        
        double distancia = sqrt(pow(pontoX_fora - pontoX_circulo, 2) + (pontoY_fora-pontoY_circulo, 2)); // matemática pra verificar se os pontos estão dentro ou fora
        if (distancia <= raio){
            cout<<"O ponto está dentro do círculo! " <<endl;
        }
        else {
            cout<<"O ponto está fora do círculo! " <<endl;
        }
    }


};

int main(int argc, char const *argv[])
{
    Circulo c1 = Circulo();     // CHAMADA DAS FUNÇÕES
    c1.calculo_raio();
    c1.calculo_perimetro();
    c1.calculo_pontos();


    return 0;
}
