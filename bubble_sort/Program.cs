int aux = 0, size = 10, size_ordenado = 0, restart = 0;
int[] original = new int[size];
int[] ordenado = new int[size];
int[] invertido = new int[size];

do
{
    Console.Clear();

    Console.WriteLine("Vetor ORIGINAL:");
    for (int i = 0; i < size; i++)
    {
        //CRIANDO O VETOR ORIGINAL
        original[i] = new Random().Next(1, 5);

        if (i == 0)
        {
            ordenado[size_ordenado] = original[i];
            size_ordenado++;
        }
        else
        {
            bool repete = false;
            for (int j = 0; j < size; j++)
            {
                if (original[i] == ordenado[j])
                {
                    repete = true;
                }
            }
            if (repete == false) {
                ordenado[size_ordenado] = original[i];
                size_ordenado++;
            }
        }


        Console.Write($"{original[i]}  ");
    }


    //ORDENANDO
    for (int referencia = 0; referencia < size_ordenado; referencia++)
    {
        for (int comparacao = referencia + 1; comparacao < size_ordenado; comparacao++)
        {
            if (ordenado[referencia] > ordenado[comparacao])
            {
                aux = ordenado[referencia];
                ordenado[referencia] = ordenado[comparacao];
                ordenado[comparacao] = aux;
            }
        }
    }

    Console.WriteLine("\n\nVetor ordenado utilizando BUBBLE SORT:");
    for (int i = 0; i < size_ordenado; i++)
    {
        Console.Write($"{ordenado[i]}  ");
    }


    //INVERTENDO
    //for (int referencia = size; referencia > 0; referencia--)
    //{
    //    for (int comparacao = referencia - 1; comparacao > 0; comparacao--)
    //    {
    //        if (ordenado[referencia] > ordenado[comparacao])
    //        {
    //            aux = ordenado[referencia];
    //            ordenado[referencia] = ordenado[comparacao];
    //            ordenado[comparacao] = aux;
    //        }
    //    }
    //}

    //Console.WriteLine("\n\nVetor invertido utilizando BUBBLE SORT:");
    //for (int i = 0; i < size; i++)
    //{
    //    Console.Write($"{ordenado[i]}  ");
    //}


    Console.WriteLine("\n\nReiniciar o ordenador?");
    Console.WriteLine("1 - SIM");
    Console.WriteLine("2 - NÃO");
    restart = int.Parse(Console.ReadLine());
} while (restart == 1);