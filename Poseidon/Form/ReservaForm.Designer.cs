namespace Poseidon.Form
{
    partial class ReservaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblValidade = new Telerik.WinControls.UI.RadLabel();
            this.lblHora = new Telerik.WinControls.UI.RadLabel();
            this.lblEntrada = new Telerik.WinControls.UI.RadLabel();
            this.lblSaida = new Telerik.WinControls.UI.RadLabel();
            this.lblUH = new Telerik.WinControls.UI.RadLabel();
            this.lblCliente = new Telerik.WinControls.UI.RadLabel();
            this.lblValor = new Telerik.WinControls.UI.RadLabel();
            this.lblDesconto = new Telerik.WinControls.UI.RadLabel();
            this.lblTotal = new Telerik.WinControls.UI.RadLabel();
            this.txtReservaConfirmada = new Telerik.WinControls.UI.RadCheckBox();
            this.txtValidade = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtHora = new Telerik.WinControls.UI.RadSpinEditor();
            this.txtMinuto = new Telerik.WinControls.UI.RadSpinEditor();
            this.txtEntrada = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtSaida = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtUH = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.txtClienteID = new Telerik.WinControls.UI.RadTextBox();
            this.txtClienteNome = new Telerik.WinControls.UI.RadTextBox();
            this.txtValor = new Telerik.WinControls.UI.RadTextBox();
            this.txtDesconto = new Telerik.WinControls.UI.RadSpinEditor();
            this.txtTotal = new Telerik.WinControls.UI.RadTextBox();
            this.txtObservacoes = new Telerik.WinControls.UI.RadTextBox();
            this.btnAddCliente = new Telerik.WinControls.UI.RadButton();
            this.btnListCliente = new Telerik.WinControls.UI.RadButton();
            this.rgbGerais = new Telerik.WinControls.UI.RadGroupBox();
            this.rgbObservacoes = new Telerik.WinControls.UI.RadGroupBox();
            this.btnSalvar = new Telerik.WinControls.UI.RadButton();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.epReservaForm = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lblValidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSaida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReservaConfirmada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUH.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUH.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnListCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbGerais)).BeginInit();
            this.rgbGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbObservacoes)).BeginInit();
            this.rgbObservacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epReservaForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValidade
            // 
            this.lblValidade.Location = new System.Drawing.Point(8, 49);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(52, 18);
            this.lblValidade.TabIndex = 1;
            this.lblValidade.Text = "Validade:";
            // 
            // lblHora
            // 
            this.lblHora.Location = new System.Drawing.Point(192, 49);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 18);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora:";
            // 
            // lblEntrada
            // 
            this.lblEntrada.Location = new System.Drawing.Point(13, 75);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(47, 18);
            this.lblEntrada.TabIndex = 6;
            this.lblEntrada.Text = "Entrada:";
            // 
            // lblSaida
            // 
            this.lblSaida.Location = new System.Drawing.Point(189, 75);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(36, 18);
            this.lblSaida.TabIndex = 8;
            this.lblSaida.Text = "Saída:";
            // 
            // lblUH
            // 
            this.lblUH.Location = new System.Drawing.Point(31, 101);
            this.lblUH.Name = "lblUH";
            this.lblUH.Size = new System.Drawing.Size(29, 18);
            this.lblUH.TabIndex = 10;
            this.lblUH.Text = "U.H.:";
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(17, 131);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(43, 18);
            this.lblCliente.TabIndex = 12;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblValor
            // 
            this.lblValor.Location = new System.Drawing.Point(25, 157);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(35, 18);
            this.lblValor.TabIndex = 17;
            this.lblValor.Text = "Valor:";
            // 
            // lblDesconto
            // 
            this.lblDesconto.Location = new System.Drawing.Point(215, 157);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(56, 18);
            this.lblDesconto.TabIndex = 19;
            this.lblDesconto.Text = "Desconto:";
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(26, 183);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 18);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total:";
            // 
            // txtReservaConfirmada
            // 
            this.txtReservaConfirmada.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservaConfirmada.Location = new System.Drawing.Point(66, 23);
            this.txtReservaConfirmada.Name = "txtReservaConfirmada";
            this.txtReservaConfirmada.Size = new System.Drawing.Size(126, 18);
            this.txtReservaConfirmada.TabIndex = 0;
            this.txtReservaConfirmada.Text = "Reserva confirmada";
            this.txtReservaConfirmada.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.txtReservaConfirmada_ToggleStateChanged);
            // 
            // txtValidade
            // 
            this.txtValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtValidade.Location = new System.Drawing.Point(66, 47);
            this.txtValidade.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtValidade.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtValidade.Name = "txtValidade";
            this.txtValidade.NullableValue = new System.DateTime(2013, 8, 25, 11, 51, 44, 700);
            this.txtValidade.NullDate = new System.DateTime(((long)(0)));
            this.txtValidade.Size = new System.Drawing.Size(100, 20);
            this.txtValidade.TabIndex = 2;
            this.txtValidade.TabStop = false;
            this.txtValidade.Text = "25/08/2013";
            this.txtValidade.Value = new System.DateTime(2013, 8, 25, 11, 51, 44, 700);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(231, 47);
            this.txtHora.Name = "txtHora";
            // 
            // 
            // 
            this.txtHora.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.txtHora.ShowBorder = true;
            this.txtHora.Size = new System.Drawing.Size(47, 20);
            this.txtHora.TabIndex = 4;
            this.txtHora.TabStop = false;
            // 
            // txtMinuto
            // 
            this.txtMinuto.Location = new System.Drawing.Point(284, 47);
            this.txtMinuto.Name = "txtMinuto";
            // 
            // 
            // 
            this.txtMinuto.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.txtMinuto.ShowBorder = true;
            this.txtMinuto.Size = new System.Drawing.Size(47, 20);
            this.txtMinuto.TabIndex = 5;
            this.txtMinuto.TabStop = false;
            // 
            // txtEntrada
            // 
            this.txtEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEntrada.Location = new System.Drawing.Point(66, 73);
            this.txtEntrada.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtEntrada.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.NullableValue = new System.DateTime(2013, 8, 25, 11, 51, 44, 778);
            this.txtEntrada.NullDate = new System.DateTime(((long)(0)));
            this.txtEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada.TabIndex = 7;
            this.txtEntrada.TabStop = false;
            this.txtEntrada.Text = "25/08/2013";
            this.txtEntrada.Value = new System.DateTime(2013, 8, 25, 11, 51, 44, 778);
            this.txtEntrada.ValueChanged += new System.EventHandler(this.txtEntrada_ValueChanged);
            // 
            // txtSaida
            // 
            this.txtSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtSaida.Location = new System.Drawing.Point(231, 73);
            this.txtSaida.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtSaida.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.NullableValue = new System.DateTime(2013, 8, 25, 11, 51, 44, 825);
            this.txtSaida.NullDate = new System.DateTime(((long)(0)));
            this.txtSaida.Size = new System.Drawing.Size(100, 20);
            this.txtSaida.TabIndex = 9;
            this.txtSaida.TabStop = false;
            this.txtSaida.Text = "25/08/2013";
            this.txtSaida.Value = new System.DateTime(2013, 8, 25, 11, 51, 44, 825);
            this.txtSaida.ValueChanged += new System.EventHandler(this.txtSaida_ValueChanged);
            // 
            // txtUH
            // 
            // 
            // txtUH.NestedRadGridView
            // 
            this.txtUH.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.txtUH.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUH.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUH.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.txtUH.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.txtUH.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.txtUH.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.txtUH.EditorControl.MasterTemplate.EnableGrouping = false;
            this.txtUH.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.txtUH.EditorControl.Name = "NestedRadGridView";
            this.txtUH.EditorControl.ReadOnly = true;
            this.txtUH.EditorControl.ShowGroupPanel = false;
            this.txtUH.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.txtUH.EditorControl.TabIndex = 0;
            this.txtUH.Location = new System.Drawing.Point(66, 99);
            this.txtUH.Name = "txtUH";
            // 
            // 
            // 
            this.txtUH.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.txtUH.Size = new System.Drawing.Size(265, 20);
            this.txtUH.TabIndex = 11;
            this.txtUH.TabStop = false;
            this.txtUH.SelectedValueChanged += new System.EventHandler(this.txtQuarto_SelectedValueChanged);
            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(66, 129);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(50, 20);
            this.txtClienteID.TabIndex = 13;
            this.txtClienteID.TabStop = false;
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.Location = new System.Drawing.Point(122, 129);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(149, 20);
            this.txtClienteNome.TabIndex = 14;
            this.txtClienteNome.TabStop = false;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(66, 155);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(142, 20);
            this.txtValor.TabIndex = 18;
            this.txtValor.TabStop = false;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(277, 155);
            this.txtDesconto.Name = "txtDesconto";
            // 
            // 
            // 
            this.txtDesconto.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.txtDesconto.ShowBorder = true;
            this.txtDesconto.Size = new System.Drawing.Size(54, 20);
            this.txtDesconto.TabIndex = 20;
            this.txtDesconto.TabStop = false;
            this.txtDesconto.ValueChanged += new System.EventHandler(this.txtDesconto_ValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(66, 181);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(265, 20);
            this.txtTotal.TabIndex = 22;
            this.txtTotal.TabStop = false;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(13, 23);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            // 
            // 
            // 
            this.txtObservacoes.RootElement.StretchVertically = true;
            this.txtObservacoes.Size = new System.Drawing.Size(318, 86);
            this.txtObservacoes.TabIndex = 0;
            this.txtObservacoes.TabStop = false;
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCliente.Location = new System.Drawing.Point(307, 125);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(24, 24);
            this.btnAddCliente.TabIndex = 16;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // btnListCliente
            // 
            this.btnListCliente.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnListCliente.Location = new System.Drawing.Point(277, 125);
            this.btnListCliente.Name = "btnListCliente";
            this.btnListCliente.Size = new System.Drawing.Size(24, 24);
            this.btnListCliente.TabIndex = 15;
            this.btnListCliente.Click += new System.EventHandler(this.btnListCliente_Click);
            // 
            // rgbGerais
            // 
            this.rgbGerais.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbGerais.Controls.Add(this.lblValidade);
            this.rgbGerais.Controls.Add(this.lblHora);
            this.rgbGerais.Controls.Add(this.lblEntrada);
            this.rgbGerais.Controls.Add(this.lblSaida);
            this.rgbGerais.Controls.Add(this.lblUH);
            this.rgbGerais.Controls.Add(this.lblCliente);
            this.rgbGerais.Controls.Add(this.lblValor);
            this.rgbGerais.Controls.Add(this.lblDesconto);
            this.rgbGerais.Controls.Add(this.lblTotal);
            this.rgbGerais.Controls.Add(this.txtReservaConfirmada);
            this.rgbGerais.Controls.Add(this.txtValidade);
            this.rgbGerais.Controls.Add(this.txtHora);
            this.rgbGerais.Controls.Add(this.txtMinuto);
            this.rgbGerais.Controls.Add(this.txtEntrada);
            this.rgbGerais.Controls.Add(this.txtSaida);
            this.rgbGerais.Controls.Add(this.txtUH);
            this.rgbGerais.Controls.Add(this.txtClienteID);
            this.rgbGerais.Controls.Add(this.txtClienteNome);
            this.rgbGerais.Controls.Add(this.txtValor);
            this.rgbGerais.Controls.Add(this.txtDesconto);
            this.rgbGerais.Controls.Add(this.txtTotal);
            this.rgbGerais.Controls.Add(this.btnAddCliente);
            this.rgbGerais.Controls.Add(this.btnListCliente);
            this.rgbGerais.FooterImageIndex = -1;
            this.rgbGerais.FooterImageKey = "";
            this.rgbGerais.HeaderImageIndex = -1;
            this.rgbGerais.HeaderImageKey = "";
            this.rgbGerais.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.rgbGerais.HeaderText = "Gerais";
            this.rgbGerais.Location = new System.Drawing.Point(12, 12);
            this.rgbGerais.Name = "rgbGerais";
            this.rgbGerais.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.rgbGerais.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.rgbGerais.Size = new System.Drawing.Size(344, 214);
            this.rgbGerais.TabIndex = 0;
            this.rgbGerais.Text = "Gerais";
            // 
            // rgbObservacoes
            // 
            this.rgbObservacoes.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbObservacoes.Controls.Add(this.txtObservacoes);
            this.rgbObservacoes.FooterImageIndex = -1;
            this.rgbObservacoes.FooterImageKey = "";
            this.rgbObservacoes.HeaderImageIndex = -1;
            this.rgbObservacoes.HeaderImageKey = "";
            this.rgbObservacoes.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.rgbObservacoes.HeaderText = "Observações";
            this.rgbObservacoes.Location = new System.Drawing.Point(12, 232);
            this.rgbObservacoes.Name = "rgbObservacoes";
            this.rgbObservacoes.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.rgbObservacoes.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.rgbObservacoes.Size = new System.Drawing.Size(344, 122);
            this.rgbObservacoes.TabIndex = 1;
            this.rgbObservacoes.Text = "Observações";
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(190, 360);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 24);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(276, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 24);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // epReservaForm
            // 
            this.epReservaForm.ContainerControl = this;
            // 
            // ReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 396);
            this.Controls.Add(this.rgbGerais);
            this.Controls.Add(this.rgbObservacoes);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(376, 430);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(376, 430);
            this.Name = "ReservaForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(376, 430);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reserva";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.lblValidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSaida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReservaConfirmada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUH.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUH.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnListCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbGerais)).EndInit();
            this.rgbGerais.ResumeLayout(false);
            this.rgbGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbObservacoes)).EndInit();
            this.rgbObservacoes.ResumeLayout(false);
            this.rgbObservacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epReservaForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblValidade;
        private Telerik.WinControls.UI.RadLabel lblHora;
        private Telerik.WinControls.UI.RadLabel lblEntrada;
        private Telerik.WinControls.UI.RadLabel lblSaida;
        private Telerik.WinControls.UI.RadLabel lblUH;
        private Telerik.WinControls.UI.RadLabel lblCliente;
        private Telerik.WinControls.UI.RadLabel lblValor;
        private Telerik.WinControls.UI.RadLabel lblDesconto;
        private Telerik.WinControls.UI.RadLabel lblTotal;
        private Telerik.WinControls.UI.RadCheckBox txtReservaConfirmada;
        private Telerik.WinControls.UI.RadDateTimePicker txtValidade;
        private Telerik.WinControls.UI.RadSpinEditor txtHora;
        private Telerik.WinControls.UI.RadSpinEditor txtMinuto;
        private Telerik.WinControls.UI.RadDateTimePicker txtEntrada;
        private Telerik.WinControls.UI.RadDateTimePicker txtSaida;
        private Telerik.WinControls.UI.RadMultiColumnComboBox txtUH;
        private Telerik.WinControls.UI.RadTextBox txtClienteID;
        private Telerik.WinControls.UI.RadTextBox txtClienteNome;
        private Telerik.WinControls.UI.RadTextBox txtValor;
        private Telerik.WinControls.UI.RadSpinEditor txtDesconto;
        private Telerik.WinControls.UI.RadTextBox txtTotal;
        private Telerik.WinControls.UI.RadTextBox txtObservacoes;
        private Telerik.WinControls.UI.RadButton btnAddCliente;
        private Telerik.WinControls.UI.RadButton btnListCliente;
        private Telerik.WinControls.UI.RadGroupBox rgbGerais;
        private Telerik.WinControls.UI.RadGroupBox rgbObservacoes;
        private Telerik.WinControls.UI.RadButton btnSalvar;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private System.Windows.Forms.ErrorProvider epReservaForm;
    }
}