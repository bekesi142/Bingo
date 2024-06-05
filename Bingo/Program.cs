

using System.IO;
using System.Linq;
using Bingo;



internal class Program
{
    static List<BingoJatekos> lista = new List<BingoJatekos>();
    static List<string> randomSzamok = new List<string>();
    public static void Main(string[] args)
    {
        
        foreach (var item in File.ReadAllLines("Andi.txt"))
        {
           
            lista.Add(new BingoJatekos(item));


        }

        List<string> jatekosok = new List<string>();
        foreach (string x in File.ReadAllLines("nevek.text"))
        {
            jatekosok.Add(x);
        }

        Console.WriteLine("4. feladat: Játékosok száma: " + jatekosok.Count);

        
        Random random = new Random();
        int random1 = random.Next(1, 101);
        int random2 = random.Next(1, 101);
        int random3 = random.Next(1, 101);
        int random4 = random.Next(1, 101);
        int random5 = random.Next(1, 101);

        randomSzamok.Add(Convert.ToString(random1));
        randomSzamok.Add(Convert.ToString(random2));
        randomSzamok.Add(Convert.ToString(random3));
        randomSzamok.Add(Convert.ToString(random4));
        randomSzamok.Add(Convert.ToString(random5));

        
    }

    public bool BingoEll()
    {
        foreach (var szam in lista)
        {
            if (randomSzamok.Contains(szam))
            {

            }
        }

        return false;
    }
}