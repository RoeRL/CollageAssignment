#include<stdio.h>
#include<string.h>

int get_result(int number);

int main(){
    int max_loop;

    printf("Input Max Loop: ");
    scanf("%d", &max_loop);

    get_result(max_loop);
    return 0;

}

int get_result(int number){
    
    for (int i = 1; i <= number; i++)
    {
        printf("%d ", i);
    }
    
    printf("\n");
    number--;
    if (number <= 0) return 0;
    else return get_result(number);
}