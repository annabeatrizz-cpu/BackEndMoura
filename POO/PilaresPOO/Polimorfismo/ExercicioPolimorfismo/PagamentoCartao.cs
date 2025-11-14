namespace ExercicioPolimorfismo
{
    public class PagamentoCartao : Pagamentos
    {
        private float acrescimo = 5.38f;

        public float ValorCompra;
        public override float CalcularTotal()
        {
            float valorAcrescimo = ValorCompra / 100 * acrescimo;
            
            return ValorCompra = ValorCompra + valorAcrescimo;
        }
    }
}