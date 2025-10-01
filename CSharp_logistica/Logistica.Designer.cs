namespace CSharp_logistica
{
    partial class form_logistica
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_logistica));
            tb_view = new TabControl();
            tb_veiculo = new TabPage();
            dgv_veiculos = new DataGridView();
            bt_edtveiculo = new Button();
            bt_delveiculo = new Button();
            bt_showveiculos = new Button();
            bt_cadveiculo = new Button();
            txtbox_cargamaxima = new TextBox();
            lb_cargamaxima = new Label();
            txtbox_consumomedio = new TextBox();
            lb_cosumoMedio = new Label();
            txtbox_placaveiculo = new TextBox();
            lb_placaveiculo = new Label();
            txtbox_modeloveiculo = new TextBox();
            lb_modeloveiculo = new Label();
            txtbox_idveiculo = new TextBox();
            lb_veiculoID = new Label();
            tb_motorista = new TabPage();
            tb_rota = new TabPage();
            tb_combustivel = new TabPage();
            tb_viagem = new TabPage();
            tb_view.SuspendLayout();
            tb_veiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_veiculos).BeginInit();
            SuspendLayout();
            // 
            // tb_view
            // 
            tb_view.AccessibleRole = AccessibleRole.Grip;
            tb_view.Controls.Add(tb_veiculo);
            tb_view.Controls.Add(tb_motorista);
            tb_view.Controls.Add(tb_rota);
            tb_view.Controls.Add(tb_combustivel);
            tb_view.Controls.Add(tb_viagem);
            tb_view.Font = new Font("Arial", 12F);
            tb_view.Location = new Point(12, 12);
            tb_view.Name = "tb_view";
            tb_view.SelectedIndex = 0;
            tb_view.Size = new Size(755, 594);
            tb_view.TabIndex = 0;
            // 
            // tb_veiculo
            // 
            tb_veiculo.BackColor = Color.Transparent;
            tb_veiculo.BackgroundImage = (Image)resources.GetObject("tb_veiculo.BackgroundImage");
            tb_veiculo.Controls.Add(dgv_veiculos);
            tb_veiculo.Controls.Add(bt_edtveiculo);
            tb_veiculo.Controls.Add(bt_delveiculo);
            tb_veiculo.Controls.Add(bt_showveiculos);
            tb_veiculo.Controls.Add(bt_cadveiculo);
            tb_veiculo.Controls.Add(txtbox_cargamaxima);
            tb_veiculo.Controls.Add(lb_cargamaxima);
            tb_veiculo.Controls.Add(txtbox_consumomedio);
            tb_veiculo.Controls.Add(lb_cosumoMedio);
            tb_veiculo.Controls.Add(txtbox_placaveiculo);
            tb_veiculo.Controls.Add(lb_placaveiculo);
            tb_veiculo.Controls.Add(txtbox_modeloveiculo);
            tb_veiculo.Controls.Add(lb_modeloveiculo);
            tb_veiculo.Controls.Add(txtbox_idveiculo);
            tb_veiculo.Controls.Add(lb_veiculoID);
            tb_veiculo.Font = new Font("Arial", 12F);
            tb_veiculo.ForeColor = Color.Black;
            tb_veiculo.Location = new Point(4, 27);
            tb_veiculo.Name = "tb_veiculo";
            tb_veiculo.Padding = new Padding(3);
            tb_veiculo.Size = new Size(747, 563);
            tb_veiculo.TabIndex = 0;
            tb_veiculo.Text = "Veiculo";
            // 
            // dgv_veiculos
            // 
            dgv_veiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_veiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_veiculos.Location = new Point(315, 75);
            dgv_veiculos.Name = "dgv_veiculos";
            dgv_veiculos.ReadOnly = true;
            dgv_veiculos.RowHeadersWidth = 51;
            dgv_veiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_veiculos.Size = new Size(417, 383);
            dgv_veiculos.TabIndex = 14;
            // 
            // bt_edtveiculo
            // 
            bt_edtveiculo.Image = Properties.Resources.Editar;
            bt_edtveiculo.Location = new Point(315, 478);
            bt_edtveiculo.Name = "bt_edtveiculo";
            bt_edtveiculo.Size = new Size(205, 40);
            bt_edtveiculo.TabIndex = 13;
            bt_edtveiculo.UseVisualStyleBackColor = true;
            bt_edtveiculo.Click += bt_edtveiculo_Click;
            // 
            // bt_delveiculo
            // 
            bt_delveiculo.Image = Properties.Resources.Deletar;
            bt_delveiculo.Location = new Point(527, 478);
            bt_delveiculo.Name = "bt_delveiculo";
            bt_delveiculo.Size = new Size(205, 40);
            bt_delveiculo.TabIndex = 12;
            bt_delveiculo.UseVisualStyleBackColor = true;
            bt_delveiculo.Click += bt_delveiculo_Click;
            // 
            // bt_showveiculos
            // 
            bt_showveiculos.Image = Properties.Resources.MostrarTodos;
            bt_showveiculos.Location = new Point(527, 17);
            bt_showveiculos.Name = "bt_showveiculos";
            bt_showveiculos.Size = new Size(205, 40);
            bt_showveiculos.TabIndex = 11;
            bt_showveiculos.UseVisualStyleBackColor = true;
            bt_showveiculos.Click += bt_showveiculos_Click;
            // 
            // bt_cadveiculo
            // 
            bt_cadveiculo.Image = Properties.Resources.Cadastrar;
            bt_cadveiculo.Location = new Point(22, 478);
            bt_cadveiculo.Name = "bt_cadveiculo";
            bt_cadveiculo.Size = new Size(205, 40);
            bt_cadveiculo.TabIndex = 10;
            bt_cadveiculo.UseVisualStyleBackColor = true;
            bt_cadveiculo.Click += bt_cadveiculo_Click;
            // 
            // txtbox_cargamaxima
            // 
            txtbox_cargamaxima.Location = new Point(22, 420);
            txtbox_cargamaxima.Name = "txtbox_cargamaxima";
            txtbox_cargamaxima.Size = new Size(205, 26);
            txtbox_cargamaxima.TabIndex = 9;
            // 
            // lb_cargamaxima
            // 
            lb_cargamaxima.AutoSize = true;
            lb_cargamaxima.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_cargamaxima.ForeColor = Color.White;
            lb_cargamaxima.Location = new Point(22, 382);
            lb_cargamaxima.Name = "lb_cargamaxima";
            lb_cargamaxima.Size = new Size(209, 24);
            lb_cargamaxima.TabIndex = 8;
            lb_cargamaxima.Text = "Carga Maximo (Kg):";
            // 
            // txtbox_consumomedio
            // 
            txtbox_consumomedio.Location = new Point(22, 339);
            txtbox_consumomedio.Name = "txtbox_consumomedio";
            txtbox_consumomedio.Size = new Size(205, 26);
            txtbox_consumomedio.TabIndex = 7;
            // 
            // lb_cosumoMedio
            // 
            lb_cosumoMedio.AutoSize = true;
            lb_cosumoMedio.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_cosumoMedio.ForeColor = Color.White;
            lb_cosumoMedio.Location = new Point(22, 301);
            lb_cosumoMedio.Name = "lb_cosumoMedio";
            lb_cosumoMedio.Size = new Size(251, 24);
            lb_cosumoMedio.TabIndex = 6;
            lb_cosumoMedio.Text = "Consumo Medio (km/L):";
            // 
            // txtbox_placaveiculo
            // 
            txtbox_placaveiculo.Location = new Point(22, 258);
            txtbox_placaveiculo.Name = "txtbox_placaveiculo";
            txtbox_placaveiculo.Size = new Size(205, 26);
            txtbox_placaveiculo.TabIndex = 5;
            // 
            // lb_placaveiculo
            // 
            lb_placaveiculo.AutoSize = true;
            lb_placaveiculo.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_placaveiculo.ForeColor = Color.White;
            lb_placaveiculo.Location = new Point(22, 220);
            lb_placaveiculo.Name = "lb_placaveiculo";
            lb_placaveiculo.Size = new Size(182, 24);
            lb_placaveiculo.TabIndex = 4;
            lb_placaveiculo.Text = "Placa do Veiculo:";
            // 
            // txtbox_modeloveiculo
            // 
            txtbox_modeloveiculo.Location = new Point(22, 177);
            txtbox_modeloveiculo.Name = "txtbox_modeloveiculo";
            txtbox_modeloveiculo.Size = new Size(205, 26);
            txtbox_modeloveiculo.TabIndex = 3;
            // 
            // lb_modeloveiculo
            // 
            lb_modeloveiculo.AutoSize = true;
            lb_modeloveiculo.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_modeloveiculo.ForeColor = Color.White;
            lb_modeloveiculo.Location = new Point(22, 139);
            lb_modeloveiculo.Name = "lb_modeloveiculo";
            lb_modeloveiculo.Size = new Size(200, 24);
            lb_modeloveiculo.TabIndex = 2;
            lb_modeloveiculo.Text = "Modelo do Veiculo:";
            // 
            // txtbox_idveiculo
            // 
            txtbox_idveiculo.Location = new Point(22, 98);
            txtbox_idveiculo.Name = "txtbox_idveiculo";
            txtbox_idveiculo.Size = new Size(205, 26);
            txtbox_idveiculo.TabIndex = 1;
            // 
            // lb_veiculoID
            // 
            lb_veiculoID.AutoSize = true;
            lb_veiculoID.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_veiculoID.ForeColor = Color.White;
            lb_veiculoID.Location = new Point(22, 60);
            lb_veiculoID.Name = "lb_veiculoID";
            lb_veiculoID.Size = new Size(115, 24);
            lb_veiculoID.TabIndex = 0;
            lb_veiculoID.Text = "Veiculo ID:";
            // 
            // tb_motorista
            // 
            tb_motorista.BackColor = Color.Transparent;
            tb_motorista.BackgroundImage = (Image)resources.GetObject("tb_motorista.BackgroundImage");
            tb_motorista.Font = new Font("Arial", 12F);
            tb_motorista.ForeColor = Color.Transparent;
            tb_motorista.Location = new Point(4, 27);
            tb_motorista.Name = "tb_motorista";
            tb_motorista.Padding = new Padding(3);
            tb_motorista.Size = new Size(747, 563);
            tb_motorista.TabIndex = 1;
            tb_motorista.Text = "Motorista";
            // 
            // tb_rota
            // 
            tb_rota.BackColor = Color.Transparent;
            tb_rota.BackgroundImage = (Image)resources.GetObject("tb_rota.BackgroundImage");
            tb_rota.Font = new Font("Arial", 12F);
            tb_rota.ForeColor = Color.Transparent;
            tb_rota.Location = new Point(4, 27);
            tb_rota.Name = "tb_rota";
            tb_rota.Size = new Size(747, 563);
            tb_rota.TabIndex = 2;
            tb_rota.Text = "Rota";
            // 
            // tb_combustivel
            // 
            tb_combustivel.BackColor = Color.Transparent;
            tb_combustivel.BackgroundImage = (Image)resources.GetObject("tb_combustivel.BackgroundImage");
            tb_combustivel.Font = new Font("Arial", 12F);
            tb_combustivel.ForeColor = Color.Transparent;
            tb_combustivel.Location = new Point(4, 27);
            tb_combustivel.Name = "tb_combustivel";
            tb_combustivel.Size = new Size(747, 563);
            tb_combustivel.TabIndex = 3;
            tb_combustivel.Text = "Preço Combustivel";
            // 
            // tb_viagem
            // 
            tb_viagem.BackColor = Color.Transparent;
            tb_viagem.BackgroundImage = (Image)resources.GetObject("tb_viagem.BackgroundImage");
            tb_viagem.Font = new Font("Arial", 12F);
            tb_viagem.ForeColor = Color.Transparent;
            tb_viagem.Location = new Point(4, 27);
            tb_viagem.Name = "tb_viagem";
            tb_viagem.Size = new Size(747, 563);
            tb_viagem.TabIndex = 4;
            tb_viagem.Text = "Viagem";
            // 
            // form_logistica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(779, 618);
            Controls.Add(tb_view);
            Name = "form_logistica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += form_logistica_Load;
            tb_view.ResumeLayout(false);
            tb_veiculo.ResumeLayout(false);
            tb_veiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_veiculos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tb_view;
        private TabPage tb_veiculo;
        private TabPage tb_motorista;
        private TabPage tb_rota;
        private TabPage tb_combustivel;
        private TabPage tb_viagem;
        private TextBox txtbox_idveiculo;
        private Label lb_veiculoID;
        private TextBox txtbox_cargamaxima;
        private Label lb_cargamaxima;
        private TextBox txtbox_consumomedio;
        private Label lb_cosumoMedio;
        private TextBox txtbox_placaveiculo;
        private Label lb_placaveiculo;
        private TextBox txtbox_modeloveiculo;
        private Label lb_modeloveiculo;
        private Button bt_edtveiculo;
        private Button bt_delveiculo;
        private Button bt_showveiculos;
        private Button bt_cadveiculo;
        private DataGridView dgv_veiculos;
    }
}
