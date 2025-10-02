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
            txtbox_mtatele = new TextBox();
            lb_mototele = new Label();
            txtbox_mtacnh = new TextBox();
            lb_motocnh = new Label();
            txtbox_mtanome = new TextBox();
            lb_motonome = new Label();
            txtbox_mtaid = new TextBox();
            lb_motoid = new Label();
            dgv_mta = new DataGridView();
            bt_mtaedit = new Button();
            bt_mtadelete = new Button();
            bt_mtashow = new Button();
            bt_mtacad = new Button();
            tb_rota = new TabPage();
            txtbox_rtdistancia = new TextBox();
            label1 = new Label();
            txtbox_rtdestino = new TextBox();
            label2 = new Label();
            txtbox_rtorigem = new TextBox();
            label3 = new Label();
            txtbox_rtid = new TextBox();
            label4 = new Label();
            dgv_rt = new DataGridView();
            bt_rtedit = new Button();
            bt_rtdelete = new Button();
            bt_rtshow = new Button();
            bt_rtcad = new Button();
            tb_combustivel = new TabPage();
            cb_combconsulta = new ComboBox();
            dtp_combconsulta = new DateTimePicker();
            txtbox_combpreco = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtbox_combid = new TextBox();
            label8 = new Label();
            dgv_comb = new DataGridView();
            bt_combedit = new Button();
            bt_combdelete = new Button();
            bt_combshow = new Button();
            bt_combcad = new Button();
            tb_viagem = new TabPage();
            cb_viagemstatus = new ComboBox();
            lb_viagemstatus = new Label();
            cb_viagemmotorista = new ComboBox();
            label14 = new Label();
            cb_viagemveiculo = new ComboBox();
            dtp_viagemsaida = new DateTimePicker();
            cb_viagemrota = new ComboBox();
            label13 = new Label();
            dtp_viagemchegada = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtbox_viagemid = new TextBox();
            label12 = new Label();
            dgv_viagem = new DataGridView();
            bt_viagemedit = new Button();
            bt_viagemdelete = new Button();
            bt_viagemshow = new Button();
            bt_viagemcad = new Button();
            tb_view.SuspendLayout();
            tb_veiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_veiculos).BeginInit();
            tb_motorista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_mta).BeginInit();
            tb_rota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_rt).BeginInit();
            tb_combustivel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_comb).BeginInit();
            tb_viagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_viagem).BeginInit();
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
            tb_view.Size = new Size(1082, 650);
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
            tb_veiculo.Size = new Size(1074, 619);
            tb_veiculo.TabIndex = 0;
            tb_veiculo.Text = "Veiculo";
            // 
            // dgv_veiculos
            // 
            dgv_veiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_veiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_veiculos.Location = new Point(395, 81);
            dgv_veiculos.Name = "dgv_veiculos";
            dgv_veiculos.ReadOnly = true;
            dgv_veiculos.RowHeadersWidth = 51;
            dgv_veiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_veiculos.Size = new Size(666, 468);
            dgv_veiculos.TabIndex = 14;
            // 
            // bt_edtveiculo
            // 
            bt_edtveiculo.Image = Properties.Resources.Editar;
            bt_edtveiculo.Location = new Point(395, 562);
            bt_edtveiculo.Name = "bt_edtveiculo";
            bt_edtveiculo.Size = new Size(205, 40);
            bt_edtveiculo.TabIndex = 13;
            bt_edtveiculo.UseVisualStyleBackColor = true;
            bt_edtveiculo.Click += bt_edtveiculo_Click;
            // 
            // bt_delveiculo
            // 
            bt_delveiculo.Image = Properties.Resources.Deletar;
            bt_delveiculo.Location = new Point(856, 562);
            bt_delveiculo.Name = "bt_delveiculo";
            bt_delveiculo.Size = new Size(205, 40);
            bt_delveiculo.TabIndex = 12;
            bt_delveiculo.UseVisualStyleBackColor = true;
            bt_delveiculo.Click += bt_delveiculo_Click;
            // 
            // bt_showveiculos
            // 
            bt_showveiculos.Image = Properties.Resources.MostrarTodos;
            bt_showveiculos.Location = new Point(856, 22);
            bt_showveiculos.Name = "bt_showveiculos";
            bt_showveiculos.Size = new Size(205, 40);
            bt_showveiculos.TabIndex = 11;
            bt_showveiculos.UseVisualStyleBackColor = true;
            bt_showveiculos.Click += bt_showveiculos_Click;
            // 
            // bt_cadveiculo
            // 
            bt_cadveiculo.Image = Properties.Resources.Cadastrar;
            bt_cadveiculo.Location = new Point(22, 562);
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
            txtbox_cargamaxima.Size = new Size(258, 26);
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
            txtbox_consumomedio.Size = new Size(258, 26);
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
            txtbox_placaveiculo.Size = new Size(258, 26);
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
            txtbox_modeloveiculo.Size = new Size(258, 26);
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
            txtbox_idveiculo.ReadOnly = true;
            txtbox_idveiculo.Size = new Size(258, 26);
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
            tb_motorista.Controls.Add(txtbox_mtatele);
            tb_motorista.Controls.Add(lb_mototele);
            tb_motorista.Controls.Add(txtbox_mtacnh);
            tb_motorista.Controls.Add(lb_motocnh);
            tb_motorista.Controls.Add(txtbox_mtanome);
            tb_motorista.Controls.Add(lb_motonome);
            tb_motorista.Controls.Add(txtbox_mtaid);
            tb_motorista.Controls.Add(lb_motoid);
            tb_motorista.Controls.Add(dgv_mta);
            tb_motorista.Controls.Add(bt_mtaedit);
            tb_motorista.Controls.Add(bt_mtadelete);
            tb_motorista.Controls.Add(bt_mtashow);
            tb_motorista.Controls.Add(bt_mtacad);
            tb_motorista.Font = new Font("Arial", 12F);
            tb_motorista.ForeColor = Color.Black;
            tb_motorista.Location = new Point(4, 27);
            tb_motorista.Name = "tb_motorista";
            tb_motorista.Padding = new Padding(3);
            tb_motorista.Size = new Size(1074, 619);
            tb_motorista.TabIndex = 1;
            tb_motorista.Text = "Motorista";
            // 
            // txtbox_mtatele
            // 
            txtbox_mtatele.Location = new Point(22, 354);
            txtbox_mtatele.Name = "txtbox_mtatele";
            txtbox_mtatele.Size = new Size(258, 26);
            txtbox_mtatele.TabIndex = 26;
            // 
            // lb_mototele
            // 
            lb_mototele.AutoSize = true;
            lb_mototele.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_mototele.ForeColor = Color.White;
            lb_mototele.Location = new Point(22, 316);
            lb_mototele.Name = "lb_mototele";
            lb_mototele.Size = new Size(234, 24);
            lb_mototele.TabIndex = 25;
            lb_mototele.Text = "Telefone do Motorista:";
            // 
            // txtbox_mtacnh
            // 
            txtbox_mtacnh.Location = new Point(22, 273);
            txtbox_mtacnh.Name = "txtbox_mtacnh";
            txtbox_mtacnh.Size = new Size(258, 26);
            txtbox_mtacnh.TabIndex = 24;
            // 
            // lb_motocnh
            // 
            lb_motocnh.AutoSize = true;
            lb_motocnh.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_motocnh.ForeColor = Color.White;
            lb_motocnh.Location = new Point(22, 235);
            lb_motocnh.Name = "lb_motocnh";
            lb_motocnh.Size = new Size(190, 24);
            lb_motocnh.TabIndex = 23;
            lb_motocnh.Text = "Cnh do Motorista:";
            // 
            // txtbox_mtanome
            // 
            txtbox_mtanome.Location = new Point(22, 192);
            txtbox_mtanome.Name = "txtbox_mtanome";
            txtbox_mtanome.Size = new Size(258, 26);
            txtbox_mtanome.TabIndex = 22;
            // 
            // lb_motonome
            // 
            lb_motonome.AutoSize = true;
            lb_motonome.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_motonome.ForeColor = Color.White;
            lb_motonome.Location = new Point(22, 154);
            lb_motonome.Name = "lb_motonome";
            lb_motonome.Size = new Size(207, 24);
            lb_motonome.TabIndex = 21;
            lb_motonome.Text = "Nome do Motorista:";
            // 
            // txtbox_mtaid
            // 
            txtbox_mtaid.Location = new Point(22, 113);
            txtbox_mtaid.Name = "txtbox_mtaid";
            txtbox_mtaid.ReadOnly = true;
            txtbox_mtaid.Size = new Size(258, 26);
            txtbox_mtaid.TabIndex = 20;
            // 
            // lb_motoid
            // 
            lb_motoid.AutoSize = true;
            lb_motoid.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_motoid.ForeColor = Color.White;
            lb_motoid.Location = new Point(22, 75);
            lb_motoid.Name = "lb_motoid";
            lb_motoid.Size = new Size(137, 24);
            lb_motoid.TabIndex = 19;
            lb_motoid.Text = "Motorista ID:";
            // 
            // dgv_mta
            // 
            dgv_mta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_mta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_mta.Location = new Point(395, 81);
            dgv_mta.Name = "dgv_mta";
            dgv_mta.ReadOnly = true;
            dgv_mta.RowHeadersWidth = 51;
            dgv_mta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_mta.Size = new Size(666, 468);
            dgv_mta.TabIndex = 18;
            // 
            // bt_mtaedit
            // 
            bt_mtaedit.Image = Properties.Resources.Editar;
            bt_mtaedit.Location = new Point(315, 562);
            bt_mtaedit.Name = "bt_mtaedit";
            bt_mtaedit.Size = new Size(205, 40);
            bt_mtaedit.TabIndex = 17;
            bt_mtaedit.UseVisualStyleBackColor = true;
            bt_mtaedit.Click += bt_mtaedit_Click;
            // 
            // bt_mtadelete
            // 
            bt_mtadelete.Image = Properties.Resources.Deletar;
            bt_mtadelete.Location = new Point(527, 562);
            bt_mtadelete.Name = "bt_mtadelete";
            bt_mtadelete.Size = new Size(205, 40);
            bt_mtadelete.TabIndex = 16;
            bt_mtadelete.UseVisualStyleBackColor = true;
            bt_mtadelete.Click += bt_mtadelete_Click;
            // 
            // bt_mtashow
            // 
            bt_mtashow.Image = Properties.Resources.MostrarTodos;
            bt_mtashow.Location = new Point(856, 22);
            bt_mtashow.Name = "bt_mtashow";
            bt_mtashow.Size = new Size(205, 40);
            bt_mtashow.TabIndex = 15;
            bt_mtashow.UseVisualStyleBackColor = true;
            bt_mtashow.Click += bt_mtashow_Click;
            // 
            // bt_mtacad
            // 
            bt_mtacad.Image = Properties.Resources.Cadastrar;
            bt_mtacad.Location = new Point(22, 562);
            bt_mtacad.Name = "bt_mtacad";
            bt_mtacad.Size = new Size(205, 40);
            bt_mtacad.TabIndex = 14;
            bt_mtacad.UseVisualStyleBackColor = true;
            bt_mtacad.Click += bt_mtacad_Click;
            // 
            // tb_rota
            // 
            tb_rota.BackColor = Color.Transparent;
            tb_rota.BackgroundImage = (Image)resources.GetObject("tb_rota.BackgroundImage");
            tb_rota.Controls.Add(txtbox_rtdistancia);
            tb_rota.Controls.Add(label1);
            tb_rota.Controls.Add(txtbox_rtdestino);
            tb_rota.Controls.Add(label2);
            tb_rota.Controls.Add(txtbox_rtorigem);
            tb_rota.Controls.Add(label3);
            tb_rota.Controls.Add(txtbox_rtid);
            tb_rota.Controls.Add(label4);
            tb_rota.Controls.Add(dgv_rt);
            tb_rota.Controls.Add(bt_rtedit);
            tb_rota.Controls.Add(bt_rtdelete);
            tb_rota.Controls.Add(bt_rtshow);
            tb_rota.Controls.Add(bt_rtcad);
            tb_rota.Font = new Font("Arial", 12F);
            tb_rota.ForeColor = Color.Black;
            tb_rota.Location = new Point(4, 27);
            tb_rota.Name = "tb_rota";
            tb_rota.Size = new Size(1074, 619);
            tb_rota.TabIndex = 2;
            tb_rota.Text = "Rota";
            // 
            // txtbox_rtdistancia
            // 
            txtbox_rtdistancia.Location = new Point(22, 354);
            txtbox_rtdistancia.Name = "txtbox_rtdistancia";
            txtbox_rtdistancia.Size = new Size(258, 26);
            txtbox_rtdistancia.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 316);
            label1.Name = "label1";
            label1.Size = new Size(194, 24);
            label1.TabIndex = 38;
            label1.Text = "Distancia da Rota:";
            // 
            // txtbox_rtdestino
            // 
            txtbox_rtdestino.Location = new Point(22, 273);
            txtbox_rtdestino.Name = "txtbox_rtdestino";
            txtbox_rtdestino.Size = new Size(258, 26);
            txtbox_rtdestino.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 235);
            label2.Name = "label2";
            label2.Size = new Size(178, 24);
            label2.TabIndex = 36;
            label2.Text = "Destino da Rota:";
            // 
            // txtbox_rtorigem
            // 
            txtbox_rtorigem.Location = new Point(22, 192);
            txtbox_rtorigem.Name = "txtbox_rtorigem";
            txtbox_rtorigem.Size = new Size(258, 26);
            txtbox_rtorigem.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 154);
            label3.Name = "label3";
            label3.Size = new Size(174, 24);
            label3.TabIndex = 34;
            label3.Text = "Origem da Rota:";
            // 
            // txtbox_rtid
            // 
            txtbox_rtid.Location = new Point(22, 113);
            txtbox_rtid.Name = "txtbox_rtid";
            txtbox_rtid.ReadOnly = true;
            txtbox_rtid.Size = new Size(258, 26);
            txtbox_rtid.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 75);
            label4.Name = "label4";
            label4.Size = new Size(90, 24);
            label4.TabIndex = 32;
            label4.Text = "Rota ID:";
            // 
            // dgv_rt
            // 
            dgv_rt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_rt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_rt.Location = new Point(395, 81);
            dgv_rt.Name = "dgv_rt";
            dgv_rt.ReadOnly = true;
            dgv_rt.RowHeadersWidth = 51;
            dgv_rt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_rt.Size = new Size(666, 468);
            dgv_rt.TabIndex = 31;
            // 
            // bt_rtedit
            // 
            bt_rtedit.Image = Properties.Resources.Editar;
            bt_rtedit.Location = new Point(395, 562);
            bt_rtedit.Name = "bt_rtedit";
            bt_rtedit.Size = new Size(205, 40);
            bt_rtedit.TabIndex = 30;
            bt_rtedit.UseVisualStyleBackColor = true;
            bt_rtedit.Click += bt_rtedit_Click;
            // 
            // bt_rtdelete
            // 
            bt_rtdelete.Image = Properties.Resources.Deletar;
            bt_rtdelete.Location = new Point(856, 562);
            bt_rtdelete.Name = "bt_rtdelete";
            bt_rtdelete.Size = new Size(205, 40);
            bt_rtdelete.TabIndex = 29;
            bt_rtdelete.UseVisualStyleBackColor = true;
            bt_rtdelete.Click += bt_rtdelete_Click;
            // 
            // bt_rtshow
            // 
            bt_rtshow.Image = Properties.Resources.MostrarTodos;
            bt_rtshow.Location = new Point(856, 22);
            bt_rtshow.Name = "bt_rtshow";
            bt_rtshow.Size = new Size(205, 40);
            bt_rtshow.TabIndex = 28;
            bt_rtshow.UseVisualStyleBackColor = true;
            bt_rtshow.Click += bt_rtshow_Click;
            // 
            // bt_rtcad
            // 
            bt_rtcad.Image = Properties.Resources.Cadastrar;
            bt_rtcad.Location = new Point(22, 562);
            bt_rtcad.Name = "bt_rtcad";
            bt_rtcad.Size = new Size(205, 40);
            bt_rtcad.TabIndex = 27;
            bt_rtcad.UseVisualStyleBackColor = true;
            bt_rtcad.Click += bt_rtcad_Click;
            // 
            // tb_combustivel
            // 
            tb_combustivel.BackColor = Color.Transparent;
            tb_combustivel.BackgroundImage = (Image)resources.GetObject("tb_combustivel.BackgroundImage");
            tb_combustivel.Controls.Add(cb_combconsulta);
            tb_combustivel.Controls.Add(dtp_combconsulta);
            tb_combustivel.Controls.Add(txtbox_combpreco);
            tb_combustivel.Controls.Add(label5);
            tb_combustivel.Controls.Add(label6);
            tb_combustivel.Controls.Add(label7);
            tb_combustivel.Controls.Add(txtbox_combid);
            tb_combustivel.Controls.Add(label8);
            tb_combustivel.Controls.Add(dgv_comb);
            tb_combustivel.Controls.Add(bt_combedit);
            tb_combustivel.Controls.Add(bt_combdelete);
            tb_combustivel.Controls.Add(bt_combshow);
            tb_combustivel.Controls.Add(bt_combcad);
            tb_combustivel.Font = new Font("Arial", 12F);
            tb_combustivel.ForeColor = Color.Black;
            tb_combustivel.Location = new Point(4, 27);
            tb_combustivel.Name = "tb_combustivel";
            tb_combustivel.Size = new Size(1074, 619);
            tb_combustivel.TabIndex = 3;
            tb_combustivel.Text = "Preço Combustivel";
            // 
            // cb_combconsulta
            // 
            cb_combconsulta.FormattingEnabled = true;
            cb_combconsulta.Items.AddRange(new object[] { "Alcool ", "Gasolina" });
            cb_combconsulta.Location = new Point(22, 192);
            cb_combconsulta.Name = "cb_combconsulta";
            cb_combconsulta.Size = new Size(258, 26);
            cb_combconsulta.TabIndex = 54;
            // 
            // dtp_combconsulta
            // 
            dtp_combconsulta.Format = DateTimePickerFormat.Short;
            dtp_combconsulta.Location = new Point(22, 271);
            dtp_combconsulta.Name = "dtp_combconsulta";
            dtp_combconsulta.Size = new Size(258, 26);
            dtp_combconsulta.TabIndex = 53;
            // 
            // txtbox_combpreco
            // 
            txtbox_combpreco.Location = new Point(22, 354);
            txtbox_combpreco.Name = "txtbox_combpreco";
            txtbox_combpreco.Size = new Size(258, 26);
            txtbox_combpreco.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(22, 316);
            label5.Name = "label5";
            label5.Size = new Size(209, 24);
            label5.TabIndex = 51;
            label5.Text = "Preço Combustivel:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 235);
            label6.Name = "label6";
            label6.Size = new Size(190, 24);
            label6.TabIndex = 49;
            label6.Text = "Data da Consulta:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(22, 154);
            label7.Name = "label7";
            label7.Size = new Size(225, 24);
            label7.TabIndex = 47;
            label7.Text = "Tipo de Combustivel:";
            // 
            // txtbox_combid
            // 
            txtbox_combid.Location = new Point(22, 113);
            txtbox_combid.Name = "txtbox_combid";
            txtbox_combid.ReadOnly = true;
            txtbox_combid.Size = new Size(258, 26);
            txtbox_combid.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(22, 75);
            label8.Name = "label8";
            label8.Size = new Size(170, 24);
            label8.TabIndex = 45;
            label8.Text = "Combustivel ID:";
            // 
            // dgv_comb
            // 
            dgv_comb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_comb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_comb.Location = new Point(395, 81);
            dgv_comb.Name = "dgv_comb";
            dgv_comb.ReadOnly = true;
            dgv_comb.RowHeadersWidth = 51;
            dgv_comb.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_comb.Size = new Size(666, 468);
            dgv_comb.TabIndex = 44;
            // 
            // bt_combedit
            // 
            bt_combedit.Image = Properties.Resources.Editar;
            bt_combedit.Location = new Point(395, 562);
            bt_combedit.Name = "bt_combedit";
            bt_combedit.Size = new Size(205, 40);
            bt_combedit.TabIndex = 43;
            bt_combedit.UseVisualStyleBackColor = true;
            bt_combedit.Click += bt_combedit_Click;
            // 
            // bt_combdelete
            // 
            bt_combdelete.Image = Properties.Resources.Deletar;
            bt_combdelete.Location = new Point(856, 562);
            bt_combdelete.Name = "bt_combdelete";
            bt_combdelete.Size = new Size(205, 40);
            bt_combdelete.TabIndex = 42;
            bt_combdelete.UseVisualStyleBackColor = true;
            bt_combdelete.Click += bt_combdelete_Click;
            // 
            // bt_combshow
            // 
            bt_combshow.Image = Properties.Resources.MostrarTodos;
            bt_combshow.Location = new Point(856, 22);
            bt_combshow.Name = "bt_combshow";
            bt_combshow.Size = new Size(205, 40);
            bt_combshow.TabIndex = 41;
            bt_combshow.UseVisualStyleBackColor = true;
            bt_combshow.Click += bt_combshow_Click;
            // 
            // bt_combcad
            // 
            bt_combcad.Image = Properties.Resources.Cadastrar;
            bt_combcad.Location = new Point(22, 562);
            bt_combcad.Name = "bt_combcad";
            bt_combcad.Size = new Size(205, 40);
            bt_combcad.TabIndex = 40;
            bt_combcad.UseVisualStyleBackColor = true;
            bt_combcad.Click += bt_combcad_Click;
            // 
            // tb_viagem
            // 
            tb_viagem.BackColor = Color.Transparent;
            tb_viagem.BackgroundImage = (Image)resources.GetObject("tb_viagem.BackgroundImage");
            tb_viagem.Controls.Add(cb_viagemstatus);
            tb_viagem.Controls.Add(lb_viagemstatus);
            tb_viagem.Controls.Add(cb_viagemmotorista);
            tb_viagem.Controls.Add(label14);
            tb_viagem.Controls.Add(cb_viagemveiculo);
            tb_viagem.Controls.Add(dtp_viagemsaida);
            tb_viagem.Controls.Add(cb_viagemrota);
            tb_viagem.Controls.Add(label13);
            tb_viagem.Controls.Add(dtp_viagemchegada);
            tb_viagem.Controls.Add(label9);
            tb_viagem.Controls.Add(label10);
            tb_viagem.Controls.Add(label11);
            tb_viagem.Controls.Add(txtbox_viagemid);
            tb_viagem.Controls.Add(label12);
            tb_viagem.Controls.Add(dgv_viagem);
            tb_viagem.Controls.Add(bt_viagemedit);
            tb_viagem.Controls.Add(bt_viagemdelete);
            tb_viagem.Controls.Add(bt_viagemshow);
            tb_viagem.Controls.Add(bt_viagemcad);
            tb_viagem.Font = new Font("Arial", 12F);
            tb_viagem.ForeColor = Color.Black;
            tb_viagem.Location = new Point(4, 27);
            tb_viagem.Name = "tb_viagem";
            tb_viagem.Size = new Size(1074, 619);
            tb_viagem.TabIndex = 4;
            tb_viagem.Text = "Viagem";
            tb_viagem.Enter += tb_viagem_Enter;
            // 
            // cb_viagemstatus
            // 
            cb_viagemstatus.FormattingEnabled = true;
            cb_viagemstatus.Items.AddRange(new object[] { "Em andamento", "Pausada", "Finalizada", "Cancelada" });
            cb_viagemstatus.Location = new Point(22, 494);
            cb_viagemstatus.Name = "cb_viagemstatus";
            cb_viagemstatus.Size = new Size(258, 26);
            cb_viagemstatus.TabIndex = 75;
            // 
            // lb_viagemstatus
            // 
            lb_viagemstatus.AutoSize = true;
            lb_viagemstatus.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_viagemstatus.ForeColor = Color.White;
            lb_viagemstatus.Location = new Point(22, 467);
            lb_viagemstatus.Name = "lb_viagemstatus";
            lb_viagemstatus.Size = new Size(193, 24);
            lb_viagemstatus.TabIndex = 74;
            lb_viagemstatus.Text = "Status da Viagem:";
            // 
            // cb_viagemmotorista
            // 
            cb_viagemmotorista.FormattingEnabled = true;
            cb_viagemmotorista.Location = new Point(22, 425);
            cb_viagemmotorista.Name = "cb_viagemmotorista";
            cb_viagemmotorista.Size = new Size(258, 26);
            cb_viagemmotorista.TabIndex = 73;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(22, 398);
            label14.Name = "label14";
            label14.Size = new Size(222, 24);
            label14.TabIndex = 72;
            label14.Text = "Motorista da Viagem:";
            // 
            // cb_viagemveiculo
            // 
            cb_viagemveiculo.FormattingEnabled = true;
            cb_viagemveiculo.Items.AddRange(new object[] { "" });
            cb_viagemveiculo.Location = new Point(22, 295);
            cb_viagemveiculo.Name = "cb_viagemveiculo";
            cb_viagemveiculo.Size = new Size(258, 26);
            cb_viagemveiculo.TabIndex = 71;
            // 
            // dtp_viagemsaida
            // 
            dtp_viagemsaida.Format = DateTimePickerFormat.Short;
            dtp_viagemsaida.Location = new Point(22, 164);
            dtp_viagemsaida.Name = "dtp_viagemsaida";
            dtp_viagemsaida.Size = new Size(258, 26);
            dtp_viagemsaida.TabIndex = 70;
            // 
            // cb_viagemrota
            // 
            cb_viagemrota.FormattingEnabled = true;
            cb_viagemrota.Location = new Point(22, 360);
            cb_viagemrota.Name = "cb_viagemrota";
            cb_viagemrota.Size = new Size(258, 26);
            cb_viagemrota.TabIndex = 69;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(22, 333);
            label13.Name = "label13";
            label13.Size = new Size(175, 24);
            label13.TabIndex = 68;
            label13.Text = "Rota da Viagem:";
            // 
            // dtp_viagemchegada
            // 
            dtp_viagemchegada.Format = DateTimePickerFormat.Short;
            dtp_viagemchegada.Location = new Point(22, 229);
            dtp_viagemchegada.Name = "dtp_viagemchegada";
            dtp_viagemchegada.Size = new Size(258, 26);
            dtp_viagemchegada.TabIndex = 66;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(22, 268);
            label9.Name = "label9";
            label9.Size = new Size(200, 24);
            label9.TabIndex = 64;
            label9.Text = "Veiculo da Viagem:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(22, 202);
            label10.Name = "label10";
            label10.Size = new Size(218, 24);
            label10.TabIndex = 63;
            label10.Text = "Chegada da Viagem:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(22, 137);
            label11.Name = "label11";
            label11.Size = new Size(184, 24);
            label11.TabIndex = 62;
            label11.Text = "Saida da Viagem:";
            // 
            // txtbox_viagemid
            // 
            txtbox_viagemid.Location = new Point(22, 98);
            txtbox_viagemid.Name = "txtbox_viagemid";
            txtbox_viagemid.ReadOnly = true;
            txtbox_viagemid.Size = new Size(258, 26);
            txtbox_viagemid.TabIndex = 61;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(22, 68);
            label12.Name = "label12";
            label12.Size = new Size(117, 24);
            label12.TabIndex = 60;
            label12.Text = "Viagem ID:";
            // 
            // dgv_viagem
            // 
            dgv_viagem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_viagem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_viagem.Location = new Point(395, 81);
            dgv_viagem.Name = "dgv_viagem";
            dgv_viagem.ReadOnly = true;
            dgv_viagem.RowHeadersWidth = 51;
            dgv_viagem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_viagem.Size = new Size(666, 468);
            dgv_viagem.TabIndex = 59;
            // 
            // bt_viagemedit
            // 
            bt_viagemedit.Image = Properties.Resources.Editar;
            bt_viagemedit.Location = new Point(395, 562);
            bt_viagemedit.Name = "bt_viagemedit";
            bt_viagemedit.Size = new Size(205, 40);
            bt_viagemedit.TabIndex = 58;
            bt_viagemedit.UseVisualStyleBackColor = true;
            bt_viagemedit.Click += bt_viagemedit_Click;
            // 
            // bt_viagemdelete
            // 
            bt_viagemdelete.Image = Properties.Resources.Deletar;
            bt_viagemdelete.Location = new Point(856, 562);
            bt_viagemdelete.Name = "bt_viagemdelete";
            bt_viagemdelete.Size = new Size(205, 40);
            bt_viagemdelete.TabIndex = 57;
            bt_viagemdelete.UseVisualStyleBackColor = true;
            bt_viagemdelete.Click += bt_viagemdelete_Click;
            // 
            // bt_viagemshow
            // 
            bt_viagemshow.Image = Properties.Resources.MostrarTodos;
            bt_viagemshow.Location = new Point(856, 22);
            bt_viagemshow.Name = "bt_viagemshow";
            bt_viagemshow.Size = new Size(205, 40);
            bt_viagemshow.TabIndex = 56;
            bt_viagemshow.UseVisualStyleBackColor = true;
            bt_viagemshow.Click += bt_viagemshow_Click;
            // 
            // bt_viagemcad
            // 
            bt_viagemcad.Image = Properties.Resources.Cadastrar;
            bt_viagemcad.Location = new Point(22, 562);
            bt_viagemcad.Name = "bt_viagemcad";
            bt_viagemcad.Size = new Size(205, 40);
            bt_viagemcad.TabIndex = 55;
            bt_viagemcad.UseVisualStyleBackColor = true;
            bt_viagemcad.Click += bt_viagemcad_Click;
            // 
            // form_logistica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1106, 685);
            Controls.Add(tb_view);
            Name = "form_logistica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += form_logistica_Load;
            tb_view.ResumeLayout(false);
            tb_veiculo.ResumeLayout(false);
            tb_veiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_veiculos).EndInit();
            tb_motorista.ResumeLayout(false);
            tb_motorista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_mta).EndInit();
            tb_rota.ResumeLayout(false);
            tb_rota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_rt).EndInit();
            tb_combustivel.ResumeLayout(false);
            tb_combustivel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_comb).EndInit();
            tb_viagem.ResumeLayout(false);
            tb_viagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_viagem).EndInit();
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
        private Button bt_mtaedit;
        private Button bt_mtadelete;
        private Button bt_mtashow;
        private Button bt_mtacad;
        private DataGridView dgv_mta;
        private TextBox txtbox_mtatele;
        private Label lb_mototele;
        private TextBox txtbox_mtacnh;
        private Label lb_motocnh;
        private TextBox txtbox_mtanome;
        private Label lb_motonome;
        private TextBox txtbox_mtaid;
        private Label lb_motoid;
        private TextBox txtbox_rtdistancia;
        private Label label1;
        private TextBox txtbox_rtdestino;
        private Label label2;
        private TextBox txtbox_rtorigem;
        private Label label3;
        private TextBox txtbox_rtid;
        private Label label4;
        private DataGridView dgv_rt;
        private Button bt_rtedit;
        private Button bt_rtdelete;
        private Button bt_rtshow;
        private Button bt_rtcad;
        private TextBox txtbox_combpreco;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtbox_combid;
        private Label label8;
        private DataGridView dgv_comb;
        private Button bt_combedit;
        private Button bt_combdelete;
        private Button bt_combshow;
        private Button bt_combcad;
        private DateTimePicker dtp_combconsulta;
        private ComboBox cb_combconsulta;
        private DateTimePicker dtp_viagemchegada;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtbox_viagemid;
        private Label label12;
        private DataGridView dgv_viagem;
        private Button bt_viagemedit;
        private Button bt_viagemdelete;
        private Button bt_viagemshow;
        private Button bt_viagemcad;
        private ComboBox cb_viagemmotorista;
        private Label label14;
        private ComboBox cb_viagemveiculo;
        private DateTimePicker dtp_viagemsaida;
        private ComboBox cb_viagemrota;
        private Label label13;
        private ComboBox cb_viagemstatus;
        private Label lb_viagemstatus;
    }
}
