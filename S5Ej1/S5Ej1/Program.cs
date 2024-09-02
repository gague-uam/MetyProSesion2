using S5Ej1.models;

namespace S5Ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decir si es niño, joven o adulto
            /*
             * Niño: 0-12
             * Joven: 13-25
             * adulto: 26 a mas.
             */
            int edad = 0;
            Evaluate evaluate = new Evaluate();
            Console.WriteLine("Evaluar edad");
            Console.WriteLine("Ingrese su edad: ");
            try
            {
                edad = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(evaluate.EvalAge(edad));
            } catch (Exception ex) 
            {
                Console.WriteLine($"Error: {ex.ToString()}");
            }


            string message = evaluate.EvalAge(edad);
            Console.WriteLine(message);
        }
    }
}
