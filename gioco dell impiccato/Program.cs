using System;
using System.Runtime.CompilerServices;

Console.WriteLine("Ben venuto giocatore, questo e' il gioco dell impiccato.\n" +
    "Questo gioco consiste nell cercare di indovinare la parola con un massimo di errori.\n" +
    "Puoi scegliere delle parole a tema, hai la possibilita' di fare una modalita' normale(1) con parole randomiche\n" +
    "oppure puoi scegliere solo cibi(2), solo lavori(3) oppure solo animali(4)\n" +
    "Hai a disposizione di tre diffolta, facile(1), media(2) e difficile(3)'.\n" +
    "Buona fortuna giocatore e buon divertimento");
string difficolta = "";
Console.WriteLine();
Console.WriteLine("se hai scelto cibi, lavori o animali\n" +
                  "hai a disposizione 7 tentativi");
Console.WriteLine();
string argomento = Console.ReadLine();
string trattino = " ";
char[] lettere;
string parolaScelta = "";
string lettere_mem = " ";
int tentativo = 0;
int punti = 0, somma = 0;
string parola_piena = "";
string prova = "";
//CONTROLLO DIFFICOLTA' E PAROLE A TEMA:
for (int j = 0; j < 1; j++)
{
    if (argomento == "normale" || argomento == "1")
    {
        Console.WriteLine("Che difficoltà scegli ?\n" +
        "facile(1), 15 tentativi\n" +
        "media(2), 10 tentativi\n" +
        "difficile(3), 5 tentativi");
        difficolta = Console.ReadLine();
        //DIFFICOLTA'
        for (int i = 0; i < 3; i++)
        {
            if (difficolta == "facile" || difficolta == "1")
            {
                Console.WriteLine("hai scelto la difficolta' minima");
                i = 3;
                j = 1;
            }
            else if (difficolta == "media" || difficolta == "2")
            {
                Console.WriteLine("hai scelto la difficolta' media");
                i = 3;
                j = 1;
            }
            else if (difficolta == "difficile" || difficolta == "3")
            {
                Console.WriteLine("hai scelto la difficolta difficile");
                i = 3;
                j = 1;
            }
            else
            {
                Console.WriteLine("la difficolta' che hai scelto non esiste. Riprova");
                i = 0;
                j = 0;
                difficolta = Console.ReadLine();
            }
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
        }
    }
    else if (argomento == "cibi" || argomento == "2")
    {
        Console.WriteLine("l'argomento che hai scelto è: cibi");
        tentativo = 7;
        string filePath4 = "cibi.txt";
        string[] lines4 = File.ReadAllLines(filePath4); // Legge tutte le righe e le mette in un vettore
        Random rdn = new Random();
        int c = rdn.Next(lines4.Length);
        parolaScelta = lines4[c];
        trattino = new string('_', parolaScelta.Length);
        j = 1;
    }
    else if (argomento == "lavori" || argomento == "3")
    {
        Console.WriteLine("l'argomento che hai scelto è: lavori");
        tentativo = 7;
        string filePath5 = "lavori.txt";
        string[] lines5 = File.ReadAllLines(filePath5); // Legge tutte le righe e le mette in un vettore
        Random rdn = new Random();
        int l = rdn.Next(lines5.Length);
        parolaScelta = lines5[l];
        trattino = new string('_', parolaScelta.Length);
        j = 1;
    }
    else if (argomento == "animali" || argomento == "4")
    {
        Console.WriteLine("l'argomento che hai scelto è: animali");
        tentativo = 7;
        string filePath5 = "animali.txt";
        string[] lines5 = File.ReadAllLines(filePath5); // Legge tutte le righe e le mette in un vettore
        Random rdn = new Random();
        int a = rdn.Next(lines5.Length);
        parolaScelta = lines5[a];
        trattino = new string('_', parolaScelta.Length);
        j = 1;
    }
    else
    {
        Console.WriteLine("questo argomento non esiste. Riprova");
        j = 0;
        argomento = Console.ReadLine();
    }
    Console.WriteLine("I tuoi tentativi rimasti sono: " + tentativo);
    Console.Write(trattino);
    Console.WriteLine("(" + trattino.Length + ")");
}
//CICLO CHE STAMPA LE LETTERE INDOVINATE
while (tentativo > 0 && trattino.Contains("_"))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nTentativi rimasti: " + tentativo);
    Console.WriteLine();
    Console.Write("Indovina una lettera: ");
    char lettera_indovinata = char.ToLower(Console.ReadKey().KeyChar);
    Console.WriteLine();
    lettere_mem += lettera_indovinata + "-";
    Console.WriteLine("le lettere che hai inserito sono:" + lettere_mem);
    Console.WriteLine();
    bool lettera_trovata = false;

    lettere = new char[trattino.Length];  // Creo un array di caratteri con la stessa lunghezza della stringa
    for (int i = 0; i < trattino.Length; i++)
    {
        lettere[i] = trattino[i];  // Copio ogni carattere di trattino nell'array lettere
    }

    for (int i = 0; i < parolaScelta.Length; i++)
    {
        if (parolaScelta[i] == lettera_indovinata && lettere[i] == '_')
        {
            lettere[i] = lettera_indovinata;
            lettera_trovata = true;
        }
    }

    trattino = new string(lettere);  // Ricostruisco la stringa trattino data la variabile lettere
    //RIEMPIMENTO PAROLA
    if (lettera_trovata)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Parola attuale: " + trattino);
    }
    else
    {
        tentativo--;
        Console.WriteLine("Lettera non trovata.");
    }
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Se hai capito qual' e' la parola giusta prova a indovinarla tutta di fila.\n" +
                      "Ma fai attenzione perche in caso tu sbagliassi avrai perso\n" +
                      "e i tuoi tentativi verranno azzerati\n" +
                      "In caso tu volessi prova scrivi si, se non vuoi rischiare scrivi no");
    prova = Console.ReadLine();
    if (prova == "si" || prova == "SI")
    {
        Console.WriteLine("prova pure");
        parola_piena = Console.ReadLine();
        if (trattino.Contains("_"))
        {
            Console.WriteLine("Hai vinto sei riuscito a indovinare la parola complimenti!!!");
            Console.ForegroundColor = ConsoleColor.Green;
            trattino = parolaScelta;
        }
        else
        {
            Console.WriteLine("Oh no, hai sbagliato parola. Peccato la prossima volta ragionaci di piu'");
            tentativo = 0;
        }
    }
    else if (prova == "no" || prova == "NO")
    {

    }
    //PUNTEGGIO
    if (difficolta == "facile" || difficolta == "1" && !trattino.Contains("_"))
    {
        punti = 5;
    }
    else if (difficolta == "media" || difficolta == "2" && !trattino.Contains("_"))
    {
        punti = 10;
    }
    else if (difficolta == "difficile" || difficolta == "3" && !trattino.Contains("_"))
    {
        punti = 15;
    }
    if (argomento == "cibi" || argomento == "2" && !trattino.Contains("_"))
    {
        punti = 10;
    }
    else if (argomento == "lavori" || argomento == "3" && !trattino.Contains("_"))
    {
        punti = 10;
    }
    else if (argomento == "animali" || argomento == "4" && !trattino.Contains("_"))
    {
        punti = 10;
    }
    
    //PAROLA FINALE
    if (!trattino.Contains("_"))
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Hai indovinato la parola: " + parolaScelta);
        somma += punti;
        Console.WriteLine("Hai totalizzato un certo numero di punti: " + somma);
    }

}

Console.ForegroundColor = ConsoleColor.White;
if (tentativo == 0)
{
    Console.WriteLine("Hai esaurito i tentativi. La parola era: " + parolaScelta);
}