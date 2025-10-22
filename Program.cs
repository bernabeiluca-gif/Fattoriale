namespace Fattoriale;

class Program
{
    static bool Fattoriale(int n)
    {
        if(n%2==0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main(string[] args)
    {
        int somma = 0;
        for(int i=1; i<=10; i++)
        {
            if(Fattoriale==true)
            {
                somma = somma + Fattoriale();
            }
        }
        Console.WriteLine("La somma dei fattoriali dei numeri pari fino a 10 è " + somma);
    }
   
    
}
