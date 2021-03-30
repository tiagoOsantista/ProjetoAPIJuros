namespace JurosRestDDDDomain.Entities
{
    public class Juro
    {
        /// <summary>
        /// Valor calculado do juro - Deve ser truncado (sem arredondamento) em duas casas decimais.
        /// </summary>
        public decimal ValorFinal { get; set; }
        /// <summary>
        /// Valor inicial é um decimal recebido como parâmetro de entrada.
        /// </summary>
        public decimal ValorInicial { get; set; }
        /// <summary>
        /// Valor do Juros deve ser consultado na API taxa/taxaJuros.
        /// </summary>
        public decimal ValorJuros { get; set; }
        /// <summary>
        /// Tempo é um inteiro, que representa meses, recebido como parâmetro de entrada.
        /// </summary>
        public int Tempo { get; set; }
    }
}
