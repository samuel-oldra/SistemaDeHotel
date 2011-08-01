using System;
using System.Data.Linq.Mapping;

namespace Poseidon.Entity
{
    [Table(Name = "contas")]
    public class ContaEntity
    {
        [Column]
        public DateTime? Check_In { get; set; }

        [Column]
        public DateTime? Check_Out { get; set; }

        [Column(CanBeNull = false)]
        public DateTime Entrada { get; set; }

        [Column(CanBeNull = false)]
        public char Flag { get; set; }

        [Column(IsPrimaryKey = true, CanBeNull = false)]
        public int? ID { get; set; }

        [Column(CanBeNull = false)]
        public int ID_Cliente { get; set; }

        [Column(CanBeNull = false)]
        public int ID_Unidade_Habitacional { get; set; }

        [Column]
        public string Observacoes { get; set; }

        [Column]
        public char? Reserva_Confirmada { get; set; }

        [Column(CanBeNull = false)]
        public DateTime Saida { get; set; }

        [Column(CanBeNull = false)]
        public DateTime Update { get; set; }

        [Column]
        public DateTime? Validade_Reserva { get; set; }

        [Column(CanBeNull = false)]
        public double Valor { get; set; }
    }
}