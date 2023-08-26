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
                for (int i = aa; i <= b; i++)
                {
                    printf("* ");
                }
                printf("\n");
                a++;
            }
            else{
                for (int i = aa; i <= b; i++)
                {
                    if (i == aa || i == b) printf("* ");
                    else printf("%d ", i);
                    
                }
                printf("\n");
                a++;
            }
        }
            
    
        return 0;
    }