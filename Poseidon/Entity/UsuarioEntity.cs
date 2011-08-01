﻿using System.Data.Linq.Mapping;

namespace Poseidon.Entity
{
    [Table(Name = "usuarios")]
    public class UsuarioEntity
    {
        [Column(IsPrimaryKey = true, CanBeNull = false)]
        public int? ID { get; set; }

        [Column(CanBeNull = false)]
        public string Senha { get; set; }

        [Column(CanBeNull = false)]
        public string Usuario { get; set; }
    }
}