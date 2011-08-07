using Poseidon.Base;
using Poseidon.Business;
using Poseidon.Properties;
using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Settings = Poseidon.Base.Settings;

namespace Poseidon.Form
{
    public partial class PrincipalForm : RadRibbonForm
    {
        #region Public Constructors

        public PrincipalForm()
        {
            InitializeComponent();

            AllowAero = false;

            Icon = Resources.Poseidon;
            btnClientes.Image = Resources.Clientes;
            btnReserva.Image = Resources.Reserva;
            btnCheck.Image = Resources.Check;
            btnWalkIn.Image = Resources.Walk_In;
            rmiUnidadesHabitacionais.Image = Resources.UnidadesHabitacionais;

            radRibbonBarPrincipal.StartButtonImage = Resources.PoseidonStartButton;
            panelPrincipal.BackgroundImage = Resources.PoseidonBackground;
            panelPrincipal.BackgroundImageLayout = ImageLayout.Center;

            UpdateForm();
        }

        #endregion Public Constructors

        #region Protected Methods

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            new LoginForm().ShowDialog();
            if (Settings.Usuario == null) Close();
        }

        #endregion Protected Methods

        #region Private Methods

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Mensagens.Erro(Text, "NotImplemented");
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new ClienteFormList().ShowDialog();
            UpdateForm();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            new ReservaForm().ShowDialog();
            UpdateForm();
        }

        private void btnWalkIn_Click(object sender, EventArgs e)
        {
            new WalkInForm().ShowDialog();
            UpdateForm();
        }

        private void rmiTiposUnidadesHabitacionais_Click(object sender, EventArgs e)
        {
            new TipoUnidadeHabitacionalFormList().ShowDialog();
            UpdateForm();
        }

        private void rmiUnidadesHabitacionais_Click(object sender, EventArgs e)
        {
            new UnidadeHabitacionalFormList().ShowDialog();
            UpdateForm();
        }

        private void UpdateForm()
        {
            rmiUnidadesHabitacionais.Enabled = TipoUnidadeHabitacionalBusiness.GetTiposUnidadesHabitacionais().Count > 0;
            btnReserva.Enabled = UnidadeHabitacionalBusiness.GetUnidadesHabitacionais().Count > 0;
            btnWalkIn.Enabled = UnidadeHabitacionalBusiness.GetUnidadesHabitacionais().Count > 0;
        }

        #endregion Private Methods
    }
}