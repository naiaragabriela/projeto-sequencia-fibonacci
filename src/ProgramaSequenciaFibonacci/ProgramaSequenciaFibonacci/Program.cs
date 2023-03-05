
int anterior, proximo, atual, posicao;

SequenciaFibonacci();

int BuscaPosicao()
{
    Console.Write("Informe até qual posição da sequência você deseja ver: ");
    return int.Parse(Console.ReadLine()); 
}

void SequenciaFibonacci()
{
    posicao = BuscaPosicao();
    anterior = 0;
    proximo = 1;
    atual = 1;

    for (int i = 1; i <= posicao; i++)
    {
        Console.Write(atual + ",");
        atual = proximo + anterior;
        anterior = proximo;
        proximo = atual;
    }
}