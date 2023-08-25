#include<stdio.h>
#include<string.h>

int column_make(int baris, int kolom);

int main(){
    //baris = horizontal
    //kolom = vertikal
    int baris = 1;
    int kolom = 1;
    int input;

    printf("Input Banyak Praktikum: ");
    scanf("%d", &baris);
    
    printf("Input Banyak Mahasiswa: ");
    scanf("%d", &kolom);

    column_make(baris, kolom);
    return 0;

}

int column_make(int baris, int kolom){
    int tabel[baris][kolom];
    int input;
    
    
    
    for (int ij = 0; ij < kolom; ij++)
    {
        for (int i = 0; i < baris; i++)
        {
            printf("Mahasiswa ke-%d Praktek ke-%d: ",ij+1, i+1);
            scanf("%d", &input);
            tabel[i][ij] = input;
        }
    }
    
    for (int ij = 0; ij < kolom; ij++)
    {
        printf("Mahasiswa ke-%d| ", ij+1);
        for (int i = 0; i < baris; i++)
        {
             printf("Praktek ke-%d: %d ", i+1, tabel[i][ij]);
        }
        printf("\n");
    }
    
    
    
}