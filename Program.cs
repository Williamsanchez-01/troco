Console.Clear();


Console.WriteLine("Qual o valor do produto?\n");
double vl = Convert.ToDouble (Console.ReadLine());
Console.WriteLine($"\n o valor do seu produto lhe custou {vl}\n");


Console.WriteLine("\n Agora digite por favor o valor pago por favor.\n");
double vltr = Convert.ToDouble (Console.ReadLine());
Console.WriteLine($"\n você usou R${vltr} para pagar o produto.\n");


double sub = vltr - vl;


Console.WriteLine($"\n Seu troco {sub}");
