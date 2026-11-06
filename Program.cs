using System.IO;
HashSet<char> betuk = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
HashSet<char> szamok = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];

string valasztas;
Console.WriteLine("[h]ozzáadás [b]öngészés");
Console.Write("> ");
valasztas = Console.ReadLine();
if (valasztas == "H" || valasztas == "h") {
    Console.WriteLine("[r]endszám [i]gazolványszám");
    Console.Write("> ");
    valasztas = Console.ReadLine();
    if (valasztas == "R" || valasztas == "R") {
        bool validRendszam = false;
        Console.Write("kérem a rendszámot > ");
        string rendszam = Console.ReadLine();
        if (rendszam.Count() == 7) {
            if (!rendszam.Substring(0, 3).Contains('-') && !rendszam.Substring(4, 3).Contains('-')) {
                if (rendszam.Substring(0, 3).All(betuk.Contains) && rendszam.Substring(4, 3).All(szamok.Contains)) {
                    validRendszam = true;
                }
            }
        }
    }
} else if (valasztas == "B" || valasztas == "b") {
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
