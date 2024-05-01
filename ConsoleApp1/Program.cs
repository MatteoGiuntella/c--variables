// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ciao!");
Console.Write("Inserisci il tuo nome: ");
string name = Console.ReadLine();
Console.WriteLine("il tuo nome è" + " " + name);


 // Stringa con caratteri speciali
        string percorsoFile = "C:\\Documenti\\Immagini";
        string nuovaRiga = "Questa è una stringa con una nuova riga\n";
        string tabulazione = "\tQuesta è una stringa\t con una tabulazione";

        // Stringa verbatim
        string percorsoFileVerbatim = @"C:\Documenti\Immagini";

        // Output delle stringhe
        Console.WriteLine("Stringa con caratteri speciali:");
        Console.WriteLine(percorsoFile);
        Console.WriteLine(nuovaRiga);
        Console.WriteLine(tabulazione);

        Console.WriteLine("\nStringa con caratteri verbatim:");
        Console.WriteLine(percorsoFileVerbatim);



          // I parametri verranno passati dal mio codice di verifica come argomenti del metodo Main
            string nome = args[0];
            string soprannome = args[1];

            // Converti il nome in maiuscolo e salvalo in una variabile
            string nomeInMaiuscolo = nome.ToUpper();
            Console.WriteLine($"Nome in maiuscolo: {nomeInMaiuscolo}");

            // Converti il nome in minuscolo e salvalo in una variabile
            string nomeInMinuscolo = nome.ToLower();
            Console.WriteLine($"Nome in minuscolo: {nomeInMinuscolo}");

            // Stampa i risultati
            Console.WriteLine($"Ciao, il mio nome è {nome} ma puoi chiamarmi {soprannome}");
