#include<stdio.h>
#include<string.h>

int get_result(int number, int index);

int main(){
    int max_loop;

    printf("Input Max Loop: ");
    scanf("%d", &max_loop);

    get_result(max_loop, 1);
    return 0;

}

int get_result(int number, int index){
    
    for (int i = 1; i <= index; i++)
    {
        printf("%d ", i);
    }
    
    printf("\n");
    index++;
    if (index >= number+1) return 0;
    else return get_result(number, index);
}