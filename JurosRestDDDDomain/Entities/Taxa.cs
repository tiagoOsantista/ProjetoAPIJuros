namespace JurosRestDDDDomain.Entities
{
    public class Taxa
    {
        /// <summary>
        /// Código da taxa
        /// </summary>
        public int TaxaId { get; set; }

        /// <summary>
        /// Descrição da taxa
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Valor da taxa
        /// </summary>
        public decimal Valor { get; set; }

        /// <summary>
        /// Indica se a taxa está ativa
        /// </summary>
        public bool Ativo { get; set; }


    }
}
