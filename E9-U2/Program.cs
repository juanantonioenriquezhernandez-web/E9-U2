Console.WriteLine("SISTEMA DE MEDICIONES DE MOTORES");
Console.WriteLine();

// Crear un objeto de la clase 
Motor motor1 = new Motor();

// Capturar la información del objeto 
Console.Write("Ingrese el nombre del motor: ");
motor1.Nombre = Console.ReadLine() ?? "Sin nombre";

// Uso del método de lectura segura para evitar errores al ingresar números
motor1.Temperatura = LeerDouble("Ingrese la temperatura: ");
motor1.Corriente = LeerDouble("Ingrese la corriente: ");
motor1.Velocidad = LeerDouble("Ingrese la velocidad: ");

// Mostrar resultados
Console.WriteLine();
Console.WriteLine($"Nombre del motor: {motor1.Nombre}");
Console.WriteLine($"Temperatura: {motor1.Temperatura:F2}");
Console.WriteLine($"Corriente: {motor1.Corriente:F2}");
Console.WriteLine($"Velocidad: {motor1.Velocidad:F2}");
Console.WriteLine($"Evaluación de Temperatura: {motor1.CalcularTemperatura()}");
Console.WriteLine($"Estado: {motor1.ObtenerEstado()}");


// Método auxiliar para validar que la entrada sea un número
static double LeerDouble(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();
        if (double.TryParse(input, out double value))
            return value;

        Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
    }
}


// Definición de la clase
class Motor
{
    // Propiedades
    public string Nombre { get; set; } = "";

    public double Temperatura { get; set; }

    public double Corriente { get; set; }

    public double Velocidad { get; set; }

    // Método para evaluar la temperatura
    public string CalcularTemperatura()
    {
        if (Temperatura > 70)
        {
            return "Advertencia: La temperatura del motor es mayor a 70 °C.";
        }
        else
        {
            return "Temperatura dentro del rango normal (menor o igual a 70 °C).";
        }
    }

    // Método para determinar el estado de marcha del motor
    public string ObtenerEstado()
    {
        if (Corriente >= 0.5 && Velocidad >= 1)
        {
            return "El motor está en marcha";
        }
        else
        {
            return "El motor está detenido";
        }
    }
}