#include <stdio.h>

    int main()
    {
        int a, b, aa;
        printf("Masukkan Awal Loop: ");
        scanf("%d", &a);
        aa = a;
        printf("Masukkan Batas Loop: ");
        scanf("%d", &b);
        
        while(a<=b){
            if(a==aa || a==b){
                printf("*\n");
                a++;
            }
            else{
                printf("%d\n", a);
                a++;
            }
        }
            
    
        return 0;
    }