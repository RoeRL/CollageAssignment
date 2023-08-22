#include <stdio.h>

    int main()
    {
        int a, b, bb;
        bb = 1;
        
        printf("Masukkan Batas Loop: ");
        scanf("%d", &b);
        for(a=1; a<=b; a++){
            bb = bb*a;
        }
        printf("Hasil Faktorial %d adalah: %d", b, bb);
    
        return 0;
    }