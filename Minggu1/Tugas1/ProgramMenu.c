#include <stdio.h>

int main(){
    int menu, sisi_k, jari_l, tinggi_l;
    float hasil;
    
    printf("Pilih Menu:\n1. Menghitung Volume Kubus\n2. Menghitung Luas Lingkaran\n3. Menghitung Volume Silinder\n");
    scanf("%d", &menu);
    
    switch (menu){
        case 1:
            printf("Memilih Volume Kubus\n");
            printf("Input Sisi Kubus: ");
            scanf("%d", &sisi_k);
            printf("%d\n", sisi_k);
            
            hasil = sisi_k * sisi_k * sisi_k;
            printf("Volume Kubus nya adalah: %.2f", hasil);
            break;
            
        case 2:
            printf("Memilih Luas Lingkaran\n");
            printf("Input Jari Jari Lingkaran: ");
            scanf("%d", &jari_l);
            printf("%d\n", jari_l);
            
            hasil = jari_l * jari_l * 3.14;
            printf("Volume Kubus nya adalah: %.2f", hasil);
            break;
            
        case 3:
            printf("Memilih Volume Silinder\n");
            printf("Input Jari Jari Lingkaran: ");
            scanf("%d", &jari_l);
            printf("%d\n", jari_l);
            printf("Input Tinggi Lingkaran: ");
            scanf("%d", &tinggi_l);
            printf("%d\n", tinggi_l);
            
            hasil = jari_l * jari_l * 3.14 * tinggi_l;
            printf("Volume silinder nya adalah: %.2f", hasil);
            break;
            
        default:
            printf("Tidak Ada Opsi!");
            break;
    }
}