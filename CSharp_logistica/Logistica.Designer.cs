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
            tb_motorista = new TabPage();
            tb_rota = new TabPage();
            tb_combustivel = new TabPage();
            tb_viagem = new TabPage();
            tb_view.SuspendLayout();
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
            tb_view.Size = new Size(755, 529);
            tb_view.TabIndex = 0;
            // 
            // tb_veiculo
            // 
            tb_veiculo.BackColor = Color.Transparent;
            tb_veiculo.BackgroundImage = (Image)resources.GetObject("tb_veiculo.BackgroundImage");
            tb_veiculo.Font = new Font("Arial", 12F);
            tb_veiculo.ForeColor = Color.Transparent;
            tb_veiculo.Location = new Point(4, 27);
            tb_veiculo.Name = "tb_veiculo";
            tb_veiculo.Padding = new Padding(3);
            tb_veiculo.Size = new Size(747, 498);
            tb_veiculo.TabIndex = 0;
            tb_veiculo.Text = "Veiculo";
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
            tb_motorista.Size = new Size(747, 498);
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
            tb_rota.Size = new Size(747, 498);
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
            tb_combustivel.Size = new Size(747, 498);
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
            tb_viagem.Size = new Size(747, 498);
            tb_viagem.TabIndex = 4;
            tb_viagem.Text = "Viagem";
            // 
            // form_logistica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(779, 553);
            Controls.Add(tb_view);
            Name = "form_logistica";
            Text = "Form1";
            tb_view.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tb_view;
        private TabPage tb_veiculo;
        private TabPage tb_motorista;
        private TabPage tb_rota;
        private TabPage tb_combustivel;
        private TabPage tb_viagem;
    }
}
