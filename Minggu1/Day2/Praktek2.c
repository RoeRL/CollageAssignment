int main()
{
    int a, b;
    a = 1;
    printf("Masukkan Batas Loop: ");
    scanf("%d", &b);
    
    do{
        printf("\nLoop ke: %d", a);
        a++;
    }
    while(a<b);
    

    return 0;
}
