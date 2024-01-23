namespace ejercicio2multiplos
{
    class program
    {
        public static void Main(String[] args)
        {
            int numero;
            do
            {
                Console.WriteLine("Indiqueme el numero del cual quieras saber los multiplos del 400 al 700");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 10)
                {
                    Console.WriteLine("Error");
                }
            } while (numero < 10);

            //Calculo de los multiplos
            int suma = 0;
            int j = 0;
            for (int i = 401; i < 700; i++)
            {
                Console.WriteLine($"{numero} * {i} = {numero * i}");
                suma = suma + (numero * i);
                j++;
            }
            Console.WriteLine($"La suma total es: {suma}");
            Console.WriteLine($"La media arimetrica es: {suma / j}");

        }
    }
}
