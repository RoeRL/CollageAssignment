#include <stdio.h>
#include <conio.h>
#include <ctype.h>
#include <string.h>

// Inisialisasi prosedur/fungsi
void ambilString(void);
void tampil(void);
int hitungKarakter(int panjang_teks);

// Deklarasi variabel
char angka[] = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '\0'};
char h_vokal[] = {'A', 'E', 'I', 'O', 'U', '\0'};

char teks[256];
int vokal = 0; // menghitung vokal
int konsonan = 0; // menghitung konsonan
int bilangan = 0; // menghitung bilangan
int spasi = 0; // menghitung spasi
int lainnya = 0; // karakter lainnya

int panjang_teks, i;

// Fungsi utama
int main(void) {
    // Header untuk tampilan awal
    printf("\n");
    printf("========================================\n");
    printf("PROGRAM MENENTUKAN JUMLAH KONSONAN, VOKAL, SPASI,\n");
    printf("BILANGAN, DAN KARAKTER LAINNYA.\n");
    printf("========================================\n");

    ambilString(); // Menjalankan fungsi ambilString
    panjang_teks = strlen(teks); // Menghitung panjang teks
    hitungKarakter(panjang_teks); // Menjalankan fungsi hitungKarakter dengan meneruskan panjang teks
    tampil(); // Menjalankan fungsi tampil

    getch();
    return 0;
}

// Implementasi fungsi ambilString
void ambilString(void) {
    printf("Masukkan sebuah baris teks: ");
    gets(teks);
}

// Implementasi fungsi hitungKarakter
int hitungKarakter(int panjang_teks) {
    for (i = 0; i < panjang_teks; i++) {
        char karakter = toupper(teks[i]); // Mengubah karakter menjadi huruf besar untuk mempermudah pemrosesan
        if (isalpha(karakter)) {
            // Jika karakter adalah huruf
            if (strchr(h_vokal, karakter) != NULL) {
                vokal++;
            } else {
                konsonan++;
            }
        } else if (isdigit(karakter)) {
            // Jika karakter adalah bilangan
            bilangan++;
        } else if (isspace(karakter)) {
            // Jika karakter adalah spasi
            spasi++;
        } else {
            // Karakter lainnya
            lainnya++;
        }
    }
    return panjang_teks;
}

// Implementasi fungsi tampil
void tampil(void) {
    printf("\n");
    printf("Jumlah vokal: %d\n", vokal);
    printf("Jumlah konsonan: %d\n", konsonan);
    printf("Jumlah bilangan: %d\n", bilangan);
    printf("Jumlah karakter spasi: %d\n", spasi);
    printf("Jumlah karakter lainnya: %d\n",lainnya);
}