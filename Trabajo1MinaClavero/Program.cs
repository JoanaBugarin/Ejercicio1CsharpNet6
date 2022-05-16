string respuesta = "S";
while (respuesta.ToUpper() == "S")
{
    Console.Clear();
    Console.Write("Por favor, ingrese su nombre: ");
    string nombre = Console.ReadLine();
    Console.WriteLine($"¡Hola {nombre}!");
    Console.Write("¿Deseas continuar? (S/N): ");
    respuesta = Console.ReadLine();
}
if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente");
}
else
{
    Console.WriteLine("Opcion no valida");
}
