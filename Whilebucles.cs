

using System;
using System.Security.Claims;

namespace Bucleswhile
{
    public class Whilebucles
    {
        public void Clasesdehoy()
        {
           
                int valor = 0;
                int contador = 0;
                int suma = 0;
                decimal promedio;

            try
            {
                while (contador < 10)
                {
                    Console.Write("Ingrese un valor: ");
                    valor = Convert.ToInt32(Console.ReadLine());
                    suma = suma + valor;

                    contador++;
                }


                promedio = (decimal)suma / 10;


                Console.WriteLine($"La suma de los valores ingresados es:  {suma} ");
                Console.WriteLine($"El promedio de los valores ingresados es: {promedio} ");
            } catch (Exception ex) 
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");

            }
        }

        public void Clasesdehoy2()
        {


            int cantidadPiezas = 0;
            decimal longitud = 0;
            int contadorPiezasAptas = 0;
            int contador = 0;

            try
            {
                Console.Write("Ingrese la cantidad de piezas a procesar: ");
                cantidadPiezas = Convert.ToInt32(Console.ReadLine());


                while (contador < cantidadPiezas)
                {

                    Console.Write("Ingrese la longitud de la pieza " + (contador + 1) + " en metros: ");
                    longitud = Convert.ToDecimal(Console.ReadLine());


                    if (longitud is >= (decimal)1.20 and <= (decimal)1.30)
                    {
                        contadorPiezasAptas++;
                    }

                    contador = contador + 1;
                }


                Console.WriteLine($"La cantidad de piezas aptas en el lote es:   {contadorPiezasAptas} ");

            } catch (Exception ex) 
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");
            }

                
            
        

        }

        public void Clasesdehoy3()
        {

            int contador = 0;
            int notasMayoresOIgualesA7 = 0;
            int notasMenoresA7 = 0;
            int nota = 0;

            try
            {
                while (contador < 10)
                {
                    Console.Write($"Ingrese la nota del alumno {contador + 1}: ");
                    nota = Convert.ToInt32(Console.ReadLine());


                    if (nota >= 7)
                    {
                        notasMayoresOIgualesA7 = notasMayoresOIgualesA7 + 1;
                    }
                    else
                    {
                        notasMenoresA7 = notasMenoresA7 + 1;
                    }

                    contador++;
                }
                Console.WriteLine($"Cantidad de alumnos con notas mayores o iguales a 7:  {notasMayoresOIgualesA7} ");
                Console.WriteLine($"Cantidad de alumnos con notas menores a 7:  {notasMenoresA7}");
            }
            
            catch (Exception ex) 
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");

            }
                
            
        }

        public void Clasesdehoy4() 
        {
            


        
       
                // Declaración de variables
                int contador = 0;
                int empleadosEntre100y300 = 0;
                int empleadosMasDe300 = 0;
                int totalSueldos = 0;

            try
            {
                Console.Write("Ingrese la cantidad de empleados: ");
                int cantidadEmpleados = Convert.ToInt32(Console.ReadLine());

                while (contador < cantidadEmpleados)
                {

                    Console.Write($"Ingrese el sueldo del empleado{contador + 1}: ");
                    int sueldo = Convert.ToInt32(Console.ReadLine());


                    if (sueldo >= 100 && sueldo <= 300)
                    {
                        empleadosEntre100y300 = empleadosEntre100y300 + 1;
                    }
                    else if (sueldo > 300)
                    {
                        empleadosMasDe300 = empleadosMasDe300 + 1;
                    }


                    totalSueldos = totalSueldos + sueldo;

                    contador = contador + 1;
                }
                Console.WriteLine($"Empleados que cobran entre $100 y $300:  {empleadosEntre100y300} ");
                Console.WriteLine($"Empleados que cobran más de $300:  {empleadosMasDe300} ");
                Console.WriteLine($"Importe total que gasta la empresa en sueldos: {totalSueldos}");

            }catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");

            }
        }


    }
}

