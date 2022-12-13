namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Introduzca dos números para sus operaciones");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca un número 1:Sumar | 2:Multiplicar | 3:Dividir | 4:Restar ---");
            option = Convert.ToInt32(Console.ReadLine());


            if (option == 1)
            {

            }
            else
            {
                if (option == 2)
                {

                }
                else
                {
                    if (option == 3)
                    {
                        int division = num1 / num2;
                        Console.WriteLine("La division de {0} y {1} da: {2}", num1, num2, division);
                    }
                    else
                    {
                        if (option == 4)
                        {
                            int resta = num1 - num2;
                            Console.WriteLine("La resta de {0} y {1} da: {2}",num1,num2,resta);
                        }
                        else
                        {
                            Console.WriteLine("Pues no hago nada");
                        }
                    }
                }
            }
        }
    }
}
