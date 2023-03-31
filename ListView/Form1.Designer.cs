namespace ListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Air Jordan 4 off white",
            "20",
            "R$ 23.400,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ListViewProdutos = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.TextBoxPRODUTO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxQUANTIDADE = new System.Windows.Forms.TextBox();
            this.TextBoxPREÇO = new System.Windows.Forms.TextBox();
            this.ButtonADICIONAR = new System.Windows.Forms.Button();
            this.ButtonREMOVER = new System.Windows.Forms.Button();
            this.ButtonOBTER = new System.Windows.Forms.Button();
            this.col_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_PRODUTO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_QUANTIDADE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_PRECO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tratativa com exemplo utilizando ListView";
            // 
            // ListViewProdutos
            // 
            this.ListViewProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ID,
            this.col_PRODUTO,
            this.col_QUANTIDADE,
            this.col_PRECO});
            this.ListViewProdutos.FullRowSelect = true;
            this.ListViewProdutos.GridLines = true;
            this.ListViewProdutos.HideSelection = false;
            this.ListViewProdutos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.ListViewProdutos.Location = new System.Drawing.Point(49, 62);
            this.ListViewProdutos.Name = "ListViewProdutos";
            this.ListViewProdutos.Size = new System.Drawing.Size(581, 162);
            this.ListViewProdutos.TabIndex = 1;
            this.ListViewProdutos.UseCompatibleStateImageBehavior = false;
            this.ListViewProdutos.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "PRODUTO";
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(45, 312);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(52, 20);
            this.TextBoxID.TabIndex = 4;
            // 
            // TextBoxPRODUTO
            // 
            this.TextBoxPRODUTO.Location = new System.Drawing.Point(100, 312);
            this.TextBoxPRODUTO.Name = "TextBoxPRODUTO";
            this.TextBoxPRODUTO.Size = new System.Drawing.Size(150, 20);
            this.TextBoxPRODUTO.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "QUANTIDADE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(458, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "PREÇO";
            // 
            // TextBoxQUANTIDADE
            // 
            this.TextBoxQUANTIDADE.Location = new System.Drawing.Point(281, 312);
            this.TextBoxQUANTIDADE.Name = "TextBoxQUANTIDADE";
            this.TextBoxQUANTIDADE.Size = new System.Drawing.Size(130, 20);
            this.TextBoxQUANTIDADE.TabIndex = 8;
            // 
            // TextBoxPREÇO
            // 
            this.TextBoxPREÇO.Location = new System.Drawing.Point(448, 311);
            this.TextBoxPREÇO.Name = "TextBoxPREÇO";
            this.TextBoxPREÇO.Size = new System.Drawing.Size(96, 20);
            this.TextBoxPREÇO.TabIndex = 9;
            // 
            // ButtonADICIONAR
            // 
            this.ButtonADICIONAR.BackColor = System.Drawing.Color.LightCyan;
            this.ButtonADICIONAR.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonADICIONAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ButtonADICIONAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonADICIONAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonADICIONAR.Location = new System.Drawing.Point(45, 369);
            this.ButtonADICIONAR.Name = "ButtonADICIONAR";
            this.ButtonADICIONAR.Size = new System.Drawing.Size(82, 23);
            this.ButtonADICIONAR.TabIndex = 10;
            this.ButtonADICIONAR.Text = "ADICIONAR";
            this.ButtonADICIONAR.UseVisualStyleBackColor = false;
            this.ButtonADICIONAR.Click += new System.EventHandler(this.ButtonADICIONAR_Click);
            // 
            // ButtonREMOVER
            // 
            this.ButtonREMOVER.BackColor = System.Drawing.Color.LightCyan;
            this.ButtonREMOVER.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonREMOVER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ButtonREMOVER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonREMOVER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonREMOVER.Location = new System.Drawing.Point(45, 411);
            this.ButtonREMOVER.Name = "ButtonREMOVER";
            this.ButtonREMOVER.Size = new System.Drawing.Size(82, 23);
            this.ButtonREMOVER.TabIndex = 11;
            this.ButtonREMOVER.Text = "REMOVER";
            this.ButtonREMOVER.UseVisualStyleBackColor = false;
            this.ButtonREMOVER.Click += new System.EventHandler(this.ButtonREMOVER_Click);
            // 
            // ButtonOBTER
            // 
            this.ButtonOBTER.BackColor = System.Drawing.Color.LightCyan;
            this.ButtonOBTER.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonOBTER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ButtonOBTER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonOBTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOBTER.Location = new System.Drawing.Point(133, 389);
            this.ButtonOBTER.Name = "ButtonOBTER";
            this.ButtonOBTER.Size = new System.Drawing.Size(75, 23);
            this.ButtonOBTER.TabIndex = 12;
            this.ButtonOBTER.Text = "OBTER";
            this.ButtonOBTER.UseVisualStyleBackColor = false;
            // 
            // col_ID
            // 
            this.col_ID.Text = "ID";
            // 
            // col_PRODUTO
            // 
            this.col_PRODUTO.Text = "PRODUTO";
            this.col_PRODUTO.Width = 146;
            // 
            // col_QUANTIDADE
            // 
            this.col_QUANTIDADE.Text = "QUANTIDADE";
            this.col_QUANTIDADE.Width = 250;
            // 
            // col_PRECO
            // 
            this.col_PRECO.Text = "PREÇO";
            this.col_PRECO.Width = 164;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonOBTER);
            this.Controls.Add(this.ButtonREMOVER);
            this.Controls.Add(this.ButtonADICIONAR);
            this.Controls.Add(this.TextBoxPREÇO);
            this.Controls.Add(this.TextBoxQUANTIDADE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxPRODUTO);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListViewProdutos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListViewProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.TextBox TextBoxPRODUTO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxQUANTIDADE;
        private System.Windows.Forms.TextBox TextBoxPREÇO;
        private System.Windows.Forms.Button ButtonADICIONAR;
        private System.Windows.Forms.Button ButtonREMOVER;
        private System.Windows.Forms.Button ButtonOBTER;
        private System.Windows.Forms.ColumnHeader col_ID;
        private System.Windows.Forms.ColumnHeader col_PRODUTO;
        private System.Windows.Forms.ColumnHeader col_QUANTIDADE;
        private System.Windows.Forms.ColumnHeader col_PRECO;
    }
}

