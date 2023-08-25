#include <stdio.h>
int main()
{
    int a[10]={22,32,5,17,21,26,29,55,19,20};
    int i,j,n,x;

    i=0;
    n=0;
    while(i<4){
        j=0;
        while(j<1+i){
            printf("%3i",a[n]);
            n=n+1;
            j++;
        }
        printf("\n");
        i++;

    }
    return 0;
}