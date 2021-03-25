#include <iostream>
int Entrada_Veiculo();
void Imprimir_Valor(int valor_pagar);
double Saida_Veiculo(int tipo_veiculo);

int main(int argc, char const *argv[])
{
    int tipo;
    double valor_pagar;
    bool parar = false;
    int opc;
    while (parar != true){
        std::cout<<"1 - ENTRADA DE VEICULO. 2 - SAÍDA DE VEICULO, 3- IMPRIMIR RELATORIO: " <<std::endl;
        std::cin >> opc;
        if (opc == 1){
            tipo = Entrada_Veiculo();
           }
        else if (opc == 2){
            valor_pagar = Saida_Veiculo(tipo);
             Imprimir_Valor(valor_pagar);
            }
        else {
            std::cout << "OPERACAO INCORRETA. TENTE NOVAMENTE: " << std::endl;
        }
    int opc1;
    std::cout<<"APERTE QUALQUER TECLA PARA CONTINUAR. APERTE 5 PARA FINALIZAR O PROGRAMA." << std::endl;
    std::cin >> opc1;
    if (opc1 == 5){
        parar = true;
    } 
    else {
        continue;
    }
    }
    return 0;
}
int Entrada_Veiculo(){
    int tipo_veiculo; // 1 - carro, 2 -moto; - carro 
    std::cout<<"Digite o tipo de veículo a entrar:" <<std::endl;
    std::cin >> tipo_veiculo;
    return tipo_veiculo;
}
double Saida_Veiculo(int tipo_veiculo){
    int tipo = tipo_veiculo;
    double horas=0;
    double valor_pagar=0;
    std::cout<<"Digite quantas horas o carro ficou: " <<std::endl;
    std::cin >> horas; //carro:  < 30 minutos = isento , 1 hora = 5 , 2 horas = 7, +3 horas = 10
    // moto < 1 hora = isento, 2 horas = 5, 3 horas = 7, +4 horas = 10
    switch (tipo){
        case 1:
        if (horas < 0.3){
            valor_pagar = 0.00;
            return valor_pagar;
        }
        else if (horas > 0.3 && horas < 1.00){
            valor_pagar = 5.00;
            return valor_pagar;
        }
        else if (horas > 1.00 && horas < 2){
            valor_pagar = 7;
            return valor_pagar;
        }
        else {
            valor_pagar = 10;
            return valor_pagar;
        }
        case 2:
         if (horas < 1.00){
            valor_pagar = 0.00;
            return valor_pagar;
        }
        else if (horas > 1.00 && horas < 2){
            valor_pagar = 5;
            return valor_pagar;
        }
        else {
            valor_pagar = 7;
            return valor_pagar;
        }
        default:
        std::cout<<"TEMPO INCORRETO! tente novamente " << std::endl;
        break;
    }
}
void Imprimir_Valor(int valor_pagar){
    double preco = valor_pagar;
    if (preco == 0){
        std::cout << "ISENTO DE PAGAMENTO ! " <<std::endl;
        exit(0);
    }
    else {
    }
    std::cout<<"Você tem que pagar: R$ " << preco << std::endl;
    std::cout << "Valor recebido: R$ " << std::endl;
    double valor_recebido;
    std::cin >> valor_recebido;
    double troco = preco - valor_recebido;
    if (valor_recebido > preco){
        std::cout << "Valor a pagar: R$ " << preco << std::endl;
        std::cout << "Valor recebido: R$ " << valor_recebido << std::endl;
        std::cout << "Seu troco: R$" << troco << std::endl;
    }
    else if (preco == valor_recebido){
        std::cout<<"Valor recebido correto. OBRIGADO" << std::endl;
    }

    else if (preco > valor_recebido){
        std::cout<<"Ainda faltam: R$"  << preco << std::endl;
    }
    else {
        std::cout<<"OBRIGADO E VOLTE SEMPRE" <<std::endl;
    }
}
