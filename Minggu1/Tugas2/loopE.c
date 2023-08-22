#include <stdio.h>

    int main()
    {
        int a, b, bb;
        
        printf("Masukkan Batas Loop: ");
        scanf("%d", &b);
        
        for(a=1; a<=b; a++){
            if(b%2!=0){
                bb = ((b-1)/2)+1;
                if(a <= bb){
                    printf("* ");
                }
                else{
                    printf("%d ", a);
                }
            }
            else{
                bb = b/2;
                if(a<=bb){
                    printf("* ");
                }
                else{
                    printf("%d ", a);
                }
            }
            
        }
            
    
        return 0;
    }