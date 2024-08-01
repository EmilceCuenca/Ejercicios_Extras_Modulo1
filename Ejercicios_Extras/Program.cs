Console.WriteLine("¡Hola!");
Console.WriteLine();
bool continuar = true;
do
{
    Console.WriteLine("MENÚ DE EJERCICIOS - ESTRUCTURAS DE CONTROL");
    Console.WriteLine();
    Console.WriteLine("Para ejecutar el ejercicio, seleccione el número correspondiente: ");
    Console.WriteLine();
    Console.WriteLine("1. Ejercicio N° 1: Valores Mayores a 100.");
    Console.WriteLine("2. Ejercicio N° 2: Pares e Impares.");
    Console.WriteLine("3. Ejercicio N° 3: Dobles de Números Impares.");
    Console.WriteLine("4. Ejercicio N° 4: Números Romanos.");
    Console.WriteLine("5. Ejercicio N° 5: El más joven.");
    Console.WriteLine("6. Ejercicio N° 6: Triángulos.");
    Console.WriteLine("7. Ejercicio N° 7: Desglose de Dinero.");
    Console.WriteLine("8. Ejercicio N° 8: Secuencia de Números.");
    Console.WriteLine("9. Ejercicio N° 9: Suma de Quince números.");
    Console.WriteLine("10. Ejercicio N° 10: Múltiplos de 3.");
    Console.WriteLine("11. Ejercicio N° 11: Contraseñas.");
    Console.WriteLine("12. Ejercicio N° 12: Contraseñas Limitadas.");
    Console.WriteLine("0. Finalizar.");
    Console.WriteLine();
    int[] opciones = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 0 };
    bool opc_valida = int.TryParse(Console.ReadLine(), out int opcion);
    while (!opc_valida || !Array.Exists(opciones,op => op == opcion))
    {
        Console.WriteLine("Elección no válida. Por favor seleccíone un número del menú. ");
        opc_valida = int.TryParse(Console.ReadLine(), out opcion);
    }
    Console.Clear(); 
    switch (opcion)
    {
        case 1:
            Ejercicio1();
            break;
        case 2:
            Ejercicio2();
            break;
        case 3: 
            Ejercicio3();
            break;
        case 4:
           Ejercicio4();
            break;
        case 5:
            Ejercicio5();
            break;
        case 6:
            Ejercicio6();
            break;
        case 7:
            Ejercicio7();
            break;
        case 8:
            Ejercicio8();
            break;
        case 9:
            Ejercicio9();
            break;
        case 10:
            Ejercicio10();
            break;
        case 11:
            Ejercicio11();
            break;
        case 12:
            Ejercicio12();
            break;
        case 0 :
            continuar = false;
            Console.WriteLine("Gracias¡Hasta pronto!");
            break;
    }
}
while (continuar == true);
string? Regresar()
{
    string? tecla;
    Console.WriteLine("Para volver a intentar el ejercicio, presionar la tecla 1.");
    Console.WriteLine("Para volver al menú principal, presionar cualquier otra ");
    tecla = Console.ReadKey().KeyChar.ToString();
    Console.Clear();
    return tecla;
}
int ObtenerNumero(string texto)
{
    Console.WriteLine("Por favor," + texto + ".");
    bool es_valido = int.TryParse(Console.ReadLine(), out int numero);
    while (!es_valido)
    {
        Console.WriteLine("Dato no válido. Por favor, " + texto + " .");
        es_valido = int.TryParse(Console.ReadLine(), out numero);
    }
    return numero;
}
string Contraseña()
{
    string contraseña = "";
    ConsoleKeyInfo caracter;
    while (contraseña.Length <= 16)
    {
        caracter = Console.ReadKey(true);
        if (caracter.Key != ConsoleKey.Backspace && caracter.Key != ConsoleKey.Enter)
        {
            contraseña += caracter.KeyChar;
            Console.Write("*");
        }
        else if (caracter.Key == ConsoleKey.Backspace && contraseña.Length > 0)
        {
            contraseña = contraseña.Substring(0, (contraseña.Length - 1));
            Console.Write("\b \b");
        }
        else if (caracter.Key == ConsoleKey.Enter)
        {
            break;
        }
    }
    Console.WriteLine();
    return contraseña;
}
void Ejercicio1()
{
    string? tecla;
    do
    {
        Console.WriteLine("EJERCICIO N° 1: Valores Mayores a 100.");
        Console.WriteLine();
        Console.WriteLine("Introduce un número entero y te diré si este valor es mayor que 100.");
        Console.WriteLine();
        string texto = "ingresa un número";
        int numero = ObtenerNumero(texto);
        if (numero > 100)
        {
            Console.WriteLine("El valor es mayor que 100");
        }
        Console.WriteLine();
        tecla = Regresar();
    }
    while (tecla == "1");
}
void Ejercicio2()
{
    string? tecla;
    do
    {
        Console.WriteLine("EJERCICIO N° 2: Pares e Impares.");
        Console.WriteLine();
        Console.WriteLine("Introduce un número entero y te diré si es par o impar.");
        Console.WriteLine();
        string texto = "ingresa un número entero";
        int numero = ObtenerNumero(texto);
        if (numero % 2 == 0)
        {
            Console.WriteLine("El número " + numero + " es par.");
        }
        else
        {
            Console.WriteLine("El número " + numero + " es impar.");
        }
        Console.WriteLine();
        tecla = Regresar();
    }
    while (tecla == "1");
}
void Ejercicio3()
{
    string? tecla;
    do
    {
        Console.WriteLine("EJERCICIO N° 3: Dobles de Números Impares.");
        Console.WriteLine();
        Console.WriteLine("Introduce un número entero y te diré si es el doble de un número impar.");
        Console.WriteLine();
        string texto = "ingresa un número entero";
        int numero = ObtenerNumero(texto);
        int mitad = numero / 2;
        if (mitad % 2 == 0)
        {
            Console.WriteLine("El número " + numero + " no es doble de un número impar.");
        }
        else
        {
            Console.WriteLine("El número " + numero + " es doble de un número impar.");
        }
        Console.WriteLine();
        tecla = Regresar();
    }
    while (tecla == "1");
}
void Ejercicio4()
{
    string? tecla;
    do
    {
        Console.WriteLine("EJERCICIO N° 4: Números Romanos.");
        Console.WriteLine();
        Console.WriteLine("Introduce un número del 1 al 10 y te mostraré su equivalente en números romanos.");
        Console.WriteLine();
        Console.WriteLine("Por favor, ingrese un número del 1 al 10");
        int[] num_1_10 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        string[] num_romanos = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
        bool dato = int.TryParse(Console.ReadLine(), out int numero);
        while (!dato || !Array.Exists(num_1_10, n => n == numero))
        {
            Console.WriteLine("Dato no válido. Por favor, ingrese un número del 1 al 10");
            dato = int.TryParse(Console.ReadLine(), out numero);
        }
        Console.WriteLine("El número " + numero + " es " + num_romanos[numero - 1] + " en romano.");
        Console.WriteLine();
        tecla = Regresar();

    }
    while (tecla == "1");
}
void Ejercicio5()
{
    string? ObtenerNombre(string posicion)
    {
        Console.WriteLine("Por favor, ingresa el " + posicion + " nombre:");
        string? nombre = Console.ReadLine();
        return nombre;
    }
    int ObtenerEdad()
    {
        string texto = "ingrese su edad";
        int edad = ObtenerNumero(texto);
        return edad;
    }
    string? tecla;
    do
    {
        Console.WriteLine("EJERCICIO N° 5: El más joven.");
        Console.WriteLine();
        Console.WriteLine("Introduce el nombre y la edad de dos personas. " +
            "Te diré quién es el menor y te indicaré la diferencia de edad si es necesario.");
        Console.WriteLine();
        string? nombre_1 = ObtenerNombre("primer");
        int edad_1 = ObtenerEdad();
        string? nombre_2 = ObtenerNombre("segundo");
        int edad_2 = ObtenerEdad();
        if (edad_1 < edad_2)
        {
            Console.WriteLine(nombre_1 + " es más joven que " + nombre_2);
            Console.WriteLine("La diferencia de edad entre ambos es de " + int.Abs(edad_1 - edad_2) + " años.");
        }
        else if (edad_2 < edad_1)
        {
            Console.WriteLine(nombre_2 + " es más joven que " + nombre_1);
            Console.WriteLine("La diferencia de edad entre ambos es de " + int.Abs(edad_1 - edad_2) + " años.");
        }
        else
        {
            Console.WriteLine(nombre_1 + " y " + nombre_2 + " tienen la misma edad.");
        }
        tecla = Regresar();

    }
    while (tecla == "1");
}
void Ejercicio6()
{
    double ObtenerLado(string posicion)
    {
        Console.WriteLine("Por favor, ingrese la longitud del " + posicion + " lado.");
        bool dato = double.TryParse(Console.ReadLine(), out double lado);
        while (!dato)
        {
            Console.WriteLine("Dato no válido. Por favor, intente de nuevo.");
            dato = double.TryParse(Console.ReadLine(), out lado);
        }
        return lado;
    }
    bool esIsoceles(double lado_1, double lado_2, double lado_3)
    {
        bool esIsoceles =
            (lado_1 == lado_2 && lado_2 != lado_3) ||
            (lado_1 == lado_3 && lado_3 != lado_2) ||
            (lado_2 == lado_3 && lado_3 != lado_1);
        return esIsoceles;
    }
    double Perimetro(double lado_1, double lado_2, double lado_3)
    {
        double perimetro = (lado_1 + lado_2 + lado_3);
        return perimetro;
    }
    double Area(double lado_1, double lado_2, double lado_3)
    {
        double s = (lado_1 + lado_2 + lado_3) / 2;
        double area = Math.Sqrt(s * (s - lado_1) * (s - lado_2) * (s - lado_3));
        return area;
    }
    string? tecla;
    do
    {
        Console.WriteLine("EJERCICIO N° 6: Triangulos.");
        Console.WriteLine();
        Console.WriteLine("Conociendo las longitudes de los lados de un triángulo, podemos determinar su tipo.");
        Console.WriteLine("Ingresa las longitudes de los tres lados de un triángulo. " +
            "Te diré qué tipo de triángulo es y calcularé su perímetro y área si así lo deseas.");
        Console.WriteLine();
        double lado_1 = ObtenerLado("primer");
        double lado_2 = ObtenerLado("segundo");
        double lado_3 = ObtenerLado("tercer");
        while (lado_1 >= (lado_2 + lado_3) || lado_2 >= (lado_1 + lado_3) || lado_3 >= (lado_1 + lado_2))
        {
            Console.WriteLine("Las longitudes proporcionadas no pueden formar un triángulo.");
            lado_1 = ObtenerLado("primer");
            lado_2 = ObtenerLado("segundo");
            lado_3 = ObtenerLado("tercer");
        }
        if (lado_1 == lado_2 && lado_2 == lado_3)
        {
            Console.WriteLine("El triángulo es equilatero, ya que sus tres lados son iguales.");
        }
        else if (esIsoceles(lado_1, lado_2, lado_3))
        {
            Console.WriteLine("El triángulo es isóceles, ya que tiene dos lados iguales y uno desigual.");
        }
        else
        {
            Console.WriteLine("El triángulo es escaleno, ya que sus tres lados son diferentes.");
        }
        Console.WriteLine("Para conocer su perimetro presione 1.");
        Console.WriteLine("Para conocer su área presione 2.");
        string? respuesta = Console.ReadLine();
        if (respuesta == "1")
        {
            double perimetro = Perimetro(lado_1, lado_2, lado_3);
            Console.WriteLine("El perimetro del triángulo es " + perimetro + ".");
        }
        else if (respuesta == "2")
        {
            double area = Area(lado_1, lado_2, lado_3);
            Console.WriteLine("El area del triángulo es " + double.Round(area, 3) + ".");
        }
        tecla = Regresar();
    }
    while (tecla == "1");
}
void Ejercicio7()
{
    string? tecla;
    do
    {
        Console.WriteLine("EJERCICIO N° 7: Desglose de Dinero.");
        Console.WriteLine();
        Console.WriteLine("Ingresa una cantidad de dinero y " +
            "te mostraré su desglose en billetes y monedas para que se minimice la cantidad total de piezas.");
        Console.WriteLine();
        string? texto = " ingrese el monto de dinero a desglosar.";
        Console.WriteLine();
        int cantidad = ObtenerNumero(texto);
        int[] denominaciones = {1000, 500, 100, 50, 20, 10, 5, 2, 1};
        foreach(int denominacion in denominaciones)
        {
            int cant_efectivo = cantidad / denominacion;
            if (cant_efectivo > 0)
            {
                if (denominacion > 5)
                {
                    if (cant_efectivo > 1)
                    {
                        Console.WriteLine(cant_efectivo + " billetes de $" + denominacion);
                    }
                    else
                    {
                        Console.WriteLine(cant_efectivo + " billete de $" + denominacion);
                    }
                }
                else
                {
                    if (cant_efectivo > 1)
                    {
                        Console.WriteLine(cant_efectivo + " monedas de $" + denominacion);
                    }
                    else
                    {
                        Console.WriteLine(cant_efectivo + " moneda de $" + denominacion);
                    }
                }
                cantidad %= denominacion;
            }
        }
        tecla = Regresar();
    } while (tecla == "1");
}
void Ejercicio8()
{
    string? tecla;
    do
    {
        Console.WriteLine("8. EJERCICIO N° 8: Secuencia de Números.");
        Console.WriteLine();
        Console.WriteLine("Ingresa un número entero y te mostraré " +
            "una lista con todos los números desde el 1 hasta ese número, uno por uno.");
        Console.WriteLine();
        string texto = "ingrese un número";
        int numero = ObtenerNumero(texto);
        for (int i = 1; i <= numero; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
        tecla = Regresar();
    }
    while (tecla == "1");
}
void Ejercicio9()
{
    string? tecla;
    do
    {
        Console.WriteLine("9. EJERCICIO N° 9: Suma de Quince Números.");
        Console.WriteLine();
        Console.WriteLine("Introduce 15 números enteros, uno por uno y" +
            " calcularé la suma total de los números introducidos.");
        Console.WriteLine();
        int suma_total = 0;
        for (int i = 1; i <= 15; i++)
        {
            string texto = "ingresa el " + i + "° número";
            int numero = ObtenerNumero(texto);
            suma_total += numero;
            Console.Clear();
        }
        Console.WriteLine("La suma total es " + suma_total);
        Console.WriteLine();
        tecla = Regresar();
    }
    while (tecla == "1");
}
void Ejercicio10()
{
    string? tecla;
    do
    {
        Console.WriteLine("EJERCICIO N° 10: Múltiplos de 3.");
        Console.WriteLine();
        Console.WriteLine("Introduce cinco números enteros y te diré si alguno de ellos es múltiplo de 3.");
        Console.WriteLine();
        int[] numeros =[];
        for (int i = 0; i < 5; i++)
        {
            string texto = "ingresa un número entero";
            int numero = ObtenerNumero(texto);
            numeros = [..numeros, numero];
        }
        Console.WriteLine();
        foreach (int nro in numeros)
        {
            if (nro%3== 0)
            {
                Console.WriteLine("El número "+nro+" es múltiplo de 3");
            }
        }
        Console.WriteLine();
        tecla = Regresar();
    }
    while(tecla == "1");
}
void Ejercicio11()
{
     string? tecla;
    do
    {
        Console.WriteLine("EJERCICIO N° 11: Contraseñas.");
        Console.WriteLine();
        Console.WriteLine("Ingresa una contraseña (de hasta 16 caracteres). Luego, vuelve a ingresarla." +
            " Te confirmaré si ambas contraseñas coinciden o no.");
        Console.WriteLine();
        Console.WriteLine("Por favor, ingrese una contraseña.");
        string contraseña_1 = Contraseña();
        Console.WriteLine("Por favor, ingrese nuevamente la contraseña.");
        string contraseña_2 = Contraseña();
        while (contraseña_1 != contraseña_2)
        {
            Console.WriteLine("Las contraseñas no coinciden. Por favor, intente de nuevo.");
            contraseña_2 = Contraseña();
        }
        Console.WriteLine("Las contraseñas coinciden.");
        Console.WriteLine();
        tecla = Regresar();
    }
    while (tecla == "1");
}
void Ejercicio12()
{
    string? tecla;
    do
    {
        Console.WriteLine("EJERCICIO N° 12: Contraseñas Limitadas.");
        Console.WriteLine();
        Console.WriteLine("Ingresa una contraseña (de hasta 16 caracteres). Luego, vuelve a ingresarla." +
            " Te confirmaré si ambas contraseñas coinciden o no. Después de tres intentos fallidos, terminaré el proceso.");
        Console.WriteLine();
        Console.WriteLine("Por favor, ingrese una contraseña (de hasta 16 caracteres).");
        string contraseña_1 = Contraseña();
        Console.WriteLine("Por favor, ingrese nuevamente la contraseña.");
        string contraseña_2 = Contraseña();
        for (int i = 1; i<3; i++)
        {
            if (contraseña_1 != contraseña_2)
            {
                Console.WriteLine("Las contraseñas no coinciden. Por favor, intente de nuevo.");
                Console.WriteLine("(Tenga en cuenta que le quedan "+(3-i)+" intentos)");
                contraseña_2 = Contraseña();
            }
            else
            {
                Console.WriteLine("Las contraseñas coinciden.");
                break;
            }
        }
        Console.WriteLine("Ha superado el número de intentos.");
        Console.WriteLine();
        tecla = Regresar();
    }
    while (tecla == "1");
}
