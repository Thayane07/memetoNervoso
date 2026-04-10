// See https://aka.ms/new-console-template for more information
string fraseresposta, memeToNervoso = "Seu filho de uma";

Console.Write("Fala oque voce acha da mim?");
fraseresposta = Console.ReadLine()!;
memeToNervoso = 
$"{memeToNervoso.Remove(10)}... NÃO PERA. \n to nervoso"!;
Console.WriteLine(memeToNervoso);


