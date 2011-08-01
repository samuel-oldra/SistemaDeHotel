using Poseidon.Business;
using System;
using System.Data.Linq.Mapping;

namespace Poseidon.Entity
{
    [Table(Name = "unidades_habitacionais")]
    public class UnidadeHabitacionalEntity
    {
        [Column]
        public string Caracteristicas { get; set; }

        [Column(CanBeNull = false)]
        public char Flag { get; set; }

        [Column(IsPrimaryKey = true, CanBeNull = false)]
        public int? ID { get; set; }

        [Column(CanBeNull = false)]
        public int ID_Tipo_Unidade_Habitacional { get; set; }

        [Column(CanBeNull = false)]
        public string Nome { get; set; }

        [Column]
        public string Ramal { get; set; }

        [Column(CanBeNull = false)]
        public string Situacao { get; set; }

        public string Tipo_Unidade_Habitacional___Nome
        {
            get
            {
                TipoUnidadeHabitacionalEntity tipoUnidadeHabitacionalEntity = TipoUnidadeHabitacionalBusiness.GetTipoUnidadeHabitacional(ID_Tipo_Unidade_Habitacional);
                return string.Format("{0} ({1})", tipoUnidadeHabitacionalEntity.Nome, tipoUnidadeHabitacionalEntity.Diaria);
            }
        }

        [Column(CanBeNull = false)]
        public DateTime Update { get; set; }
    }
}