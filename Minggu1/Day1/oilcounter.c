#include <stdio.h>

int main() {
    int uang;
    float I_pertamax, I_pertalite, I_solar;
    int pertamax = 1500;
    int pertalite = 1000;
    int solar = 800;

    printf("Input Uang:");
    scanf("%d", &uang);
    printf(" %d\n", uang);

    I_pertamax = (float)uang/pertamax;
    I_pertalite = (float)uang/pertalite;
    I_solar = (float)uang/solar;

    printf("Pertamax: %.2f\n", I_pertamax);
    printf("Pertalite: %.2f\n", I_pertalite);
    printf("Solar: %.2f", I_solar);

    return 0;
}