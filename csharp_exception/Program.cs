using csharp_exception.Titular;
using csharp_exception.Contas;

Console.WriteLine(ContaCorrente.TaxaOperacao);

try 
{
    ContaCorrente conta1 = new ContaCorrente(0, "311324");
}
catch(ArgumentException ex)
{
    // pega qual argumento está lançando a excessão pra nós 
    Console.WriteLine("Parâmetro com erro: " + ex.ParamName); 
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a 0."); 
    Console.WriteLine(ex.Message);
}
