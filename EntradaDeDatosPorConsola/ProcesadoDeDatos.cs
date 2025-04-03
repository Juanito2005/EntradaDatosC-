using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaDeDatosPorConsola
{
    internal class ProcesadoDeDatos
    {
        public int CalcularEdadDentroDeCincoAños(int edad)
        {
            return edad + 5;
        }

        public int CalcularDobleAltura(int altura)
        {
            return altura*2;
        }

        public void MostrarDatos(string nombre, int edad, int altura, bool estudiante)
        {
            Console.WriteLine("Nombre: " + nombre + "\n" +
                              "Edad: " + edad + "\n" +
                              "Altura: " + altura + "\n" + 
                              "¿Es estudiante?: " + estudiante);    
        }

        public string ValidarYPedirDatosNombre(string mensaje)
        {
            while (true)
            {
                Console.WriteLine(mensaje);
                string nombre = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nombre) && nombre.All(c => char.IsLetter(c) || c == ' '))
                {
                    return nombre;
                }
                Console.WriteLine("Solo se permiten letras, no puedes escribir simbolos ni numeros");
            }
        }


        public int ValidarYPedirDatosEdad(string mensaje)
        {
            while (true)
            {
                Console.WriteLine(mensaje);
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int edad))
                {
                    if (edad < 7)
                    {
                        Console.WriteLine("Vamos a ver, no puedes tener menos de 7 años porque no sabrías leer");
                    }
                    else if (edad > 90)
                    {
                        Console.WriteLine("Si tienes más de 90, disfruta la vida en lugar de estudiar... ya te lo ganaste");
                    }
                    else
                    {
                        return edad;
                    }
                }
                else
                {
                    Console.WriteLine("Solo puedes escribir números enteros. Intenta nuevamente.");
                }
            }
        }

        public int ValidarYPedirDatosAltura(string mensaje)
        {
            while (true)
            {
                Console.WriteLine(mensaje);
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int altura))
                {
                    if (altura < 65)
                    {
                        Console.WriteLine("El record mundial de la persona mas bajita es de 65 cm, no creo que lo puedas superar");
                    }
                    else if (altura > 300)
                    {
                        Console.WriteLine("O me estas tomando de pelo o serás una super estrella NBA");
                    }
                    else
                    {
                        return altura;
                    }
                }
                else
                {
                    Console.WriteLine("Solo puedes escribir números enteros. Intenta nuevamente");
                }
            }
        }

        public bool ValidarYPedirDatosEstudiante(string mensaje)
        {
            while (true)
            {
                Console.WriteLine(mensaje);
                string input = Console.ReadLine();
                string respuesta = input.ToUpper();
                if (respuesta == "SI")
                {
                    return true;
                }
                else if (respuesta == "NO")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Solo puedes decir \"Si\" o \"No\"");
                }
            }
        }

    }
}
