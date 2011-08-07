using Poseidon.Properties;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Poseidon.Base
{
    public class Mensagens
    {
        #region Public Fields

        public static string ERRO_LOGIN = "Usuário ou senha incorreta.";

        public static string ERRO_REMOVER_CLIENTE = "Erro ao remover o cliente [{0}].";
        public static string ERRO_REMOVER_TIPO_UNIDADE_HABITACIONAL = "Erro ao remover o tipo de unidade habitacional [{0}].";
        public static string ERRO_REMOVER_UNIDADE_HABITACIONAL = "Erro ao remover a unidade habitacional [{0}].";

        public static string ERRO_SALVAR_CLIENTE = "Erro ao salvar o cliente [{0}].";
        public static string ERRO_SALVAR_RESERVA = "Erro ao salvar a reserva [{0}].";
        public static string ERRO_SALVAR_TIPO_UNIDADE_HABITACIONAL = "Erro ao salvar o tipo de unidade habitacional [{0}].";
        public static string ERRO_SALVAR_UNIDADE_HABITACIONAL = "Erro ao salvar a unidade habitacional [{0}].";
        public static string ERRO_SALVAR_WALKIN = "Erro ao realizar o walk-in [{0}].";

        public static string QUESTAO_REMOVER_CLIENTE = "Deseja remover o cliente [{0}]?";
        public static string QUESTAO_REMOVER_TIPO_UNIDADE_HABITACIONAL = "Deseja remover o tipo de unidade habitacional [{0}]?";
        public static string QUESTAO_REMOVER_UNIDADE_HABITACIONAL = "Deseja remover a unidade habitacional [{0}]?";

        public static string SUCESSO_LOGIN = "Login efetuado com sucesso.";

        public static string SUCESSO_REMOVER_CLIENTE = "Cliente [{0}] removido com sucesso.";
        public static string SUCESSO_REMOVER_TIPO_UNIDADE_HABITACIONAL = "Tipo de unidade habitacional [{0}] removido com sucesso.";
        public static string SUCESSO_REMOVER_UNIDADE_HABITACIONAL = "Unidade habitacional [{0}] removida com sucesso.";

        public static string SUCESSO_SALVAR_CLIENTE = "Cliente [{0}] salvo com sucesso.";
        public static string SUCESSO_SALVAR_RESERVA = "Reserva [{0}] salva com sucesso.";
        public static string SUCESSO_SALVAR_TIPO_UNIDADE_HABITACIONAL = "Tipo de unidade habitacional [{0}] salvo com sucesso.";
        public static string SUCESSO_SALVAR_UNIDADE_HABITACIONAL = "Unidade habitacional [{0}] salva com sucesso.";
        public static string SUCESSO_SALVAR_WALKIN = "Walk-In [{0}] realizado com sucesso.";

        #endregion Public Fields

        #region Internal Methods

        internal static void Erro(string titulo, string mensagem)
        {
            RadMessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, RadMessageIcon.Error);
        }

        internal static DialogResult Questao(string titulo, string mensagem)
        {
            return RadMessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, RadMessageIcon.Question);
        }

        internal static void Sucesso(string titulo, string mensagem)
        {
            var radDesktopAlert = new RadDesktopAlert();
            radDesktopAlert.AutoCloseDelay = 3;
            radDesktopAlert.CaptionText = titulo;
            radDesktopAlert.ContentImage = Resources.Salved;
            radDesktopAlert.ContentText = mensagem;
            radDesktopAlert.PlaySound = true;
            radDesktopAlert.ShowOptionsButton = false;
            radDesktopAlert.ShowPinButton = false;
            radDesktopAlert.Show();
        }

        #endregion Internal Methods
    }
}