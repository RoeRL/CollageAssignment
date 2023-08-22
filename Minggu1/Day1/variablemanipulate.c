#include <stdio.h>

int main() {
    int nilai_A, nilai_B, nilai_C;

    printf("Input A:");
    scanf("%d", &nilai_A);
    printf(" %d\n", nilai_A);

    printf("Input B:");
    scanf("%d", &nilai_B);
    printf(" %d\n", nilai_B);

    nilai_C = nilai_A;
    nilai_A = nilai_B;
    nilai_B = nilai_C;
    
    printf("Hasil A: %d\n", nilai_A);
    printf("Hasil B: %d\n", nilai_B);


    return 0;
}