#include <stdio.h>
float dAvg(float disp[], size_t length){
    size_t c;
    float sum = 0;

    // Calculate sum first
    for (c = 0; c < length; c++){
        sum += disp[c];
    }

    // Find average by dividing the sum by the number of numbers in a row
    return sum / (float) length;
} 

int main(void){
    int i;
    
    /* 2D array declaration*/
    int y,x;
   

   printf("masukan panjang banjar :");
   scanf("%i",&y);

   printf("masukan panjang baris :");
   scanf("%i",&x);
float disp[y][x];


   /*Counter variables for the loop*/
   int  j;
   for(i=0; i<y; i++) {
      for(j=0;j<x;j++) {
         printf("Enter value for disp[%d][%d]:", i, j);
         scanf("%f", &disp[i][j]);
      }
   }
   //Displaying array elements
   printf("Two Dimensional array elements:\n");
   for(i=0; i<2; i++) {
      for(j=0;j<3;j++) {
         printf("%.2f ", disp[i][j]);
         if(j==2){
            printf("\n");
         }
      }
   }
   

    //Computes the average value per row of array
    for(i = 0; i < 3; i++){
        printf("The average of row %d is %f\n", i, dAvg(disp[i], 5));
    }

    return 0;
}