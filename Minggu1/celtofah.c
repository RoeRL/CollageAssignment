#include <stdio.h>

int main() {
    float F;
    int C;

    printf("Input C:");
    scanf("%d", &C);
    printf(" %d\n", C);

    F = (C*1.8) + 32;
    printf("%.2f", F);
    return 0;
}