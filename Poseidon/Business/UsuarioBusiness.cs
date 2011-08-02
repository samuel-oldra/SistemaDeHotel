using Poseidon.Base;
using Poseidon.Entity;
using System.Data.Linq;
using System.Linq;

namespace Poseidon.Business
{
    public class UsuarioBusiness
    {
        #region Internal Methods

        internal static bool EhUsuarioSenhaValido(UsuarioEntity usuario)
        {
            return BuscarUsuario(usuario.Usuario, usuario.Senha) != null;
        }

        #endregion Internal Methods



        #region Private Methods

        private static UsuarioEntity BuscarUsuario(string usuario, string senha)
        {
            try
            {
                Table<UsuarioEntity> usuarios = Settings.dataContext.GetTable<UsuarioEntity>();
                Settings.dataContext.Refresh(RefreshMode.OverwriteCurrentValues, Settings.dataContext.GetTable<UsuarioEntity>());
                return usuarios.SingleOrDefault(u => u.Usuario == usuario && u.Senha == senha);
            }
            catch
            { return null; }
        }

        #endregion Private Methods
    }
}