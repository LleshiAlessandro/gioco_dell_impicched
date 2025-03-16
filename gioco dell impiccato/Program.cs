using System;

Console.WriteLine("Ben venuto giocatore, questo e' il gioco dell impiccato.\n" +
    "Questo gioco consiste nell cercare di indovinare la parola con un massimo di errori.\n"+
    "Hai a disposizione di tre diffolta, facile(1), media(2) e difficile(3)'.\n" +
    "Buona fortuna giocatore e buon divertimento");
string difficolta = "";
int tentativo = 0;
Console.WriteLine("Che difficoltà scegli ?\n" +
    "facile(1), 15 tentativi\n" +
    "media(2), 10 tentativi\n" +
    "difficile(3), 5 tentativi");
difficolta = Console.ReadLine();
string trattino = " ";
string parolaTrovata = " ";
char[] lettere;
string parolaScelta = "";
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
    Console.WriteLine("I tuoi tentativi rimasti sono: " + tentativo);
}
//IDENTIFICO LA PAROLA SCELTA RANDOMICAMENTE DOPO LA DIFFICOLTA'
//aggiungere una if che controlla se la parola è stata trovata e in caso si aggiungere un for che crei una nuova parola
if (difficolta == "facile" || difficolta == "1")
{
    //Parole semplici
    tentativo = 15;
    string filePath1 = "parole_semplici.txt";
    string[] lines1 = File.ReadAllLines(filePath1); // Legge tutte le righe e le mette in un vettore
    Random rdn = new Random();
    int f = rdn.Next(lines1.Length);
    parolaScelta = lines1[f];
    trattino = new string('_', parolaScelta.Length);
    Console.WriteLine(trattino);
}
else if (difficolta == "media" || difficolta == "2")
{
    //Parole medie
    tentativo = 10;
    string filePath2 = "parole_medie.txt";
    string[] lines2 = File.ReadAllLines(filePath2); // Legge tutte le righe e le mette in un vettore
    Random rdn = new Random();
    int m = rdn.Next(lines2.Length);
    parolaScelta = lines2[m];
    trattino = new string('_', parolaScelta.Length);
    Console.WriteLine(trattino);
}
else if (difficolta == "difficile" || difficolta == "3")
{
    //Parole difficili
    tentativo = 5;
    string filePath3 = "parole_difficili.txt";
    string[] lines3 = File.ReadAllLines(filePath3); // Legge tutte le righe e le mette in un vettore
    Random rdn = new Random();
    int d = rdn.Next(lines3.Length);
    parolaScelta = lines3[d];
    trattino = new string('_', parolaScelta.Length);
    Console.WriteLine(trattino);
}
//tovare un modo per far si che quando si indovina una lettera venga scrutta ma le restanti no
while (tentativo > 0 && trattino.Contains("_"))
{
    Console.WriteLine("\nTentativi rimasti: " + tentativo);
    Console.Write("Indovina una lettera: ");
    char guessedLetter = char.ToLower(Console.ReadKey().KeyChar);
    Console.WriteLine();

    bool lettera_trovata = false;
    lettere = trattino.ToCharArray();

    for (int i = 0; i < parolaScelta.Length; i++)
    {
        if (parolaScelta[i] == guessedLetter && lettere[i] == '_')
        {
            lettere[i] = guessedLetter;
            lettera_trovata = true;
        }
    }

    trattino = new string(lettere);

    if (lettera_trovata)
    {
        Console.WriteLine("Parola attuale: " + trattino);
    }
    else
    {
        tentativo--;
        Console.WriteLine("Lettera non trovata.");
    }

    if (!trattino.Contains("_"))
    {
        Console.WriteLine("Hai indovinato la parola: " + parolaScelta);
        break;
    }
}

if (tentativo == 0)
{
    Console.WriteLine("Hai esaurito i tentativi. La parola era: " + parolaScelta);
}
