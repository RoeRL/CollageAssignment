#include <stdio.h>

    int main()
    {
        int a, b;
        printf("Masukkan Batas Loop: ");
        scanf("%d", &b);
        
        for(a=1; a<=b; a++){
            if(a%2==0){
                printf("* ");
            }
            else{
                printf("%d ", a);
            }
        }
            
    
        return 0;
    }