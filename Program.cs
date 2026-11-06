using System.IO;

string valasztas;
Console.WriteLine("[h]ozzáadás; [b]öngészés");
Console.Write("> ");
valasztas = Console.ReadLine();
if (valasztas == "H" ||
    valasztas == "h") {
    Console.WriteLine("[r]endszám; [i]gazolványszám");
    Console.Write("> ");
    valasztas = Console.ReadLine();
    if (valasztas == "r" ||
        valasztas == "R") {
        bool validRendszam = false;
        Console.Write("kérem a rendszámot > ");
        string rendszam = Console.ReadLine();
        if (rendszam.Length() == 7) {
            if (!rendszam.Substring(0, 3).Contains('-') &&
                !rendszam.Substring(4, 3).Contains('-')) {
                if (rendszam.Substring(0, 3).All(char.IsAsciiLetterUpper) &&
                    rendszam.Substring(4, 3).All(char.IsAsciiDigit)) {
                    validRendszam = true;
                }
            }
        }
    } else if (valasztas == "i" ||
               valasztas == "I") {
        // IDE CSINÁLD NIGABELLA
    }
} else if (valasztas == "B" ||
           valasztas == "b") {
    Console.Write("szia");
} else {
    Console.WriteLine("ismeretlen parancs");
}

// if (!File.Exists("db.csv")) {
//     File.Create("db.csv");
//     File.AppendText("tipus; azonosito; datum");
// } else {
//     foreach (string line in File.ReadAllText().Split('\n').Skip(1)) {
        
//     }
// }
