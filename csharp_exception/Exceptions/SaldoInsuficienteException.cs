namespace csharp_exception
{
    // vai derivar de excepetion
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        // podemos sempre utilizar as mensagens 
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {
            // criamos uma excessão personalizada 

        }
    }
}