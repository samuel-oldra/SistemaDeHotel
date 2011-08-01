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
    public partial class UnidadeHabitacionalFormList : RadForm
    {
        public UnidadeHabitacionalFormList()
        {
            InitializeComponent();

            Icon = Resources.FormList;
            btnAdicionar.Image = Resources.Adicionar;
            btnRemover.Image = Resources.Remover;
            btnEditar.Image = Resources.Editar;
            btnFechar.Image = Resources.Cancelar;

            gridUnidadesHabitacionais.AllowAddNewRow = false;
            gridUnidadesHabitacionais.AllowDeleteRow = false;
            gridUnidadesHabitacionais.AllowEditRow = false;
            gridUnidadesHabitacionais.EnableCustomFiltering = true;
            gridUnidadesHabitacionais.EnableFiltering = true;
            gridUnidadesHabitacionais.EnableHotTracking = true;
            gridUnidadesHabitacionais.ShowFilteringRow = false;

            gridUnidadesHabitacionais.Columns.Add("ID", "ID", "ID");
            gridUnidadesHabitacionais.Columns.Add("Nome", "Nome", "Nome");
            gridUnidadesHabitacionais.Columns.Add("Tipo_Unidade_Habitacional___Nome", "Tipo", "Tipo_Unidade_Habitacional___Nome");
            gridUnidadesHabitacionais.Columns.Add("Situacao", "Situação", "Situacao");
            gridUnidadesHabitacionais.Columns.Add("Ramal", "Ramal", "Ramal");
            gridUnidadesHabitacionais.Columns.Add("Caracteristicas", "Características", "Caracteristicas");

            ShowDataGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new UnidadeHabitacionalForm().ShowDialog();
            ShowDataGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var unidadeHabitacional = (UnidadeHabitacionalEntity)gridUnidadesHabitacionais.SelectedRows[0].DataBoundItem;
            new UnidadeHabitacionalForm(unidadeHabitacional).ShowDialog();
            ShowDataGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var unidadeHabitacional = (UnidadeHabitacionalEntity)gridUnidadesHabitacionais.SelectedRows[0].DataBoundItem;

            DialogResult result = Mensagens.Questao(Text, string.Format(Mensagens.QUESTAO_REMOVER_UNIDADE_HABITACIONAL, unidadeHabitacional.Nome));
            if (result == DialogResult.Yes)
            {
                if (UnidadeHabitacionalBusiness.Remover(unidadeHabitacional))
                    Mensagens.Sucesso(Text, string.Format(Mensagens.SUCESSO_REMOVER_UNIDADE_HABITACIONAL, unidadeHabitacional.Nome));
                else
                    Mensagens.Erro(Text, string.Format(Mensagens.ERRO_REMOVER_UNIDADE_HABITACIONAL, unidadeHabitacional.Nome));
            }

            ShowDataGrid();
        }

        private void gridUnidadesHabitacionais_CustomFiltering(object sender, GridViewCustomFilteringEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisar.Text))
            {
                e.Visible = true;
                for (int i = 0; i < gridUnidadesHabitacionais.ColumnCount; i++)
                {
                    e.Row.Cells[i].Style.Reset();
                    e.Row.InvalidateRow();
                }
                return;
            }

            e.Visible = false;
            for (int i = 0; i < gridUnidadesHabitacionais.ColumnCount; i++)
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
            gridUnidadesHabitacionais.DataSource = UnidadeHabitacionalBusiness.GetUnidadesHabitacionais();
            btnRemover.Enabled = btnEditar.Enabled = gridUnidadesHabitacionais.RowCount > 0;
            for (int i = 0; i < gridUnidadesHabitacionais.ColumnCount; i++) gridUnidadesHabitacionais.Columns[i].BestFit();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            gridUnidadesHabitacionais.MasterTemplate.Refresh();
        }
    }
}