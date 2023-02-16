using csharp_exception.Titular;
using csharp_exception.Contas;
using csharp_exception;
using ByteBank;

Console.WriteLine(ContaCorrente.TaxaOperacao);

#region
// try 
// {
//     ContaCorrente conta1 = new ContaCorrente(212, "311324");
    // conta1.Sacar(50);
    // Console.WriteLine(conta1.GetSaldo()); 
    // conta1.Sacar(150);
    // Console.WriteLine(conta1.GetSaldo());
// }
// catch(ArgumentException ex)
// {
//     Console.WriteLine("Parâmetro com erro: " + ex.ParamName); 
//     Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a 0."); 
//     Console.WriteLine(ex.Message);
// }
// catch(SaldoInsuficienteException ex)
// {
//     Console.WriteLine("Operação negada, saldo insuficiente"); 
//     Console.WriteLine(ex.Message); 
// }
#endregion
 
LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
try
{
    leitor.LerProximaLinha(); 
}
catch (IOException)
{
    Console.WriteLine("Leitura de arquivo interrompida"); 
}
// será executado mesmo que ele caia na excessão 
finally 
{
    leitor.Dispose();
}

