int main()
{
    int a, b;
    a = 1;
    printf("Masukkan Batas Loop: ");
    scanf("%d", &b);
    
    
    while(a<b){
        printf("\nLoop ke: %d", a);
        a++;
    }
    

    return 0;
}