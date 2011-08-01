namespace Poseidon.Form
{
    partial class PrincipalForm
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
            this.radRibbonBarPrincipal = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTabInicio = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroupCadastro = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarGroupOperacao = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnClientes = new Telerik.WinControls.UI.RadButtonElement();
            this.btnReserva = new Telerik.WinControls.UI.RadButtonElement();
            this.btnWalkIn = new Telerik.WinControls.UI.RadButtonElement();
            this.btnCheck = new Telerik.WinControls.UI.RadButtonElement();
            this.rmiUnidadesHabitacionais = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiTiposUnidadesHabitacionais = new Telerik.WinControls.UI.RadMenuItem();
            this.radStatusStripPrincipal = new Telerik.WinControls.UI.RadStatusStrip();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBarPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStripPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBarPrincipal
            // 
            this.radRibbonBarPrincipal.AutoSize = true;
            this.radRibbonBarPrincipal.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTabInicio});
            // 
            // 
            // 
            this.radRibbonBarPrincipal.ExitButton.AccessibleDescription = "Exit";
            this.radRibbonBarPrincipal.ExitButton.AccessibleName = "Exit";
            // 
            // 
            // 
            this.radRibbonBarPrincipal.ExitButton.ButtonElement.AccessibleDescription = "Exit";
            this.radRibbonBarPrincipal.ExitButton.ButtonElement.AccessibleName = "Exit";
            this.radRibbonBarPrincipal.ExitButton.ButtonElement.Class = "RadMenuButtonElement";
            this.radRibbonBarPrincipal.ExitButton.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radRibbonBarPrincipal.ExitButton.Text = "Exit";
            this.radRibbonBarPrincipal.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBarPrincipal.Name = "radRibbonBarPrincipal";
            // 
            // 
            // 
            this.radRibbonBarPrincipal.OptionsButton.AccessibleDescription = "Options";
            this.radRibbonBarPrincipal.OptionsButton.AccessibleName = "Options";
            // 
            // 
            // 
            this.radRibbonBarPrincipal.OptionsButton.ButtonElement.AccessibleDescription = "Options";
            this.radRibbonBarPrincipal.OptionsButton.ButtonElement.AccessibleName = "Options";
            this.radRibbonBarPrincipal.OptionsButton.ButtonElement.Class = "RadMenuButtonElement";
            this.radRibbonBarPrincipal.OptionsButton.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radRibbonBarPrincipal.OptionsButton.Text = "Options";
            // 
            // 
            // 
            this.radRibbonBarPrincipal.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radRibbonBarPrincipal.Size = new System.Drawing.Size(742, 154);
            this.radRibbonBarPrincipal.StartButtonImage = null;
            this.radRibbonBarPrincipal.StartMenuItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.rmiUnidadesHabitacionais,
            this.rmiTiposUnidadesHabitacionais});
            this.radRibbonBarPrincipal.TabIndex = 0;
            this.radRibbonBarPrincipal.Text = "Poseidon";
            // 
            // ribbonTabInicio
            // 
            this.ribbonTabInicio.AccessibleDescription = "Início";
            this.ribbonTabInicio.AccessibleName = "Início";
            this.ribbonTabInicio.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.ribbonTabInicio.Class = "RibbonTab";
            this.ribbonTabInicio.IsSelected = true;
            this.ribbonTabInicio.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroupCadastro,
            this.radRibbonBarGroupOperacao});
            this.ribbonTabInicio.Name = "ribbonTabInicio";
            this.ribbonTabInicio.StretchHorizontally = false;
            this.ribbonTabInicio.Text = "Início";
            this.ribbonTabInicio.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRibbonBarGroupCadastro
            // 
            this.radRibbonBarGroupCadastro.AccessibleDescription = "Cadastro";
            this.radRibbonBarGroupCadastro.AccessibleName = "Cadastro";
            this.radRibbonBarGroupCadastro.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnClientes});
            this.radRibbonBarGroupCadastro.Name = "radRibbonBarGroupCadastro";
            this.radRibbonBarGroupCadastro.Text = "Cadastro";
            this.radRibbonBarGroupCadastro.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRibbonBarGroupOperacao
            // 
            this.radRibbonBarGroupOperacao.AccessibleDescription = "Operação";
            this.radRibbonBarGroupOperacao.AccessibleName = "Operação";
            this.radRibbonBarGroupOperacao.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnReserva,
            this.btnWalkIn,
            this.btnCheck});
            this.radRibbonBarGroupOperacao.Name = "radRibbonBarGroupOperacao";
            this.radRibbonBarGroupOperacao.Text = "Operação";
            this.radRibbonBarGroupOperacao.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnClientes
            // 
            this.btnClientes.AccessibleDescription = "Clientes";
            this.btnClientes.AccessibleName = "Clientes";
            this.btnClientes.Class = "RibbonBarButtonElement";
            this.btnClientes.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.AccessibleDescription = "Reserva";
            this.btnReserva.AccessibleName = "Reserva";
            this.btnReserva.Class = "RibbonBarButtonElement";
            this.btnReserva.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnReserva.Text = "Reserva";
            this.btnReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReserva.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnWalkIn
            // 
            this.btnWalkIn.AccessibleDescription = "Walk-In";
            this.btnWalkIn.AccessibleName = "Walk-In";
            this.btnWalkIn.Class = "RibbonBarButtonElement";
            this.btnWalkIn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWalkIn.Name = "btnWalkIn";
            this.btnWalkIn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnWalkIn.Text = "Walk-In";
            this.btnWalkIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWalkIn.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnWalkIn.Click += new System.EventHandler(this.btnWalkIn_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.AccessibleDescription = "Check";
            this.btnCheck.AccessibleName = "Check";
            this.btnCheck.Class = "RibbonBarButtonElement";
            this.btnCheck.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCheck.Text = "Check";
            this.btnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCheck.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // rmiUnidadesHabitacionais
            // 
            this.rmiUnidadesHabitacionais.AccessibleDescription = "Unidades Habitacionais";
            this.rmiUnidadesHabitacionais.AccessibleName = "Unidades Habitacionais";
            this.rmiUnidadesHabitacionais.Name = "rmiUnidadesHabitacionais";
            this.rmiUnidadesHabitacionais.Text = "Unidades Habitacionais";
            this.rmiUnidadesHabitacionais.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiUnidadesHabitacionais.Click += new System.EventHandler(this.rmiUnidadesHabitacionais_Click);
            // 
            // rmiTiposUnidadesHabitacionais
            // 
            this.rmiTiposUnidadesHabitacionais.AccessibleDescription = "rmiTiposUnidadesHabitacionais";
            this.rmiTiposUnidadesHabitacionais.AccessibleName = "rmiTiposUnidadesHabitacionais";
            this.rmiTiposUnidadesHabitacionais.Name = "rmiTiposUnidadesHabitacionais";
            this.rmiTiposUnidadesHabitacionais.Text = "Tipos de Unidades Habitacionais";
            this.rmiTiposUnidadesHabitacionais.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rmiTiposUnidadesHabitacionais.Click += new System.EventHandler(this.rmiTiposUnidadesHabitacionais_Click);
            // 
            // radStatusStripPrincipal
            // 
            this.radStatusStripPrincipal.AutoSize = true;
            this.radStatusStripPrincipal.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.radStatusStripPrincipal.Location = new System.Drawing.Point(0, 521);
            this.radStatusStripPrincipal.Name = "radStatusStripPrincipal";
            this.radStatusStripPrincipal.Size = new System.Drawing.Size(742, 24);
            this.radStatusStripPrincipal.SizingGrip = false;
            this.radStatusStripPrincipal.TabIndex = 2;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(742, 521);
            this.panelPrincipal.TabIndex = 1;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 545);
            this.Controls.Add(this.radRibbonBarPrincipal);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.radStatusStripPrincipal);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "PrincipalForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poseidon";
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBarPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStripPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBarPrincipal;
        private Telerik.WinControls.UI.RibbonTab ribbonTabInicio;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroupCadastro;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroupOperacao;
        private Telerik.WinControls.UI.RadButtonElement btnClientes;
        private Telerik.WinControls.UI.RadButtonElement btnReserva;
        private Telerik.WinControls.UI.RadButtonElement btnWalkIn;
        private Telerik.WinControls.UI.RadButtonElement btnCheck;
        private Telerik.WinControls.UI.RadMenuItem rmiUnidadesHabitacionais;
        private Telerik.WinControls.UI.RadMenuItem rmiTiposUnidadesHabitacionais;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStripPrincipal;
        private System.Windows.Forms.Panel panelPrincipal;
    }
}