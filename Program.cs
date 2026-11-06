using System.IO;

if (!File.Exists("db.csv")) {
    File.WriteAllText("db.csv", "tipus; datum" + Environment.NewLine);
}

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
        Console.Write("rendszám > ");
        string rendszam = Console.ReadLine();
        if (rendszam.Count() == 7) {
            if (!rendszam.Substring(0, 3).Contains('-') &&
                !rendszam.Substring(4, 3).Contains('-')) {
                if (rendszam.Substring(0, 3).All(char.IsAsciiLetterUpper) &&
                    rendszam.Substring(4, 3).All(char.IsAsciiDigit)) {
                    validRendszam = true;
                }
            }
        }

        if (validRendszam) {
            if (!File.ReadAllText("db.csv").Contains($"rendszam; {rendszam}")) {
                using(StreamWriter sw = File.AppendText("db.csv")) {
                    sw.WriteLine($"rendszam; {rendszam}");
                }
            }

            DateTime DatumMost = DateTime.Now;
            File.AppendAllText($"{rendszam}.csv", DatumMost.ToString("yyyy.MM.dd HH:mm:ss") + Environment.NewLine);
        } else {
            Console.WriteLine("helytelen formátum");
        }
    } else if (valasztas == "i" ||
               valasztas == "I") {

        Console.Write("igazolványszám > ");
        string igszam = Console.ReadLine();

        if (igszam.Count() == 6) {

        }

        else {
            Console.WriteLine("helytelen formátum");
        }
        
    }
} else if (valasztas == "B" ||
           valasztas == "b") {
    Console.Write("szia");
} else {
    Console.WriteLine("ismeretlen parancs");
}

//foreach (string line in File.ReadAllText().Split('\n').Skip(1)) {
