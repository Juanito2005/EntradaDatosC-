namespace EntradaDeDatosPorConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola que tal!!");
            ProcesadoDeDatos procesado = new ProcesadoDeDatos();
            string nombre = procesado.ValidarYPedirDatosNombre("Me podrías decir tu nombre por favor???:");
            int edad = procesado.ValidarYPedirDatosEdad("Ahora dime tu edad por favor:");
            int altura = procesado.ValidarYPedirDatosAltura("Cual es tu altura en centimetros??:");
            bool estudiante = procesado.ValidarYPedirDatosEstudiante("Por ultimo dime si eres un estudiante: \"Si\" para si o \"No\" para no");
            Console.WriteLine("la edad que tendrás en 5 años es: " + procesado.CalcularEdadDentroDeCincoAños(edad));
            Console.WriteLine("El doble de tu altura es: " + procesado.CalcularDobleAltura(altura));
            procesado.MostrarDatos(nombre, edad, altura, estudiante);

            Console.ReadLine();
        }
    }
}
