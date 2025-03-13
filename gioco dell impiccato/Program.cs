Console.WriteLine("Ben venuto giocatore, questo e' il gioco dell impiccato.\n" +
    "Questo gioco consiste nell cercare di indovinare la parola con un massimo di errori.\n"+
    "Hai a disposizione di tre diffolta, facile(1), media(2) e difficile(3)'.\n" +
    "Buona fortuna giocatore e buon divertimento");
string difficolta = "";
int parola = 0;
Console.WriteLine("Che difficoltà scegli ? ");
difficolta = Console.ReadLine();
string parolaStr = parola.ToString();
string trattino = " ";
//CONTROLLO DIFFICOLTA':
for (int i = 0; i < 3; i++)
{
    if (difficolta == "facile" || difficolta == "1")
    {
        Console.WriteLine("hai scelto la difficolta' minima");
        i = 3;
    }
    else if (difficolta == "media" || difficolta == "2")
    {
        Console.WriteLine("hai scelto la difficolta' media");
        i = 3;
    }
    else if (difficolta == "difficile" || difficolta == "3")
    {
        Console.WriteLine("hai scelto la difficolta difficile");
        i = 3;
    }
    else
    {
        Console.WriteLine("la difficolta' che hai scelto non esiste. Riprova");
        i = 0;
        difficolta = Console.ReadLine();
    }
}
//IDENTIFICO LA PAROLA SCELTA RANDOMICAMENTE DOPO LA DIFFICOLTA'
if (difficolta == "facile" || difficolta == "1")
{
    //Parole semplici
    string filePath1 = "parole_semplici.txt";
    string[] lines1 = File.ReadAllLines(filePath1); // Legge tutte le righe e le mette in un vettore
    Random rdn = new Random();
    int f = rdn.Next(lines1.Length);
    parola = lines1[f].Length;
    trattino = new string('_', parola);
    Console.WriteLine(trattino);
}
else if (difficolta == "media" || difficolta == "2")
{
    //Parole medie
    string filePath2 = "parole_medie.txt";
    string[] lines2 = File.ReadAllLines(filePath2); // Legge tutte le righe e le mette in un vettore
    Random rdn = new Random();
    int m = rdn.Next(lines2.Length);
    parola = lines2[m].Length;
    trattino = new string('_', parola);
    Console.WriteLine(trattino);
}
else if (difficolta == "difficile" || difficolta == "3")
{
    //Parole difficili
    string filePath3 = "parole_difficili.txt";
    string[] lines3 = File.ReadAllLines(filePath3); // Legge tutte le righe e le mette in un vettore
    Random rdn = new Random();
    int d = rdn.Next(lines3.Length);
    parola = lines3[d].Length;
    trattino = new string('_', parola);
    Console.WriteLine(trattino);
}
