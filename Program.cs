

string[] pessoas = new string[5]; 

for(int i = 0; i < 5; i++)
{
   System.Console.WriteLine("Digite Nomes: ");
   var NomeTemp = Console.ReadLine();
   pessoas[i] = NomeTemp;
}
System.Console.WriteLine("------------");
foreach(string nome in pessoas)
{
   System.Console.WriteLine(nome);
}

 