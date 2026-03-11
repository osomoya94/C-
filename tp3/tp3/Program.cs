Console.WriteLine("Ingrese el nombre del usuario, solo puede contener letras, nada de simbolos");
string usuario = Console.ReadLine();

while (!usuario.All(char.IsLetter))
{
    Console.WriteLine("El nombre del usuario no puede contener simbolos, solo letras. Ingrese nuevamente el nombre del usuario");
    usuario = Console.ReadLine();
}


Console.WriteLine("La contrasenia debe tener por lo menos un numero, una mayuscula, una minuscula, y un caracter especial");
string contrasenia = Console.ReadLine();

while (!contrasenia.Any(char.IsDigit) || !contrasenia.Any(char.IsUpper) || !contrasenia.Any(char.IsLower) || !contrasenia.Any(c => char.IsSymbol(c) || char.IsPunctuation(c)))
{
    Console.WriteLine("La contraseña no cumple con los requisitos. Ingrese nuevamente la contraseña");
    contrasenia = Console.ReadLine();
}



Console.WriteLine("El usuario y contrasenia se an creado con exito.");

