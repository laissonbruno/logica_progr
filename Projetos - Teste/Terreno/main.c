#include <stdio.h>
#include <math.h>

int main()
{

    double base, altura, diagonal, area, perimetro;

    printf("Qual a base do retangulo? ");
    scanf("%lf", &base);

    printf("Qual a altura do retangulo? ");
    scanf("%lf", &altura);

    area = base * altura;
    perimetro = (base * 2) + (altura * 2);
    diagonal = sqrt(base * base + altura * altura);

    printf("Diagonal= %.4lf\n", diagonal);
    printf("area = %.4lf\n", area);
    printf("perimetro = %.4lf\n", perimetro);


    return 0;
}
