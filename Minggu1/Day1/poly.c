#include <stdio.h>

int main() {
    int x;
    int hasil;

    printf("Input x:");
    scanf("%d", &x);
    printf(" %d\n", x);

    hasil = (3*(x*x))-((5*x)+6);

    printf("hasil: %d", hasil);
    
    return 0;
}