// Console.Writeline("pedro".ToUpper().Replace("e" , "&"));

Console.Clear();
Console.WriteLine("--- tradutor de baleês ---\n");
Console.WriteLine("digite o texto a ser traduzido: ");
string texto = Console.ReadLine()!;
Console.WriteLine("\nA dory diria...\n");

Console.WriteLine(texto
.Replace("a", "aaa")
.Replace("e", "eee")
.Replace("i", "iii")
.Replace("o", "ooo")
.Replace("u", "uuu")
.Replace("A", "AAA") 
.Replace("E", "EEE")
.Replace("I", "III")
.Replace("O", "OOO")
.Replace("U", "UUU")
);
Console.WriteLine();