using NerdStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Catalogo.Domain
{
    public class Dimensoes
    {
        public decimal Altura { get; private set; }
        public decimal Largura { get; private set; }
        public decimal Profundidade { get; private set; }

        public Dimensoes(decimal altura, decimal largura, decimal profundidade)
        {
            Validacoes.ValidarSeMenorQue(altura, 1, "O campo altura deve ser maior que um");
            Validacoes.ValidarSeMenorQue(largura, 1, "O campo largura deve ser maior que um");
            Validacoes.ValidarSeMenorQue(profundidade, 1, "O campo profunidade deve ser maior que um");

            Altura = altura;
            Largura = largura;
            Profundidade = profundidade;

        }

        public string DescricaoFormatada()
        {
            return $"LxAxO: {Largura} x {Altura} x {Profundidade}";
        }

        public override string ToString()
        {
            return DescricaoFormatada();
        }
    }
}
