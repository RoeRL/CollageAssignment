#include <stdio.h> 
 
int main(){ 
 int i,jum,x,s; 
 s = 15 ;
 int a[s];

    printf ("masukan angka array \n");
    for (i = 0; i < s; i++){
        scanf ("%d", &a[i]);
    }

    printf ("isi angka array : \n");
    
    for (i = 0; i < s; i++){
        printf ("%d\t", a[i]);
    }
    


  
 jum = 0; 
 printf("Masukkan nilai yang dicari = "); 
 scanf("%i",&x); 
  
 for(i=0;i<10;i++){ 
  if(a[i]==x){ 
   jum = jum + 1; 
  } 
 } 
 printf("Nilai %i, ada %i buah",x, jum);
 return 0;
}