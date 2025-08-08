int contador = 0;
while (contador < 10000)
{
    Console.WriteLine("Loop: " + contador);

    if (contador > 9000)
    {
        break;
    }

    contador++;
}