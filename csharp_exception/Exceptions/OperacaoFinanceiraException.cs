namespace csharp_exception
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException(string mensagem) : base(mensagem)
        {
            // vamos colocar uma mensagem mais interna 
            
        }
        // a excessão vai causar um problema 
        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna)
        {
            // criamos a excessao e fizemos outro construtor que recebe alem da mensagem a excessao que esta sendo causada 
            
        }
    }
}