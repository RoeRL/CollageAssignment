
#include <stdio.h>

int main() {
    int menu, n1, n2;
    float hasil;
    double hasil_d;
    
    printf("Input Angka Pertama: ");
    scanf("%d", &n1);
    
    printf("Input Angka Kedua: ");
    scanf("%d", &n2);
    
    printf("Pilih Menu:\n1. Penjumlahan\n2. Pengurangan\n3. Pembagian\n4. Perkalian\nPilihan: ");
    scanf("%d", &menu);
    
    if (menu == 1){
        hasil = n1 + n2;
        printf("%.2f", hasil);
    }
    else if (menu == 2){
        hasil = n1 - n2;
        printf("%.2f", hasil);
        
    }
    else if (menu == 3){
        if (n1 == 0 || n2 == 0){
            printf("Tak Terhingga atau 0");
        }else{
            hasil_d = (double)n1 / n2;
            printf("%.2lf", hasil_d);   
        }
        
    }
    else if (menu == 4){
        hasil = n1 * n2;
        printf("%.2f", hasil);
    }
    else{
        printf("Tidak ada opsi!");
    }
    
    return 0;
}