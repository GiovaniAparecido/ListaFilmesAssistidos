namespace ListaFilmesAssistidos
{
    partial class Form1
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
            System.Windows.Forms.ListViewGroup listViewGroup61 = new System.Windows.Forms.ListViewGroup("", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup62 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup63 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup64 = new System.Windows.Forms.ListViewGroup("Comédia", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup65 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup66 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup67 = new System.Windows.Forms.ListViewGroup("Documentário", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup68 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup69 = new System.Windows.Forms.ListViewGroup("Romance", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup70 = new System.Windows.Forms.ListViewGroup("Ficçãocientífica", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup71 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup72 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup73 = new System.Windows.Forms.ListViewGroup("Comédia", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup74 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup75 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup76 = new System.Windows.Forms.ListViewGroup("Documentário", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup77 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup78 = new System.Windows.Forms.ListViewGroup("Romanse", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup79 = new System.Windows.Forms.ListViewGroup("Ficçãocientífica", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup80 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.localtxt = new System.Windows.Forms.TextBox();
            this.generocbox = new System.Windows.Forms.ComboBox();
            this.nometxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bteditar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.LNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LGênero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LLocalAssistido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pesquisagenerocbx = new System.Windows.Forms.ComboBox();
            this.btpesquisa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.localtxt);
            this.groupBox1.Controls.Add(this.generocbox);
            this.groupBox1.Controls.Add(this.nometxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(58, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digite os dados a serem salvos sobre o filme!";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(90, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // localtxt
            // 
            this.localtxt.Location = new System.Drawing.Point(27, 170);
            this.localtxt.Name = "localtxt";
            this.localtxt.Size = new System.Drawing.Size(232, 20);
            this.localtxt.TabIndex = 7;
            // 
            // generocbox
            // 
            this.generocbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generocbox.FormattingEnabled = true;
            this.generocbox.Items.AddRange(new object[] {
            "",
            "Ação",
            "Aventura",
            "Comédia",
            "Terror",
            "Suspense",
            "Documentário",
            "Infantil",
            "Romance",
            "FicçãoCientífica"});
            this.generocbox.Location = new System.Drawing.Point(27, 109);
            this.generocbox.Name = "generocbox";
            this.generocbox.Size = new System.Drawing.Size(139, 21);
            this.generocbox.TabIndex = 5;
            // 
            // nometxt
            // 
            this.nometxt.Location = new System.Drawing.Point(27, 52);
            this.nometxt.Name = "nometxt";
            this.nometxt.Size = new System.Drawing.Size(232, 20);
            this.nometxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Local assistido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gênero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bteditar);
            this.groupBox2.Controls.Add(this.btDeletar);
            this.groupBox2.Controls.Add(this.btsalvar);
            this.groupBox2.Location = new System.Drawing.Point(58, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // bteditar
            // 
            this.bteditar.Enabled = false;
            this.bteditar.Location = new System.Drawing.Point(222, 19);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(75, 23);
            this.bteditar.TabIndex = 3;
            this.bteditar.Text = "&Editar";
            this.bteditar.UseVisualStyleBackColor = true;
            this.bteditar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Enabled = false;
            this.btDeletar.Location = new System.Drawing.Point(120, 19);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(75, 23);
            this.btDeletar.TabIndex = 1;
            this.btDeletar.Text = "&Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.Location = new System.Drawing.Point(6, 19);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(75, 23);
            this.btsalvar.TabIndex = 0;
            this.btsalvar.Text = "&Salvar";
            this.btsalvar.UseVisualStyleBackColor = true;
            this.btsalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CNome,
            this.CGenero,
            this.CData,
            this.CLocal});
            this.listView1.FullRowSelect = true;
            listViewGroup61.Header = "";
            listViewGroup61.Name = "Branco";
            listViewGroup62.Header = "Ação";
            listViewGroup62.Name = "Ação";
            listViewGroup63.Header = "Aventura";
            listViewGroup63.Name = "Aventura";
            listViewGroup64.Header = "Comédia";
            listViewGroup64.Name = "Comédia";
            listViewGroup65.Header = "Terror";
            listViewGroup65.Name = "Terror";
            listViewGroup66.Header = "Suspense";
            listViewGroup66.Name = "Suspense";
            listViewGroup67.Header = "Documentário";
            listViewGroup67.Name = "Documentário";
            listViewGroup68.Header = "Infantil";
            listViewGroup68.Name = "Infantil";
            listViewGroup69.Header = "Romance";
            listViewGroup69.Name = "Romance";
            listViewGroup70.Header = "Ficçãocientífica";
            listViewGroup70.Name = "Ficçãocientífica";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup61,
            listViewGroup62,
            listViewGroup63,
            listViewGroup64,
            listViewGroup65,
            listViewGroup66,
            listViewGroup67,
            listViewGroup68,
            listViewGroup69,
            listViewGroup70});
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(376, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(498, 195);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // CNome
            // 
            this.CNome.Text = "Nome";
            this.CNome.Width = 114;
            // 
            // CGenero
            // 
            this.CGenero.Text = "Gênero";
            this.CGenero.Width = 91;
            // 
            // CData
            // 
            this.CData.Text = "Data";
            this.CData.Width = 84;
            // 
            // CLocal
            // 
            this.CLocal.Text = "Local Assistido";
            this.CLocal.Width = 189;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(376, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 38);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LNome,
            this.LGênero,
            this.LData,
            this.LLocalAssistido});
            listViewGroup71.Header = "Ação";
            listViewGroup71.Name = "Ação";
            listViewGroup72.Header = "Aventura";
            listViewGroup72.Name = "Aventura";
            listViewGroup73.Header = "Comédia";
            listViewGroup73.Name = "Comédia";
            listViewGroup74.Header = "Terror";
            listViewGroup74.Name = "Terror";
            listViewGroup75.Header = "Suspense";
            listViewGroup75.Name = "Suspense";
            listViewGroup76.Header = "Documentário";
            listViewGroup76.Name = "Documentário";
            listViewGroup77.Header = "Infantil";
            listViewGroup77.Name = "Infantil";
            listViewGroup78.Header = "Romanse";
            listViewGroup78.Name = "Romance";
            listViewGroup79.Header = "Ficçãocientífica";
            listViewGroup79.Name = "Ficçãocientífica";
            listViewGroup80.Header = "ListViewGroup";
            listViewGroup80.Name = "listViewGroup1";
            this.listView2.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup71,
            listViewGroup72,
            listViewGroup73,
            listViewGroup74,
            listViewGroup75,
            listViewGroup76,
            listViewGroup77,
            listViewGroup78,
            listViewGroup79,
            listViewGroup80});
            this.listView2.Location = new System.Drawing.Point(64, 402);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(803, 131);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.Visible = false;
            // 
            // LNome
            // 
            this.LNome.Text = "Nome";
            this.LNome.Width = 158;
            // 
            // LGênero
            // 
            this.LGênero.Text = "Gênero";
            this.LGênero.Width = 119;
            // 
            // LData
            // 
            this.LData.Text = "Data";
            this.LData.Width = 114;
            // 
            // LLocalAssistido
            // 
            this.LLocalAssistido.Text = "Local Assistido";
            this.LLocalAssistido.Width = 203;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.Pesquisagenerocbx);
            this.groupBox4.Controls.Add(this.btpesquisa);
            this.groupBox4.Location = new System.Drawing.Point(58, 335);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(809, 48);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, -5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Digite o gênero ser pesquisado";
            // 
            // Pesquisagenerocbx
            // 
            this.Pesquisagenerocbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pesquisagenerocbx.FormattingEnabled = true;
            this.Pesquisagenerocbx.Items.AddRange(new object[] {
            "",
            "Ação",
            "Aventura",
            "Comédia",
            "Terror",
            "Suspense",
            "Documentário",
            "Infantil",
            "Romance",
            "FicçãoCientífica"});
            this.Pesquisagenerocbx.Location = new System.Drawing.Point(203, 11);
            this.Pesquisagenerocbx.Name = "Pesquisagenerocbx";
            this.Pesquisagenerocbx.Size = new System.Drawing.Size(153, 21);
            this.Pesquisagenerocbx.TabIndex = 6;
            this.Pesquisagenerocbx.SelectedIndexChanged += new System.EventHandler(this.Pesquisagenerocbx_SelectedIndexChanged);
            // 
            // btpesquisa
            // 
            this.btpesquisa.Location = new System.Drawing.Point(6, 9);
            this.btpesquisa.Name = "btpesquisa";
            this.btpesquisa.Size = new System.Drawing.Size(75, 23);
            this.btpesquisa.TabIndex = 2;
            this.btpesquisa.Text = "&Pesquisas";
            this.btpesquisa.UseVisualStyleBackColor = true;
            this.btpesquisa.Visible = false;
            this.btpesquisa.Click += new System.EventHandler(this.btpesquisa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 530);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cadastro de filmes assistidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nometxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox generocbox;
        private System.Windows.Forms.TextBox localtxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CNome;
        private System.Windows.Forms.ColumnHeader CGenero;
        private System.Windows.Forms.ColumnHeader CData;
        private System.Windows.Forms.ColumnHeader CLocal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader LNome;
        private System.Windows.Forms.ColumnHeader LGênero;
        private System.Windows.Forms.ColumnHeader LData;
        private System.Windows.Forms.ColumnHeader LLocalAssistido;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Pesquisagenerocbx;
        private System.Windows.Forms.Button btpesquisa;
    }
}

