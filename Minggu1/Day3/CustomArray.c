#include<stdio.h>

void input_data(int max, int index);
int angka[3];
void main(){
    
    int lenght = sizeof(angka)/sizeof(*angka);

    input_data(lenght, 1);

    printf("array %c\n", angka[1]);

    for (int i = 0; i < lenght; i++)
    {
        printf("array ke %d: %c\n", i, angka[i]);
    }
}

void input_data(int max, int index){
    int input;
    printf("Masukkan data ke %d: ", index);
    scanf("%d", &input);

    angka[index] = input;
    index++;
    if(index > max) return;
    else input_data(max, index);
}