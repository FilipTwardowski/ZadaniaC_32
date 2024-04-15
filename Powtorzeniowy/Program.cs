using Powtorzeniowy;

class PlikGłówny 
{
    
    static void Main(string[] args) 
    {
        //zmienna, która jest odwołaniem do innego skryptu
        tablice tablice = new tablice();

        int[] tab = tablice.Tworzenie_tablicy();

        for (int i = 0; i < tab.Length; i++) 
        {
            Console.WriteLine(tab[i]);  
        }
    }
}