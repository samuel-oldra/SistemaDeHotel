namespace Poseidon.Form
{
    partial class TipoUnidadeHabitacionalForm
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
            this.lblNome = new Telerik.WinControls.UI.RadLabel();
            this.lblDiaria = new Telerik.WinControls.UI.RadLabel();
            this.txtNome = new Telerik.WinControls.UI.RadTextBox();
            this.txtDiaria = new Telerik.WinControls.UI.RadTextBox();
            this.rgbGerais = new Telerik.WinControls.UI.RadGroupBox();
            this.btnSalvar = new Telerik.WinControls.UI.RadButton();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.epTipoUnidadeHabitacionalForm = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lblNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDiaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbGerais)).BeginInit();
            this.rgbGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTipoUnidadeHabitacionalForm)).BeginInit();
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
            // lblDiaria
            // 
            this.lblDiaria.Location = new System.Drawing.Point(14, 52);
            this.lblDiaria.Name = "lblDiaria";
            this.lblDiaria.Size = new System.Drawing.Size(38, 18);
            this.lblDiaria.TabIndex = 2;
            this.lblDiaria.Text = "Diária:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.NullText = "Identificação do Tipo da U.H.";
            this.txtNome.Size = new System.Drawing.Size(197, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TabStop = false;
            // 
            // txtDiaria
            // 
            this.txtDiaria.Location = new System.Drawing.Point(58, 50);
            this.txtDiaria.Name = "txtDiaria";
            this.txtDiaria.Size = new System.Drawing.Size(197, 20);
            this.txtDiaria.TabIndex = 3;
            this.txtDiaria.TabStop = false;
            // 
            // rgbGerais
            // 
            this.rgbGerais.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbGerais.Controls.Add(this.lblNome);
            this.rgbGerais.Controls.Add(this.lblDiaria);
            this.rgbGerais.Controls.Add(this.txtNome);
            this.rgbGerais.Controls.Add(this.txtDiaria);
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
            this.rgbGerais.Size = new System.Drawing.Size(268, 83);
            this.rgbGerais.TabIndex = 0;
            this.rgbGerais.Text = "Gerais";
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(114, 102);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 24);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(200, 102);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 24);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // epTipoUnidadeHabitacionalForm
            // 
            this.epTipoUnidadeHabitacionalForm.ContainerControl = this;
            // 
            // TipoUnidadeHabitacionalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 138);
            this.Controls.Add(this.rgbGerais);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 172);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 172);
            this.Name = "TipoUnidadeHabitacionalForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(300, 172);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tipo de Unidade Habitacional";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.lblNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDiaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbGerais)).EndInit();
            this.rgbGerais.ResumeLayout(false);
            this.rgbGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTipoUnidadeHabitacionalForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblNome;
        private Telerik.WinControls.UI.RadLabel lblDiaria;
        private Telerik.WinControls.UI.RadTextBox txtNome;
        private Telerik.WinControls.UI.RadTextBox txtDiaria;
        private Telerik.WinControls.UI.RadGroupBox rgbGerais;
        private Telerik.WinControls.UI.RadButton btnSalvar;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private System.Windows.Forms.ErrorProvider epTipoUnidadeHabitacionalForm;
    }
}