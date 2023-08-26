#include <stdio.h>

int main() {
    int N;
    
    printf("Masukkan nilai N: ");
    scanf("%d", &N);
    
    if(N>50){
        if(N>75){
            N-=25;
        }
        else{
            N-=10;
        }
    }
    else{
        N+=10;
    }
    
    printf("Hasil: ");
    printf("%d", N);
    
    return 0;
}