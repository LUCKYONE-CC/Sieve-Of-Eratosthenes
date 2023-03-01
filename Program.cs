namespace Sieb_des_Eratosthenes
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach(var item in SieveOfEratosthenes(1000000))
            {
                Console.WriteLine(item);
            }
        }
        public static List<int> SieveOfEratosthenes(int n)
        {
            bool[] prime = new bool[n + 1];

            for (int i = 0; i < n + 1; i++)
            {
                prime[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                if (prime[p] == true)
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        prime[i] = false;
                    }
                }
            }

            List<int> primes = new List<int>();

            for (int p = 2; p <= n; p++)
            {
                if (prime[p] == true)
                {
                    primes.Add(p);
                }
            }

            return primes;
        }

    }
}