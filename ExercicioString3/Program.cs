internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe o caracter a ser colocado antes de cada consoante de uma string");
        string a = Console.ReadLine();

        Console.WriteLine("Informe a string");
        string texto = Console.ReadLine();

        InsereChar(a, texto);

        void InsereChar(string a,string x)
        {
            string texto = "\0";


            for (int i = 0; i < x.Length; i++)
            {

                if ((x[i] == 'a') || (x[i] == 'e') || (x[i] == 'i') || (x[i] == 'o') || (x[i] == 'u'))
                {
                    texto += x[i];
                }
                else
                {
                    texto += a;
                    texto += x[i];
                }

            }
            Console.WriteLine($"A nova string é {texto}");
        }
    }
}