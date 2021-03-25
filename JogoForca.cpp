#include <iostream>

int main(int argc, char const *argv[])
{
    int tamanho=0, i=0, acertos=0;
    char palavra[30], secreta[30], letra[1];
    bool acerto=false;

    std::cout<<"Digite uma palavra secreta: " <<std::endl;
    std::cin >> palavra;
    system("cls");

    while(palavra[i] != '\0'){
        i++;
        tamanho++;
    }
    for(i=0; i<tamanho; i++){
        secreta[i] = '-';
    }

    // Esse bloco acima, recebe uma palavra, primeiro while calcula a qtde de caracteres da palavra digitada pelo usuario, o ciclo for transforma o char secreta em um char de mesmo "tamanho"
    // que a palavra digitada pelo usuario, e troca esses caracteres pelo digito '-'.

    int chances=tamanho+2; 
//  adiciona as chances do usuario

    while(chances > 0 && acertos < tamanho){ // enquanto o número de chances for maior que zero e a quantidade de acertos for menor que o tamanho do char digitado pelo usuario, o programa rodará esse while
        system("cls");

        std::cout<<"Chances restantes: " << chances << std::endl;
        std::cout<<"Palavra secreta: " <<std::endl;

        for(i=0;i<tamanho; i++){ // esse for imprime a palavra secreta na tela a medida que o usuario vai acertando ou nao
            std::cout << secreta[i];
        }
        std::cout<<"\nDigite uma letra: " <<std::endl;
        std::cin >> letra[0];

        for(i=0; i<tamanho; i++){    //verifica se a letra digitada pelo usuario existe dentro do array de char digitado pelo user. Se sim, incrementa os acertos e adiciona no char "secreta" aquela letra na mesma posicao do char "palavra"
                             
            if(letra[0] == palavra[i]){
                acertos++;
                acerto=true;
                secreta[i] = palavra[i];
            }
        }
        

        if(acerto==false){ // se a letra digitada nao existe na palavra digitada no começo, decrementa uma chance do usuario.
            chances--;
        }

        acerto=false;  // seta o bool acerto pra false pra receber outra letra no começo
        system("cls");

    }

    if(acertos==tamanho){  // se a quantidade de acertos for igual ao tamanho das letras quer dizer que o usuario acertou.
        std::cout<<"Parabens, voce ganhou! " <<std::endl;
        std::cout<<"a palavra secreta era: " << palavra;
    }

    if(chances==0){  // se a quantidade de chances chegar a zero, perdeu.
        std::cout<<"Parabens, voce perdeu! " <<std::endl;
        std::cout<<"A palavra secreta era:" << palavra << std::endl;
    }

    return 0;
}
