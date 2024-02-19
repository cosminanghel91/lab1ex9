/*
* Scrieti un program care va interschimba valorile la 2 numere intregi
*/


Console.WriteLine("Introduceti valoarea pentru primul numar:");
int numar1 = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti valoarea pentru al doilea numar:");
int numar2 = int.Parse(Console.ReadLine());

int temporar = numar2;
numar2 = numar1;
numar1 = temporar;

Console.WriteLine("Valoarea noua primului numar este:" + numar1 + " iar valoarea noua pentru al doilea numar este:" + numar2);