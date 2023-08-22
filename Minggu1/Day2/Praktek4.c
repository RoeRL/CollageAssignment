#include <stdio.h>

    int main()
    {
        int a, b, banyak;
        a=1;
        b=1;
        printf("Masukkan Batas Loop: ");
        scanf("%d", &banyak);
        
        while(a<=banyak){
            while(b<=banyak){
                printf("%d", b);
                b++;
            }
            b=1;
            printf("\n");
            a++;
        }
        return 0;
    }