#include<stdio.h>

void main(){
    char huruf[6] = {'c', 'a', 'e', 'w', 't'};
    
    int x = sizeof(huruf);
    printf("%d\n", x);

    for (int i = 0; i < x-1; i++)
    {
        printf("array ke %d: %c\n", i, huruf[i]);
    }
    
    int lenght = sizeof(huruf)/sizeof(*huruf);
    printf("%d\n", lenght);
 

    printf("\n");

    int angka[6] = {1, 2, 5, 7, 3, 9};
    int y = sizeof(angka);

    for (int i = 0; i < y; i++)
    {
        printf("array ke %d: %c\n", i, huruf[i]);
    }

    int lenght_1 = sizeof(angka)/sizeof(*angka);
    printf("%d\n", lenght_1);

    
}