using csharp_exception.Titular;
using csharp_exception.Contas;
using csharp_exception;

Console.WriteLine(ContaCorrente.TaxaOperacao);

try 
{
    ContaCorrente conta1 = new ContaCorrente(212, "311324");
    conta1.Sacar(50);
    Console.WriteLine(conta1.GetSaldo()); 
    conta1.Sacar(150);
    Console.WriteLine(conta1.GetSaldo());
}
catch(ArgumentException ex)
{
    // pega qual argumento está lançando a excessão pra nós 
    Console.WriteLine("Parâmetro com erro: " + ex.ParamName); 
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a 0."); 
    Console.WriteLine(ex.Message);
}
catch(SaldoInsuficienteException ex)
{
    // podemos fazer mais de um catch relacionado ao try 
    Console.WriteLine("Operação negada, saldo insuficiente"); 
    Console.WriteLine(ex.Message); 
}
