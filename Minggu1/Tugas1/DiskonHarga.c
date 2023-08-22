#include <stdio.h>

int main() {
    int harga;
    float hasil, diskon;
    diskon = 0.05;
    
    printf("Input Harga: ");
    scanf("%d", &harga);
    
    if(harga >= 100000){
        hasil = harga - (harga * diskon);
    }
    else{
        printf("tidak mendapat diskon, harga tetap: ");
        hasil = (float)harga;
    }
    printf("%.2f", hasil);
    
    return 0;
}