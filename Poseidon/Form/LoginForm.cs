using Poseidon.Base;
using Poseidon.Business;
using Poseidon.Entity;
using Poseidon.Properties;
using System;
using Telerik.WinControls.UI;
using Settings = Poseidon.Base.Settings;

namespace Poseidon.Form
{
    public partial class LoginForm : RadForm
    {
        private UsuarioEntity usuario;

        public LoginForm()
        {
            InitializeComponent();

            Icon = Resources.Poseidon;
            btnOK.Image = Resources.OK;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            GetUsuario();

            if (EhUsuarioValido())
            {
                if (UsuarioBusiness.EhUsuarioSenhaValido(usuario))
                {
                    Mensagens.Sucesso(Text, Mensagens.SUCESSO_LOGIN);
                    Settings.Usuario = usuario;
                    Close();
                }
                else
                    Mensagens.Erro(Text, Mensagens.ERRO_LOGIN);
            }
        }

        private bool EhUsuarioValido()
        {
            bool retorno = true;
            epLoginForm.Clear();
            if (Validator.EhNuloOuVazio(usuario.Usuario))
            {
                epLoginForm.SetIconPadding(txtUsuario, -18);
                epLoginForm.SetError(txtUsuario, "Digite o nome do usuário");
                retorno = false;
            }
            if (Validator.EhNuloOuVazio(usuario.Senha))
            {
                epLoginForm.SetIconPadding(txtSenha, -18);
                epLoginForm.SetError(txtSenha, "Digite a senha do usuário");
                retorno = false;
            }
            return retorno;
        }

        private void GetUsuario()
        {
            if (usuario == null) usuario = new UsuarioEntity();

            usuario.ID = null;
            usuario.Usuario = txtUsuario.Text;
            usuario.Senha = txtSenha.Text;
        }
    }
}