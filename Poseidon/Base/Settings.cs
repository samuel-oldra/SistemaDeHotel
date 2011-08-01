using Poseidon.Entity;
using System;
using System.Data.Linq;
using System.Data.SQLite;

namespace Poseidon.Base
{
    public class Settings
    {
        public static readonly SQLiteConnection sqliteConnection = new SQLiteConnection(@"Data Source=Poseidon.db");
        public static DataContext dataContext = new DataContext(sqliteConnection);
        private static ClienteEntity _cliente_entity;
        private static DateTime _cliente_update = DateTime.Now;

        public static ClienteEntity Cliente
        {
            get
            {
                if (_cliente_update.AddSeconds(5) > DateTime.Now && _cliente_entity != null)
                    return _cliente_entity;
                return null;
            }
            set
            {
                _cliente_update = DateTime.Now;
                _cliente_entity = value;
            }
        }

        public static UsuarioEntity Usuario { get; set; }
    }
}