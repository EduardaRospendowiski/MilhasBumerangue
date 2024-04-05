double percentualDeBonus, percentualDeRetorno;
double pontosATransferir, pontosAReduzir, pontosAAcrescentar;

Console.Clear();
Console.Write("--- Milhas Bumerangue ---\n");

Console.Write("Percentual de bônus.....: ");
percentualDeBonus = Convert.ToDouble(Console.ReadLine());

Console.Write("Percentual de retorno...: ");
percentualDeRetorno = Convert.ToDouble(Console.ReadLine());

Console.Write("Pontos a transferir.....: ");
pontosATransferir = Convert.ToDouble(Console.ReadLine());


pontosAReduzir = pontosATransferir - (pontosATransferir * percentualDeRetorno) / 100;
pontosAAcrescentar = pontosATransferir + (pontosATransferir * percentualDeBonus) / 100;

Console.WriteLine();
Console.WriteLine($"Pontos a reduzir na origem: {pontosAReduzir}");
Console.WriteLine($"Pontos a acrescentar no destino: {pontosAAcrescentar}");
