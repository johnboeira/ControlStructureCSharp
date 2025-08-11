int contador = 0;
while (true)
{
    Console.WriteLine("Loop: " + contador);

    if (contador >= 9000)
    {
        break;
    }
    
    contador++;
}
Console.WriteLine("Saiu do while");