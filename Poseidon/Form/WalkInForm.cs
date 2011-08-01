using Poseidon.Base;
using Poseidon.Business;
using Poseidon.Entity;
using Poseidon.Properties;
using System;
using System.Collections.Generic;
using Telerik.WinControls.UI;
using Settings = Poseidon.Base.Settings;

namespace Poseidon.Form
{
    public partial class WalkInForm : RadForm
    {
        private ContaEntity conta;
        private double diaria;
        private int dias;
        private DateTime dtEntrada, dtSaida;

        public WalkInForm()
        {
            InitializeComponent();

            Icon = Resources.Form;
            btnAddCliente.Image = Resources.Adicionar;
            btnListCliente.Image = Resources.FormList.ToBitmap();
            btnSalvar.Image = Resources.Salvar;
            btnCancelar.Image = Resources.Cancelar;

            txtEntrada.Enabled = txtClienteID.Enabled = txtClienteNome.Enabled = txtValor.Enabled = false;

            txtUH.AutoSizeDropDownToBestFit = true;
            txtUH.EditorControl.MasterTemplate.AutoGenerateColumns = false;

            txtUH.MultiColumnComboBoxElement.Columns.Add("ID", "ID", "ID");
            txtUH.MultiColumnComboBoxElement.Columns.Add("Nome", "Nome", "Nome");
            txtUH.MultiColumnComboBoxElement.Columns.Add("Tipo_Unidade_Habitacional___Nome", "Tipo", "Tipo_Unidade_Habitacional___Nome");
            txtUH.MultiColumnComboBoxElement.Columns.Add("Situacao", "Situação", "Situacao");
            txtUH.MultiColumnComboBoxElement.Columns.Add("Ramal", "Ramal", "Ramal");
            txtUH.MultiColumnComboBoxElement.Columns.Add("Caracteristicas", "Características", "Caracteristicas");

            txtEntrada.Value = DateTime.Now;
            txtSaida.Value = txtEntrada.Value.AddDays(1);
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            new ClienteForm().ShowDialog();
            if (Settings.Cliente == null) return;
            txtClienteID.Text = Settings.Cliente.ID.ToString();
            txtClienteNome.Text = Settings.Cliente.Cliente;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnListCliente_Click(object sender, EventArgs e)
        {
            new ClienteFormList(false).ShowDialog();
            if (Settings.Cliente == null) return;
            txtClienteID.Text = Settings.Cliente.ID.ToString();
            txtClienteNome.Text = Settings.Cliente.Cliente;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            GetWalkIn();

            if (EhWalkInValida())
            {
                if (ContaBusiness.Salvar(conta))
                {
                    Mensagens.Sucesso(Text, string.Format(Mensagens.SUCESSO_SALVAR_WALKIN, txtClienteNome.Text));
                    Close();
                }
                else
                    Mensagens.Erro(Text, string.Format(Mensagens.ERRO_SALVAR_WALKIN, txtClienteNome.Text));
            }
        }

        private bool EhWalkInValida()
        {
            bool retorno = true;
            epWalkInForm.Clear();
            if (conta.ID_Cliente <= 0)
            {
                epWalkInForm.SetIconPadding(txtClienteID, -18);
                epWalkInForm.SetError(txtClienteID, "Nenhum cliente selecionado");
                retorno = false;
            }
            if (conta.Valor <= 0)
            {
                epWalkInForm.SetIconPadding(txtTotal, -18);
                epWalkInForm.SetError(txtTotal, "Digite um valor válido para o total");
                retorno = false;
            }
            return retorno;
        }

        private void GetWalkIn()
        {
            int tempi = -1;
            double tempd = -1;

            if (conta == null) conta = new ContaEntity();

            var unidadeHabitacionalEntity = (UnidadeHabitacionalEntity)((GridViewRowInfo)(txtUH.SelectedItem)).DataBoundItem;

            conta.ID = conta != null ? conta.ID : null;
            conta.Entrada = new DateTime(txtEntrada.Value.Year, txtEntrada.Value.Month, txtEntrada.Value.Day, 12, 0, 0, 0);
            conta.Saida = new DateTime(txtSaida.Value.Year, txtSaida.Value.Month, txtSaida.Value.Day, 12, 0, 0, 0);
            conta.ID_Unidade_Habitacional = Convert.ToInt32(unidadeHabitacionalEntity.ID);
            conta.ID_Cliente = Int32.TryParse(txtClienteID.Text, out tempi) ? Convert.ToInt32(txtClienteID.Text) : 0;
            conta.Valor = Double.TryParse(txtTotal.Text, out tempd) ? Convert.ToDouble(txtTotal.Text) : 0;

            conta.Observacoes = txtObservacoes.Text;

            conta.Check_In = DateTime.Now;
        }

        private void SetWalkIn()
        {
            // ...
        }

        private void txtDesconto_ValueChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void txtEntrada_ValueChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void txtQuarto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txtUH.SelectedItem == null) return;
            var unidadeHabitacionalEntity = (UnidadeHabitacionalEntity)((GridViewRowInfo)(txtUH.SelectedItem)).DataBoundItem;
            diaria = TipoUnidadeHabitacionalBusiness.GetTipoUnidadeHabitacional(Convert.ToInt32(unidadeHabitacionalEntity.ID_Tipo_Unidade_Habitacional)).Diaria;

            UpdateValues();
        }

        private void txtSaida_ValueChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            dtEntrada = new DateTime(txtEntrada.Value.Year, txtEntrada.Value.Month, txtEntrada.Value.Day, 12, 0, 0, 0);
            dtSaida = new DateTime(txtSaida.Value.Year, txtSaida.Value.Month, txtSaida.Value.Day, 12, 0, 0, 0);
            dias = (dtSaida - dtEntrada).Days;
            if (dtSaida > dtEntrada)
            {
                List<UnidadeHabitacionalEntity> unidades_habitacionais = UnidadeHabitacionalBusiness.GetUnidadesHabitacionais_Livres(dtEntrada, dtSaida);
                txtUH.Enabled = btnSalvar.Enabled = unidades_habitacionais.Count > 0;
                txtUH.DataSource = unidades_habitacionais;
            }
            else
                txtSaida.Value = txtEntrada.Value.AddDays(1);
        }

        private void UpdateValues()
        {
            double desconto = Convert.ToInt32(txtDesconto.Value);

            txtValor.Text = string.Format("{0} x {1} = {2}", dias, diaria, dias * diaria);
            txtTotal.Text = string.Format("{0}", (dias * diaria) - ((dias * diaria) * (desconto / 100)));
        }
    }
}