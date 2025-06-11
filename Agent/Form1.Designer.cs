namespace Agent
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nome_cliente = new System.Windows.Forms.TextBox();
            this.Service = new System.Windows.Forms.ComboBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Observação = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.obs_box = new System.Windows.Forms.TextBox();
            this.dtp_DataeHora = new System.Windows.Forms.DateTimePicker();
            this.btnRemove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            this.label1.Click += new System.EventHandler(this.Cliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serviço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data e Hora";
            // 
            // Nome_cliente
            // 
            this.Nome_cliente.Location = new System.Drawing.Point(80, 19);
            this.Nome_cliente.Name = "Nome_cliente";
            this.Nome_cliente.Size = new System.Drawing.Size(140, 20);
            this.Nome_cliente.TabIndex = 3;
            this.Nome_cliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Service
            // 
            this.Service.FormattingEnabled = true;
            this.Service.Items.AddRange(new object[] {
            "Toroca de HD",
            "Impressora",
            "Troca de perifericos",
            "Não liga"});
            this.Service.Location = new System.Drawing.Point(80, 59);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(140, 21);
            this.Service.TabIndex = 4;
            this.Service.SelectedIndexChanged += new System.EventHandler(this.Service_SelectedIndexChanged);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.Observação});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(350, 25);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(438, 381);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cliente";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Serviços";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 91;
            // 
            // Observação
            // 
            this.Observação.Text = "Observação";
            this.Observação.Width = 149;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.obs_box);
            this.groupBox1.Controls.Add(this.dtp_DataeHora);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Service);
            this.groupBox1.Controls.Add(this.Nome_cliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 245);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agendamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Observação";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // obs_box
            // 
            this.obs_box.Location = new System.Drawing.Point(80, 154);
            this.obs_box.Name = "obs_box";
            this.obs_box.Size = new System.Drawing.Size(140, 20);
            this.obs_box.TabIndex = 8;
            // 
            // dtp_DataeHora
            // 
            this.dtp_DataeHora.CustomFormat = "";
            this.dtp_DataeHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DataeHora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_DataeHora.Location = new System.Drawing.Point(78, 99);
            this.dtp_DataeHora.Name = "dtp_DataeHora";
            this.dtp_DataeHora.Size = new System.Drawing.Size(142, 20);
            this.dtp_DataeHora.TabIndex = 7;
            this.dtp_DataeHora.TabStop = false;
            this.dtp_DataeHora.Value = new System.DateTime(2025, 6, 7, 20, 51, 21, 0);
            this.dtp_DataeHora.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(161, 213);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Concluído";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agendar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView);
            this.Name = "Form1";
            this.Text = "Chamado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nome_cliente;
        private System.Windows.Forms.ComboBox Service;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DateTimePicker dtp_DataeHora;
        private System.Windows.Forms.ColumnHeader Observação;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox obs_box;
    }
}

