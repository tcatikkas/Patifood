namespace PatifoodApp
{
    partial class Sorgulama
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
            this.Dgw1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_TeslimYeri = new System.Windows.Forms.ComboBox();
            this.cmb_Il = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dgw2 = new System.Windows.Forms.DataGridView();
            this.btn_Sorgula = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw2)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgw1
            // 
            this.Dgw1.AllowUserToAddRows = false;
            this.Dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgw1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.Dgw1.Location = new System.Drawing.Point(580, 132);
            this.Dgw1.Name = "Dgw1";
            this.Dgw1.Size = new System.Drawing.Size(850, 525);
            this.Dgw1.TabIndex = 0;
            this.Dgw1.MultiSelectChanged += new System.EventHandler(this.Dgw1_MultiSelectChanged);
            this.Dgw1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgw1_CellContentClick);
            this.Dgw1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.Dgw1.CurrentCellChanged += new System.EventHandler(this.Dgw1_CurrentCellChanged);
           
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teslim Yeri";
            // 
            // cmb_TeslimYeri
            // 
            this.cmb_TeslimYeri.FormattingEnabled = true;
            this.cmb_TeslimYeri.Location = new System.Drawing.Point(785, 12);
            this.cmb_TeslimYeri.Name = "cmb_TeslimYeri";
            this.cmb_TeslimYeri.Size = new System.Drawing.Size(268, 21);
            this.cmb_TeslimYeri.TabIndex = 2;
            // 
            // cmb_Il
            // 
            this.cmb_Il.FormattingEnabled = true;
            this.cmb_Il.Location = new System.Drawing.Point(785, 39);
            this.cmb_Il.Name = "cmb_Il";
            this.cmb_Il.Size = new System.Drawing.Size(133, 21);
            this.cmb_Il.TabIndex = 4;
            this.cmb_Il.SelectedIndexChanged += new System.EventHandler(this.cmb_Il_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "İl";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dgw2);
            this.groupBox1.Location = new System.Drawing.Point(15, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 567);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paket";
            // 
            // Dgw2
            // 
            this.Dgw2.AllowUserToAddRows = false;
            this.Dgw2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgw2.Location = new System.Drawing.Point(12, 19);
            this.Dgw2.Name = "Dgw2";
            this.Dgw2.Size = new System.Drawing.Size(541, 527);
            this.Dgw2.TabIndex = 0;
            // 
            // btn_Sorgula
            // 
            this.btn_Sorgula.Location = new System.Drawing.Point(949, 40);
            this.btn_Sorgula.Name = "btn_Sorgula";
            this.btn_Sorgula.Size = new System.Drawing.Size(75, 23);
            this.btn_Sorgula.TabIndex = 6;
            this.btn_Sorgula.Text = "Sorgula";
            this.btn_Sorgula.UseVisualStyleBackColor = true;
            this.btn_Sorgula.Click += new System.EventHandler(this.btn_Sorgula_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Paketlenmemiş",
            "Paketlenmiş"});
            this.comboBox1.Location = new System.Drawing.Point(99, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Paket Durumu";
            // 
            // Sorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Sorgula);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_Il);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_TeslimYeri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgw1);
            this.Name = "Sorgulama";
            this.Text = "Sorgulama";
            this.Load += new System.EventHandler(this.Sorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgw1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgw2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgw1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_TeslimYeri;
        private System.Windows.Forms.ComboBox cmb_Il;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgw2;
        private System.Windows.Forms.Button btn_Sorgula;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}