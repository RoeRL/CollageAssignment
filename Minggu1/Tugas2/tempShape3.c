#include<stdio.h>
int print_count_data(int awal, int akhir, int index);
int print_number_with_asterix(int awal, int akhir);
int print_number(int index, int akhir);
int print_asterix(int awal, int akhir);

int main(){
    int bb, max_loop;
    int a = 1;
    printf("Masukkan Batas Loop: ");
    scanf("%d", &max_loop);

    
    
    
    print_asterix(a, max_loop);
    print_count_data(a, max_loop, 1);
    print_asterix(a, max_loop);
    return 0;
}
//fungsi
//Vertical Counting
int print_count_data(int awal, int akhir, int index){
    int bb;
    bb = ((akhir-1)/2)+1;
    if (akhir == bb)
    {
        print_asterix(awal, akhir);
    }
    print_number_with_asterix(awal, akhir);
    index++;
    if (index>akhir-2) return 0;
    else print_count_data(awal, akhir, index);
}
//* 2 3 4 *
int print_number_with_asterix(int awal, int akhir){
    printf("* ");
    print_number(awal+1, akhir-1);
    printf("* ");
    printf("\n");
}
//2 3 4
int print_number(int index, int akhir){
    printf("  ");
    index++;
    if(index>akhir) return 0;
    else print_number(index, akhir);
}
//* * * * *
int print_asterix(int awal, int akhir){
    printf("* ");
    awal++;
    if(awal>akhir){
        printf("\n");
        return 0;
    }
    else print_asterix(awal, akhir);
}