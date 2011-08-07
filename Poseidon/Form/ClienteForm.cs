using Poseidon.Base;
using Poseidon.Business;
using Poseidon.Entity;
using Poseidon.Properties;
using System;
using Telerik.WinControls.UI;

namespace Poseidon.Form
{
    public partial class ClienteForm : RadForm
    {
        #region Private Fields

        private ClienteEntity cliente;

        #endregion Private Fields

        #region Public Constructors

        public ClienteForm(ClienteEntity cliente = null)
        {
            InitializeComponent();

            Icon = Resources.Form;
            btnSalvar.Image = Resources.Salvar;
            btnCancelar.Image = Resources.Cancelar;

            this.cliente = cliente;
            if (cliente != null) SetCliente();
            else txtNascimento.Value = DateTime.Now;
        }

        #endregion Public Constructors

        #region Private Methods

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            GetCliente();

            if (EhClienteValido())
            {
                if (ClienteBusiness.Salvar(cliente))
                {
                    Mensagens.Sucesso(Text, string.Format(Mensagens.SUCESSO_SALVAR_CLIENTE, cliente.Cliente));
                    Close();
                }
                else
                    Mensagens.Erro(Text, string.Format(Mensagens.ERRO_SALVAR_CLIENTE, cliente.Cliente));
            }
        }

        private bool EhClienteValido()
        {
            bool retorno = true;
            epClienteForm.Clear();
            if (Validator.EhNuloOuVazio(cliente.Cliente))
            {
                epClienteForm.SetIconPadding(txtCliente, -18);
                epClienteForm.SetError(txtCliente, "Digite o nome do hóspede");
                retorno = false;
            }
            if (!Validator.EhCPF(cliente.CPF) && !Validator.EhIgual(cliente.CPF, "___.___.___-__"))
            {
                epClienteForm.SetIconPadding(txtCPF, -18);
                epClienteForm.SetError(txtCPF, "Digite o CPF do hóspede.");
                retorno = false;
            }
            if (!Validator.EhTelefone(cliente.FoneCelular) && !Validator.EhIgual(cliente.FoneCelular, "(__) ____.____"))
            {
                epClienteForm.SetIconPadding(txtFoneCelular, -18);
                epClienteForm.SetError(txtFoneCelular, "Digite o telefone do hóspede.");
                retorno = false;
            }
            if (!Validator.EhTelefone(cliente.FoneResidencial) && !Validator.EhIgual(cliente.FoneResidencial, "(__) ____.____"))
            {
                epClienteForm.SetIconPadding(txtFoneResidencial, -18);
                epClienteForm.SetError(txtFoneResidencial, "Digite o telefone do hóspede.");
                retorno = false;
            }
            if (!Validator.EhTelefone(cliente.FoneComercial) && !Validator.EhIgual(cliente.FoneComercial, "(__) ____.____"))
            {
                epClienteForm.SetIconPadding(txtFoneComercial, -18);
                epClienteForm.SetError(txtFoneComercial, "Digite o telefone do hóspede.");
                retorno = false;
            }
            if (!Validator.EhCEP(cliente.CEP) && !Validator.EhIgual(cliente.CEP, "_____-___"))
            {
                epClienteForm.SetIconPadding(txtCEP, -18);
                epClienteForm.SetError(txtCEP, "Digite o CEP do hóspede.");
                retorno = false;
            }
            return retorno;
        }

        private void GetCliente()
        {
            if (cliente == null) cliente = new ClienteEntity();

            cliente.ID = cliente != null ? cliente.ID : null;
            cliente.Cliente = txtCliente.Text;
            cliente.CPF = txtCPF.Text;
            cliente.RG = txtRG.Text;
            cliente.Nascimento = string.Compare(txtNascimento.Value.ToShortDateString(), DateTime.Now.ToShortDateString()) != 0 ? cliente.Nascimento = new DateTime(txtNascimento.Value.Year, txtNascimento.Value.Month, txtNascimento.Value.Day, 0, 0, 0, 0) : null;
            cliente.Sexo = txtSexo.Text;
            cliente.Profissao = txtProfissao.Text;
            cliente.Veiculo = txtVeiculo.Text;
            cliente.Placa = txtPlaca.Text;

            cliente.Email = txtEmail.Text;
            cliente.FoneCelular = txtFoneCelular.Text;
            cliente.FoneResidencial = txtFoneResidencial.Text;
            cliente.FoneComercial = txtFoneComercial.Text;
            cliente.Ramal = txtRamal.Text;

            cliente.Endereco = txtEndereco.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Estado = txtEstado.Text;
            cliente.Pais = txtPais.Text;
            cliente.CEP = txtCEP.Text;
            cliente.PontoRef = txtPontoRef.Text;

            cliente.Observacoes = txtObservacoes.Text;
        }

        private void SetCliente()
        {
            txtCliente.Text = cliente.Cliente;
            txtCPF.Text = cliente.CPF;
            txtRG.Text = cliente.RG;
            txtNascimento.Value = cliente.Nascimento != null ? cliente.Nascimento.Value : DateTime.Now;
            txtSexo.Text = cliente.Sexo;
            txtProfissao.Text = cliente.Profissao;
            txtVeiculo.Text = cliente.Veiculo;
            txtPlaca.Text = cliente.Placa;

            txtEmail.Text = cliente.Email;
            txtFoneCelular.Text = cliente.FoneCelular;
            txtFoneResidencial.Text = cliente.FoneResidencial;
            txtFoneComercial.Text = cliente.FoneComercial;
            txtRamal.Text = cliente.Ramal;

            txtEndereco.Text = cliente.Endereco;
            txtBairro.Text = cliente.Bairro;
            txtCidade.Text = cliente.Cidade;
            txtEstado.Text = cliente.Estado;
            txtPais.Text = cliente.Pais;
            txtCEP.Text = cliente.CEP;
            txtPontoRef.Text = cliente.PontoRef;

            txtObservacoes.Text = cliente.Observacoes;
        }

        #endregion Private Methods
    }
}