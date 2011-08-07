using Poseidon.Base;
using Poseidon.Business;
using Poseidon.Entity;
using Poseidon.Properties;
using System;
using Telerik.WinControls.UI;

namespace Poseidon.Form
{
    public partial class TipoUnidadeHabitacionalForm : RadForm
    {
        #region Private Fields

        private TipoUnidadeHabitacionalEntity tipoUnidadeHabitacional;

        #endregion Private Fields

        #region Public Constructors

        public TipoUnidadeHabitacionalForm(TipoUnidadeHabitacionalEntity tipoUnidadeHabitacional = null)
        {
            InitializeComponent();

            Icon = Resources.Form;
            btnSalvar.Image = Resources.Salvar;
            btnCancelar.Image = Resources.Cancelar;

            this.tipoUnidadeHabitacional = tipoUnidadeHabitacional;
            if (tipoUnidadeHabitacional != null) SetTipoUnidadeHabitacional();
        }

        #endregion Public Constructors

        #region Private Methods

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            GetTipoUnidadeHabitacional();

            if (EhTipoUnidadeHabitacionalValido())
            {
                if (TipoUnidadeHabitacionalBusiness.Salvar(tipoUnidadeHabitacional))
                {
                    Mensagens.Sucesso(Text, string.Format(Mensagens.SUCESSO_SALVAR_TIPO_UNIDADE_HABITACIONAL, tipoUnidadeHabitacional.Nome));
                    Close();
                }
                else
                    Mensagens.Erro(Text, string.Format(Mensagens.ERRO_SALVAR_TIPO_UNIDADE_HABITACIONAL, tipoUnidadeHabitacional.Nome));
            }
        }

        private bool EhTipoUnidadeHabitacionalValido()
        {
            bool retorno = true;
            epTipoUnidadeHabitacionalForm.Clear();
            if (Validator.EhNuloOuVazio(tipoUnidadeHabitacional.Nome))
            {
                epTipoUnidadeHabitacionalForm.SetIconPadding(txtNome, -18);
                epTipoUnidadeHabitacionalForm.SetError(txtNome, "Digite a identificação do tipo de U.H.");
                retorno = false;
            }
            if (tipoUnidadeHabitacional.Diaria <= 0)
            {
                epTipoUnidadeHabitacionalForm.SetIconPadding(txtDiaria, -18);
                epTipoUnidadeHabitacionalForm.SetError(txtDiaria, "Digite um valor válido para a diária");
                retorno = false;
            }
            return retorno;
        }

        private void GetTipoUnidadeHabitacional()
        {
            double temp = -1;

            if (tipoUnidadeHabitacional == null) tipoUnidadeHabitacional = new TipoUnidadeHabitacionalEntity();

            tipoUnidadeHabitacional.Nome = txtNome.Text;
            if (Double.TryParse(txtDiaria.Text, out temp)) tipoUnidadeHabitacional.Diaria = Convert.ToDouble(txtDiaria.Text);
        }

        private void SetTipoUnidadeHabitacional()
        {
            txtNome.Text = tipoUnidadeHabitacional.Nome;
            txtDiaria.Text = tipoUnidadeHabitacional.Diaria.ToString();
        }

        #endregion Private Methods
    }
}