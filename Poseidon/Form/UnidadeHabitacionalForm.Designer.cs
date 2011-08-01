namespace Poseidon.Form
{
    partial class UnidadeHabitacionalForm
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.lblNome = new Telerik.WinControls.UI.RadLabel();
            this.lblTipo = new Telerik.WinControls.UI.RadLabel();
            this.lblSituacao = new Telerik.WinControls.UI.RadLabel();
            this.lblRamal = new Telerik.WinControls.UI.RadLabel();
            this.txtNome = new Telerik.WinControls.UI.RadTextBox();
            this.txtTipo = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.txtSituacao = new Telerik.WinControls.UI.RadDropDownList();
            this.txtRamal = new Telerik.WinControls.UI.RadTextBox();
            this.txtCaracteristicas = new Telerik.WinControls.UI.RadTextBox();
            this.rgbGerais = new Telerik.WinControls.UI.RadGroupBox();
            this.rgbCaracteristicas = new Telerik.WinControls.UI.RadGroupBox();
            this.btnSalvar = new Telerik.WinControls.UI.RadButton();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.epUnidadeHabitacionalForm = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lblNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSituacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRamal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSituacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRamal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaracteristicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbGerais)).BeginInit();
            this.rgbGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbCaracteristicas)).BeginInit();
            this.rgbCaracteristicas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUnidadeHabitacionalForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(13, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(21, 52);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 18);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.Location = new System.Drawing.Point(184, 52);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(51, 18);
            this.lblSituacao.TabIndex = 4;
            this.lblSituacao.Text = "Situação:";
            // 
            // lblRamal
            // 
            this.lblRamal.Location = new System.Drawing.Point(370, 52);
            this.lblRamal.Name = "lblRamal";
            this.lblRamal.Size = new System.Drawing.Size(39, 18);
            this.lblRamal.TabIndex = 6;
            this.lblRamal.Text = "Ramal:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.NullText = "Identificação da Unidade Habitacional";
            this.txtNome.Size = new System.Drawing.Size(417, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TabStop = false;
            // 
            // txtTipo
            // 
            // 
            // txtTipo.NestedRadGridView
            // 
            this.txtTipo.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipo.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTipo.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.txtTipo.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.txtTipo.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.txtTipo.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.txtTipo.EditorControl.MasterTemplate.EnableGrouping = false;
            this.txtTipo.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.txtTipo.EditorControl.Name = "NestedRadGridView";
            this.txtTipo.EditorControl.ReadOnly = true;
            this.txtTipo.EditorControl.ShowGroupPanel = false;
            this.txtTipo.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.txtTipo.EditorControl.TabIndex = 0;
            this.txtTipo.Location = new System.Drawing.Point(58, 50);
            this.txtTipo.Name = "txtTipo";
            // 
            // 
            // 
            this.txtTipo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.txtTipo.Size = new System.Drawing.Size(120, 20);
            this.txtTipo.TabIndex = 3;
            this.txtTipo.TabStop = false;
            // 
            // txtSituacao
            // 
            this.txtSituacao.DropDownAnimationEnabled = true;
            radListDataItem2.Selected = true;
            radListDataItem2.Text = "Disponível";
            radListDataItem2.TextWrap = true;
            this.txtSituacao.Items.Add(radListDataItem2);
            this.txtSituacao.Location = new System.Drawing.Point(241, 50);
            this.txtSituacao.MaxDropDownItems = 0;
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.ShowImageInEditorArea = true;
            this.txtSituacao.Size = new System.Drawing.Size(120, 20);
            this.txtSituacao.TabIndex = 5;
            this.txtSituacao.Text = "Disponível";
            // 
            // txtRamal
            // 
            this.txtRamal.Location = new System.Drawing.Point(415, 50);
            this.txtRamal.Name = "txtRamal";
            this.txtRamal.Size = new System.Drawing.Size(60, 20);
            this.txtRamal.TabIndex = 7;
            this.txtRamal.TabStop = false;
            // 
            // txtCaracteristicas
            // 
            this.txtCaracteristicas.Location = new System.Drawing.Point(13, 23);
            this.txtCaracteristicas.Multiline = true;
            this.txtCaracteristicas.Name = "txtCaracteristicas";
            // 
            // 
            // 
            this.txtCaracteristicas.RootElement.StretchVertically = true;
            this.txtCaracteristicas.Size = new System.Drawing.Size(462, 67);
            this.txtCaracteristicas.TabIndex = 0;
            this.txtCaracteristicas.TabStop = false;
            // 
            // rgbGerais
            // 
            this.rgbGerais.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbGerais.Controls.Add(this.lblNome);
            this.rgbGerais.Controls.Add(this.lblTipo);
            this.rgbGerais.Controls.Add(this.lblSituacao);
            this.rgbGerais.Controls.Add(this.lblRamal);
            this.rgbGerais.Controls.Add(this.txtNome);
            this.rgbGerais.Controls.Add(this.txtTipo);
            this.rgbGerais.Controls.Add(this.txtSituacao);
            this.rgbGerais.Controls.Add(this.txtRamal);
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
            this.rgbGerais.Size = new System.Drawing.Size(488, 83);
            this.rgbGerais.TabIndex = 0;
            this.rgbGerais.Text = "Gerais";
            // 
            // rgbCaracteristicas
            // 
            this.rgbCaracteristicas.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbCaracteristicas.Controls.Add(this.txtCaracteristicas);
            this.rgbCaracteristicas.FooterImageIndex = -1;
            this.rgbCaracteristicas.FooterImageKey = "";
            this.rgbCaracteristicas.HeaderImageIndex = -1;
            this.rgbCaracteristicas.HeaderImageKey = "";
            this.rgbCaracteristicas.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.rgbCaracteristicas.HeaderText = "Características";
            this.rgbCaracteristicas.Location = new System.Drawing.Point(12, 101);
            this.rgbCaracteristicas.Name = "rgbCaracteristicas";
            this.rgbCaracteristicas.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.rgbCaracteristicas.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.rgbCaracteristicas.Size = new System.Drawing.Size(488, 103);
            this.rgbCaracteristicas.TabIndex = 1;
            this.rgbCaracteristicas.Text = "Características";
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(334, 210);
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
            this.btnCancelar.Location = new System.Drawing.Point(420, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 24);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // epUnidadeHabitacionalForm
            // 
            this.epUnidadeHabitacionalForm.ContainerControl = this;
            // 
            // UnidadeHabitacionalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 246);
            this.Controls.Add(this.rgbGerais);
            this.Controls.Add(this.rgbCaracteristicas);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 280);
            this.Name = "UnidadeHabitacionalForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(520, 280);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unidade Habitacional";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.lblNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSituacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRamal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSituacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRamal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaracteristicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbGerais)).EndInit();
            this.rgbGerais.ResumeLayout(false);
            this.rgbGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbCaracteristicas)).EndInit();
            this.rgbCaracteristicas.ResumeLayout(false);
            this.rgbCaracteristicas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUnidadeHabitacionalForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblNome;
        private Telerik.WinControls.UI.RadLabel lblTipo;
        private Telerik.WinControls.UI.RadLabel lblSituacao;
        private Telerik.WinControls.UI.RadLabel lblRamal;
        private Telerik.WinControls.UI.RadTextBox txtNome;
        private Telerik.WinControls.UI.RadMultiColumnComboBox txtTipo;
        private Telerik.WinControls.UI.RadDropDownList txtSituacao;
        private Telerik.WinControls.UI.RadTextBox txtRamal;
        private Telerik.WinControls.UI.RadTextBox txtCaracteristicas;
        private Telerik.WinControls.UI.RadGroupBox rgbGerais;
        private Telerik.WinControls.UI.RadGroupBox rgbCaracteristicas;
        private Telerik.WinControls.UI.RadButton btnSalvar;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private System.Windows.Forms.ErrorProvider epUnidadeHabitacionalForm;
    }
}