namespace P00I_Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Filmacion filmacion = new Filmacion();
            filmacion.codigo = 1000;
            filmacion.titulo = "Facebook";
            filmacion.minutos = 60;
            filmacion.precio_soles = 150;

            Console.WriteLine("Su codigo es: "+ filmacion.codigo);
            Console.WriteLine("Su titulo es: " + filmacion.titulo);
            Console.WriteLine("Tiene: " + filmacion.minutos + " minutos");
            Console.WriteLine("Su precio en soles es: " + filmacion.precio_soles);
            Console.WriteLine("Su precio en dolares es: " + filmacion.calculatePriceDollars());
            Console.WriteLine("");

            Persona persona = new Persona();
            persona.nombre = "Paul";
            persona.apellido = "Fuentes";
            persona.edad = 25;
            persona.estatura = 1.70;
            persona.peso = 85;

            Console.WriteLine("Mi nombre completo es: " + persona.nombre + " " + persona.apellido);
            Console.WriteLine("Tengo: " + persona.edad + "años");
            Console.WriteLine("Mido: " + persona.estatura + "m");
            Console.WriteLine("Peso: " + persona.peso + "kg");
            Console.WriteLine("Mi masa corporal es: " + persona.calculateBodyMass());
            Console.WriteLine("");

            Coordinador coordinador = new Coordinador();
            coordinador.codigo = 2000;
            coordinador.nombre = "Juan";
            coordinador.categoria = 2;
            coordinador.celular = 951487534;

            Console.WriteLine("Su codigo es: " + coordinador.codigo);
            Console.WriteLine("El nombre del coordinador es: " + coordinador.nombre);
            Console.WriteLine("La categoria del coordinador es: " + coordinador.categoria);
            Console.WriteLine("Su numero de celular es: " + coordinador.celular);
            Console.WriteLine("Su sueldo es: " + coordinador.calculateSalaryByCategory());


            Console.ReadKey();
        }
    }
}


