using Poseidon.Base;
using Poseidon.Business;
using Poseidon.Entity;
using Poseidon.Properties;
using System;
using Telerik.WinControls.UI;

namespace Poseidon.Form
{
    public partial class UnidadeHabitacionalForm : RadForm
    {
        #region Private Fields

        private UnidadeHabitacionalEntity unidadeHabitacional;

        #endregion Private Fields

        #region Public Constructors

        public UnidadeHabitacionalForm(UnidadeHabitacionalEntity unidadeHabitacional = null)
        {
            InitializeComponent();

            Icon = Resources.Form;
            btnSalvar.Image = Resources.Salvar;
            btnCancelar.Image = Resources.Cancelar;

            txtTipo.AutoSizeDropDownToBestFit = true;
            txtTipo.EditorControl.MasterTemplate.AutoGenerateColumns = false;

            txtTipo.MultiColumnComboBoxElement.Columns.Add("ID", "ID", "ID");
            txtTipo.MultiColumnComboBoxElement.Columns.Add("Nome", "Nome", "Nome");
            txtTipo.MultiColumnComboBoxElement.Columns.Add("Diaria", "Diária", "Diaria");

            txtTipo.DataSource = TipoUnidadeHabitacionalBusiness.GetTiposUnidadesHabitacionais();

            this.unidadeHabitacional = unidadeHabitacional;
            if (unidadeHabitacional != null) SetUnidadeHabitacional();
        }

        #endregion Public Constructors



        #region Private Methods

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            GetUnidadeHabitacional();

            if (EhUnidadeHabitacionalValido())
            {
                if (UnidadeHabitacionalBusiness.Salvar(unidadeHabitacional))
                {
                    Mensagens.Sucesso(Text, string.Format(Mensagens.SUCESSO_SALVAR_UNIDADE_HABITACIONAL, unidadeHabitacional.Nome));
                    Close();
                }
                else
                    Mensagens.Erro(Text, string.Format(Mensagens.ERRO_SALVAR_UNIDADE_HABITACIONAL, unidadeHabitacional.Nome));
            }
        }

        private bool EhUnidadeHabitacionalValido()
        {
            bool retorno = true;
            epUnidadeHabitacionalForm.Clear();
            if (Validator.EhNuloOuVazio(unidadeHabitacional.Nome))
            {
                epUnidadeHabitacionalForm.SetIconPadding(txtNome, -18);
                epUnidadeHabitacionalForm.SetError(txtNome, "Digite a identificação da unidade habitacional");
                retorno = false;
            }
            if (unidadeHabitacional.ID_Tipo_Unidade_Habitacional <= 0)
            {
                epUnidadeHabitacionalForm.SetIconPadding(txtTipo, -36);
                epUnidadeHabitacionalForm.SetError(txtTipo, "Selecione o tipo da unidade habitacional");
                retorno = false;
            }
            if (Validator.EhNuloOuVazio(unidadeHabitacional.Situacao))
            {
                epUnidadeHabitacionalForm.SetIconPadding(txtSituacao, -36);
                epUnidadeHabitacionalForm.SetError(txtSituacao, "Selecione a situação da unidade habitacional");
                retorno = false;
            }
            return retorno;
        }

        private void GetUnidadeHabitacional()
        {
            if (unidadeHabitacional == null) unidadeHabitacional = new UnidadeHabitacionalEntity();

            var tipoUnidadeHabitacionalEntity = (TipoUnidadeHabitacionalEntity)((GridViewRowInfo)(txtTipo.SelectedItem)).DataBoundItem;

            unidadeHabitacional.Nome = txtNome.Text;
            unidadeHabitacional.ID_Tipo_Unidade_Habitacional = Convert.ToInt32(tipoUnidadeHabitacionalEntity.ID);
            unidadeHabitacional.Situacao = txtSituacao.Text;
            unidadeHabitacional.Ramal = txtRamal.Text;

            unidadeHabitacional.Caracteristicas = txtCaracteristicas.Text;
        }

        private void SetUnidadeHabitacional()
        {
            txtNome.Text = unidadeHabitacional.Nome;
            txtTipo.SelectedValue = TipoUnidadeHabitacionalBusiness.GetTipoUnidadeHabitacional(unidadeHabitacional.ID_Tipo_Unidade_Habitacional).Nome;
            txtSituacao.Text = unidadeHabitacional.Situacao;
            txtRamal.Text = unidadeHabitacional.Ramal;

            txtCaracteristicas.Text = unidadeHabitacional.Caracteristicas;
        }

        #endregion Private Methods
    }
}