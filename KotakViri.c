#include<stdio.h>
    int main(){
          int i, j, input;
          int row = 1;
        
          printf("masukan angka : ");
          scanf("%d", & input);
        
          while (row <= input) {
            for (i = 1; i <= input; i++) {
              //   printf("%d", row);
              printf("");
              if (row > 1 && row < input) {
                if (row == 2) {
                  printf("");
                }
                if (input % 2 == 0) { //even
                  for (i += 1; i < input; i++) {
                    printf(" ");
                  }
                }
                for (i += i; i < input; i++) {
                  printf("%d", i);
                }
                printf("*");
              }
            }
            printf("\n");
            row++;
          }
    }