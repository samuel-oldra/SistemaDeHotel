namespace Poseidon.Form
{
    partial class UnidadeHabitacionalFormList
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
            this.lblPesquisar = new Telerik.WinControls.UI.RadLabel();
            this.txtPesquisar = new Telerik.WinControls.UI.RadTextBox();
            this.gridUnidadesHabitacionais = new Telerik.WinControls.UI.RadGridView();
            this.btnAdicionar = new Telerik.WinControls.UI.RadButton();
            this.btnRemover = new Telerik.WinControls.UI.RadButton();
            this.btnEditar = new Telerik.WinControls.UI.RadButton();
            this.btnFechar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.lblPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnidadesHabitacionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnidadesHabitacionais.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.Location = new System.Drawing.Point(12, 14);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(56, 18);
            this.lblPesquisar.TabIndex = 0;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(74, 12);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.NullText = "Digite aqui sua pesquisa";
            this.txtPesquisar.Size = new System.Drawing.Size(606, 20);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.TabStop = false;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // gridUnidadesHabitacionais
            // 
            this.gridUnidadesHabitacionais.Location = new System.Drawing.Point(12, 38);
            this.gridUnidadesHabitacionais.Name = "gridUnidadesHabitacionais";
            this.gridUnidadesHabitacionais.Size = new System.Drawing.Size(668, 416);
            this.gridUnidadesHabitacionais.TabIndex = 2;
            this.gridUnidadesHabitacionais.CustomFiltering += new Telerik.WinControls.UI.GridViewCustomFilteringEventHandler(this.gridUnidadesHabitacionais_CustomFiltering);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.Location = new System.Drawing.Point(302, 460);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(90, 24);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.Location = new System.Drawing.Point(398, 460);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(90, 24);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(494, 460);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 24);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.Location = new System.Drawing.Point(590, 460);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(90, 24);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // UnidadeHabitacionalFormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 496);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.gridUnidadesHabitacionais);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnFechar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 530);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 530);
            this.Name = "UnidadeHabitacionalFormList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(700, 530);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Unidades Habitacionais";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.lblPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnidadesHabitacionais.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnidadesHabitacionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblPesquisar;
        private Telerik.WinControls.UI.RadTextBox txtPesquisar;
        private Telerik.WinControls.UI.RadGridView gridUnidadesHabitacionais;
        private Telerik.WinControls.UI.RadButton btnAdicionar;
        private Telerik.WinControls.UI.RadButton btnRemover;
        private Telerik.WinControls.UI.RadButton btnEditar;
        private Telerik.WinControls.UI.RadButton btnFechar;
    }
}