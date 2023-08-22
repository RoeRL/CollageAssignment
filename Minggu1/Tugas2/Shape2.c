#include<stdio.h>
int print_count_data(int awal, int akhir, int index);
int print_number_with_asterix(int awal, int akhir);
int print_number(int index, int akhir);
int print_asterix(int awal, int akhir);

int main(){
    int a, b;
    printf("Masukkan Awal Loop: ");
    scanf("%d", &a);
    printf("Masukkan Batas Loop: ");
    scanf("%d", &b);

    print_asterix(a, b);
    print_count_data(a, b, 1);
    print_asterix(a, b);
    return 0;
}
//fungsi
int print_count_data(int awal, int akhir, int index){
    print_number_with_asterix(awal, akhir);
    index++;
    if (index>akhir-2) return 0;
    else print_count_data(awal, akhir, index);
}
int print_number_with_asterix(int awal, int akhir){
    printf("* ");
    print_number(awal+1, akhir-1);
    printf("* ");
    printf("\n");
}
int print_number(int index, int akhir){
    printf("%d ", index);
    index++;
    if(index>akhir) return 0;
    else print_number(index, akhir);
}
int print_asterix(int awal, int akhir){
    printf("* ");
    awal++;
    if(awal>akhir){
        printf("\n");
        return 0;
    }
    else print_asterix(awal, akhir);
}