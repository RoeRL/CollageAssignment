#include <stdio.h>
int main()
{
    double hasil;
    int alas, tinggi;
    printf("Masukkan Alas: \n");
    scanf("%d", &alas);
    printf("Alas = %d\n", alas);
    printf("Masukkan Tinggi: \n");
    scanf("%d", &tinggi);
    printf("Tinggi = %d\n", tinggi);

    hasil = (double)alas * tinggi / 2;
    printf("%.2lf", hasil);
    return 0;
    
}