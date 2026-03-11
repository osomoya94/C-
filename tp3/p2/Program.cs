int[] numeros = new int[100];
Random generarAletorio = new Random();
int numeroIngresado;
int contador = 0;

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = generarAletorio.Next(1, 101);
}


do
{
    Console.WriteLine("Ingrese un numero entre 1 y 100");
    numeroIngresado = int.Parse(Console.ReadLine());
}
while (numeroIngresado < 1 ||  numeroIngresado >= 101);

foreach (int numero in numeros)
{
    if (numero == numeroIngresado)
    {
        contador++;
    }
}

Console.WriteLine($"El numero {numeroIngresado} se repite {contador}");

//foreach (int numero in numeros)
//{
//    Console.WriteLine(numero);
//}
// Para verificar los numeros generados aleatoriamente.