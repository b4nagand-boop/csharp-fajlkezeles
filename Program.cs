using System.IO;
List<char> betuk = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
List<char> szamok = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];

string rendszam = Console.ReadLine("Kérem a rendszámot > ");
if (!File.Exists("db.csv")) {
    File.Create("db.csv");
    File.AppendText("tipus; azonosito; datum");
} else {
    foreach (string line in File.ReadAllText().Split('\n').Skip(1)) {
        
    }
}
