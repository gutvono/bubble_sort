int[] numeros = new int[10];
int i = 0, j = 0, temp = 0;

Console.WriteLine("Informe os valores desejados para que sejam ordenados:");
for (i = 0; i < 5; i++)
{
    Console.Write(i + 1 + " - ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (i = 0; i < 5; i++)
{
    for (j = 0; j < 5; j++)
    {
        if (numeros[j] > numeros[j + 1]) {
            temp = numeros[j];
            numeros[j] = numeros[j + 1];
            numeros[j + 1] = temp;
        }
    }
}

Console.WriteLine("Vetor ordenado:");
for (i = 0; i < 5; i++)
{
    Console.Write($"{numeros[i]}  ");
}