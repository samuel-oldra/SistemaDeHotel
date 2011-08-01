using Poseidon.Base;
using Poseidon.Business;
using Poseidon.Entity;
using Poseidon.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Settings = Poseidon.Base.Settings;

namespace Poseidon.Form
{
    public partial class ClienteFormList : RadForm
    {
        public ClienteFormList(bool list = true)
        {
            InitializeComponent();

            Icon = Resources.FormList;
            btnAdicionar.Image = Resources.Adicionar;
            btnRemover.Image = Resources.Remover;
            btnEditar.Image = Resources.Editar;
            btnFechar.Image = Resources.Cancelar;

            gridClientes.AllowAddNewRow = false;
            gridClientes.AllowDeleteRow = false;
            gridClientes.AllowEditRow = false;
            gridClientes.EnableCustomFiltering = true;
            gridClientes.EnableFiltering = true;
            gridClientes.EnableHotTracking = true;
            gridClientes.ShowFilteringRow = false;

            gridClientes.Columns.Add("ID", "ID", "ID");
            gridClientes.Columns.Add("Cliente", "Hóspede", "Cliente");
            gridClientes.Columns.Add("CPF", "CPF", "CPF");
            gridClientes.Columns.Add("RG", "RG", "RG");
            gridClientes.Columns.Add("Nascimento", "Nascimento", "Nascimento");
            gridClientes.Columns.Add("Sexo", "Sexo", "Sexo");
            gridClientes.Columns.Add("Profissao", "Profissão", "Profissao");
            gridClientes.Columns.Add("Veiculo", "Veículo", "Veiculo");
            gridClientes.Columns.Add("Placa", "Placa", "Placa");
            gridClientes.Columns.Add("Email", "E-mail", "Email");
            gridClientes.Columns.Add("FoneCelular", "Tel. Celular", "FoneCelular");
            gridClientes.Columns.Add("FoneResidencial", "Tel. Residencial", "FoneResidencial");
            gridClientes.Columns.Add("FoneComercial", "Tel. Comercial", "FoneComercial");
            gridClientes.Columns.Add("Ramal", "Ramal", "Ramal");
            gridClientes.Columns.Add("Endereco", "Endereço", "Endereco");
            gridClientes.Columns.Add("Bairro", "Bairro", "Bairro");
            gridClientes.Columns.Add("Cidade", "Cidade", "Cidade");
            gridClientes.Columns.Add("Estado", "Estado", "Estado");
            gridClientes.Columns.Add("Pais", "País", "Pais");
            gridClientes.Columns.Add("CEP", "CEP", "CEP");
            gridClientes.Columns.Add("PontoRef", "Ponto Ref.", "PontoRef");
            gridClientes.Columns.Add("Observacoes", "Observações", "Observacoes");

            if (list == false)
            {
                btnEditar.Text = "OK";
                btnEditar.Click -= btnEditar_Click;
                btnEditar.Click += btnOK_Click;
                btnEditar.Image = Resources.OK;

                btnAdicionar.Visible = btnRemover.Visible = false;
            }

            ShowDataGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new ClienteForm().ShowDialog();
            ShowDataGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var cliente = (ClienteEntity)gridClientes.SelectedRows[0].DataBoundItem;
            new ClienteForm(cliente).ShowDialog();
            ShowDataGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var cliente = (ClienteEntity)gridClientes.SelectedRows[0].DataBoundItem;
            Settings.Cliente = cliente;
            Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var cliente = (ClienteEntity)gridClientes.SelectedRows[0].DataBoundItem;

            DialogResult result = Mensagens.Questao(Text, string.Format(Mensagens.QUESTAO_REMOVER_CLIENTE, cliente.Cliente));
            if (result == DialogResult.Yes)
            {
                if (ClienteBusiness.Remover(cliente))
                    Mensagens.Sucesso(Text, string.Format(Mensagens.SUCESSO_REMOVER_CLIENTE, cliente.Cliente));
                else
                    Mensagens.Erro(Text, string.Format(Mensagens.ERRO_REMOVER_CLIENTE, cliente.Cliente));
            }

            ShowDataGrid();
        }

        private void gridClientes_CustomFiltering(object sender, GridViewCustomFilteringEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisar.Text))
            {
                e.Visible = true;
                for (int i = 0; i < gridClientes.ColumnCount; i++)
                {
                    e.Row.Cells[i].Style.Reset();
                    e.Row.InvalidateRow();
                }
                return;
            }

            e.Visible = false;
            for (int i = 0; i < gridClientes.ColumnCount; i++)
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
            gridClientes.DataSource = ClienteBusiness.GetClientes();
            btnRemover.Enabled = btnEditar.Enabled = gridClientes.RowCount > 0;
            for (int i = 0; i < gridClientes.ColumnCount; i++) gridClientes.Columns[i].BestFit();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            gridClientes.MasterTemplate.Refresh();
        }
    }
}