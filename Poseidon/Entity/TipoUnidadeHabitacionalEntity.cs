using System;
using System.Data.Linq.Mapping;

namespace Poseidon.Entity
{
    [Table(Name = "tipos_unidades_habitacionais")]
    public class TipoUnidadeHabitacionalEntity
    {
        [Column(CanBeNull = false)]
        public double Diaria { get; set; }

        [Column(CanBeNull = false)]
        public char Flag { get; set; }

        [Column(IsPrimaryKey = true, CanBeNull = false)]
        public int? ID { get; set; }

        [Column(CanBeNull = false)]
        public string Nome { get; set; }

        [Column(CanBeNull = false)]
        public DateTime Update { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}