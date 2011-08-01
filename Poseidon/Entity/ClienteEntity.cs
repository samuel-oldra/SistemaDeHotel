using System;
using System.Data.Linq.Mapping;

namespace Poseidon.Entity
{
    [Table(Name = "clientes")]
    public class ClienteEntity
    {
        [Column]
        public string Bairro { get; set; }

        [Column]
        public string CEP { get; set; }

        [Column]
        public string Cidade { get; set; }

        [Column(CanBeNull = false)]
        public string Cliente { get; set; }

        [Column]
        public string CPF { get; set; }

        [Column]
        public string Email { get; set; }

        [Column]
        public string Endereco { get; set; }

        [Column]
        public string Estado { get; set; }

        [Column(CanBeNull = false)]
        public char Flag { get; set; }

        [Column]
        public string FoneCelular { get; set; }

        [Column]
        public string FoneComercial { get; set; }

        [Column]
        public string FoneResidencial { get; set; }

        [Column(IsPrimaryKey = true, CanBeNull = false)]
        public int? ID { get; set; }

        [Column]
        public DateTime? Nascimento { get; set; }

        [Column]
        public string Observacoes { get; set; }

        [Column]
        public string Pais { get; set; }

        [Column]
        public string Placa { get; set; }

        [Column]
        public string PontoRef { get; set; }

        [Column]
        public string Profissao { get; set; }

        [Column]
        public string Ramal { get; set; }

        [Column]
        public string RG { get; set; }

        [Column]
        public string Sexo { get; set; }

        [Column(CanBeNull = false)]
        public DateTime Update { get; set; }

        [Column]
        public string Veiculo { get; set; }
    }
}