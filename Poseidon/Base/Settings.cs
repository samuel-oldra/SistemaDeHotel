using Poseidon.Entity;
using System;
using System.Data.Linq;
using System.Data.SQLite;

namespace Poseidon.Base
{
    public class Settings
    {
        #region Public Fields

        public static readonly SQLiteConnection sqliteConnection = new SQLiteConnection(@"Data Source=Poseidon.db");
        public static DataContext dataContext = new DataContext(sqliteConnection);

        #endregion Public Fields



        #region Private Fields

        private static ClienteEntity _cliente_entity;
        private static DateTime _cliente_update = DateTime.Now;

        #endregion Private Fields



        #region Public Properties

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

        #endregion Public Properties
    }
}