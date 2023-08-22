#include <stdio.h>
#include <math.h>
#include <stdlib.h>

int main() {
    float a,b,c,D,x1,x2;
    
    printf("Masukkan Nilai A: ");
    scanf("%f", &a);
    
    printf("Masukkan Nilai B: ");
    scanf("%f", &b);
    
    printf("Masukkan Nilai C: ");
    scanf("%f", &c);
    
    D = (b*b) - (4*a*c);
    
    
    if(D==0){
       x2 = -b/(2*a);
       x1 = x2; 
    }
    if(D>0){
        x1 = (-b + sqrt(D)) / 2*a;
        x2 = (-b - sqrt(D)) / 2*a;
    }
    if(D<0){
        x1=((-1*b)/(2*a))+(sqrt(abs(D))/(2*a));
        x2=((-1*b)/(2*a))-(sqrt(abs(D))/(2*a));
    }
    
    printf("Hasil x1 x2: %.2f %.2f", x1, x2);
    
    
    return 0;
}