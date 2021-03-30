using System;
using System.Collections.Generic;
using System.Text;

namespace JurosRestDDDApplication.DTOs
{
    public class JuroDto
    {
        public decimal ValorInicial { get; set; }
        public decimal ValorJuros { get; set; }
        public int Tempo { get; set; }
    }
}
