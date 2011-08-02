using Poseidon.Base;
using Poseidon.Business;
using Poseidon.Entity;
using Poseidon.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Poseidon.Form
{
    public partial class TipoUnidadeHabitacionalFormList : RadForm
    {
        #region Public Constructors

        public TipoUnidadeHabitacionalFormList()
        {
            InitializeComponent();

            Icon = Resources.FormList;
            btnAdicionar.Image = Resources.Adicionar;
            btnRemover.Image = Resources.Remover;
            btnEditar.Image = Resources.Editar;
            btnFechar.Image = Resources.Cancelar;

            gridTiposUnidadesHabitacionais.AllowAddNewRow = false;
            gridTiposUnidadesHabitacionais.AllowDeleteRow = false;
            gridTiposUnidadesHabitacionais.AllowEditRow = false;
            gridTiposUnidadesHabitacionais.EnableCustomFiltering = true;
            gridTiposUnidadesHabitacionais.EnableFiltering = true;
            gridTiposUnidadesHabitacionais.EnableHotTracking = true;
            gridTiposUnidadesHabitacionais.ShowFilteringRow = false;

            gridTiposUnidadesHabitacionais.Columns.Add("ID", "ID", "ID");
            gridTiposUnidadesHabitacionais.Columns.Add("Nome", "Nome", "Nome");
            gridTiposUnidadesHabitacionais.Columns.Add("Diaria", "Diária", "Diaria");

            ShowDataGrid();
        }

        #endregion Public Constructors



        #region Private Methods

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new TipoUnidadeHabitacionalForm().ShowDialog();
            ShowDataGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var tipoUnidadeHabitacional = (TipoUnidadeHabitacionalEntity)gridTiposUnidadesHabitacionais.SelectedRows[0].DataBoundItem;
            new TipoUnidadeHabitacionalForm(tipoUnidadeHabitacional).ShowDialog();
            ShowDataGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var tipoUnidadeHabitacional = (TipoUnidadeHabitacionalEntity)gridTiposUnidadesHabitacionais.SelectedRows[0].DataBoundItem;

            DialogResult result = Mensagens.Questao(Text, string.Format(Mensagens.QUESTAO_REMOVER_TIPO_UNIDADE_HABITACIONAL, tipoUnidadeHabitacional.Nome));
            if (result == DialogResult.Yes)
            {
                if (TipoUnidadeHabitacionalBusiness.Remover(tipoUnidadeHabitacional))
                    Mensagens.Sucesso(Text, string.Format(Mensagens.SUCESSO_REMOVER_TIPO_UNIDADE_HABITACIONAL, tipoUnidadeHabitacional.Nome));
                else
                    Mensagens.Erro(Text, string.Format(Mensagens.ERRO_REMOVER_TIPO_UNIDADE_HABITACIONAL, tipoUnidadeHabitacional.Nome));
            }

            ShowDataGrid();
        }

        private void gridTiposUnidadesHabitacionais_CustomFiltering(object sender, GridViewCustomFilteringEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisar.Text))
            {
                e.Visible = true;
                for (int i = 0; i < gridTiposUnidadesHabitacionais.ColumnCount; i++)
                {
                    e.Row.Cells[i].Style.Reset();
                    e.Row.InvalidateRow();
                }
                return;
            }

            e.Visible = false;
            for (int i = 0; i < gridTiposUnidadesHabitacionais.ColumnCount; i++)
            {
                string text = e.Row.Cells[i].Value != null ? e.Row.Cells[i].Value.ToString() : string.Empty;
                if (text.IndexOf(txtPesquisar.Text, 0, StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    e.Row.Cells[i].Style.BackColor = Color.FromArgb(201, 252, 254);
                    e.Row.Cells[i].Style.CustomizeFill = true;
                    e.Row.Cells[i].Style.DrawFill = true;
                    e.Visible = true;
                }
                else
                {
                    e.Row.Cells[i].Style.Reset();
                    e.Row.InvalidateRow();
                }
            }
        }

        private void ShowDataGrid()
        {
            gridTiposUnidadesHabitacionais.DataSource = TipoUnidadeHabitacionalBusiness.GetTiposUnidadesHabitacionais();
            btnRemover.Enabled = btnEditar.Enabled = gridTiposUnidadesHabitacionais.RowCount > 0;
            for (int i = 0; i < gridTiposUnidadesHabitacionais.ColumnCount; i++) gridTiposUnidadesHabitacionais.Columns[i].BestFit();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            gridTiposUnidadesHabitacionais.MasterTemplate.Refresh();
        }

        #endregion Private Methods
    }
}