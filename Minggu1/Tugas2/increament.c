#include<stdio.h>
int main(){
    int num, t_num, t_hasil, count;
    char j = 'y';
    count = 1;
    t_hasil = 0;

    


    while (j=='y')
    {
        printf("Masukkan Bilangan Ke-%d: ", count);
        scanf("%d", &t_num);
        
        num = t_num;
        
        count++;

        printf("Apakah mau memasukkan data lagi?[y/n]: ");
        scanf("%s", &j);
        
        t_hasil = num + t_hasil;
        
    }

    printf("Hasil: %d", t_hasil);
    
    

}