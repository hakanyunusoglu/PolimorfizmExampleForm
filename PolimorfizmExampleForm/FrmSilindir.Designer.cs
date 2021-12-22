namespace PolimorfizmExampleForm
{
    partial class FrmSilindir
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
            this.lburun = new System.Windows.Forms.ListBox();
            this.dgvurun = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbyukseklik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbyaricap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbhacim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbfire = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvurun)).BeginInit();
            this.SuspendLayout();
            // 
            // lburun
            // 
            this.lburun.FormattingEnabled = true;
            this.lburun.ItemHeight = 15;
            this.lburun.Location = new System.Drawing.Point(12, 12);
            this.lburun.Name = "lburun";
            this.lburun.Size = new System.Drawing.Size(165, 184);
            this.lburun.TabIndex = 0;
            this.lburun.SelectedIndexChanged += new System.EventHandler(this.lburun_SelectedIndexChanged);
            // 
            // dgvurun
            // 
            this.dgvurun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvurun.Location = new System.Drawing.Point(183, 12);
            this.dgvurun.Name = "dgvurun";
            this.dgvurun.ReadOnly = true;
            this.dgvurun.RowTemplate.Height = 25;
            this.dgvurun.Size = new System.Drawing.Size(507, 184);
            this.dgvurun.TabIndex = 1;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(12, 202);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(102, 202);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(102, 231);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(75, 23);
            this.btnlistele.TabIndex = 2;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(12, 231);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(75, 23);
            this.btnguncelle.TabIndex = 2;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(751, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID :";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(781, 12);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(100, 23);
            this.tbid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "AD :";
            // 
            // tbad
            // 
            this.tbad.Location = new System.Drawing.Point(781, 41);
            this.tbad.Name = "tbad";
            this.tbad.Size = new System.Drawing.Size(100, 23);
            this.tbad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(713, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yükseklik :";
            // 
            // tbyukseklik
            // 
            this.tbyukseklik.Location = new System.Drawing.Point(781, 70);
            this.tbyukseklik.Name = "tbyukseklik";
            this.tbyukseklik.Size = new System.Drawing.Size(100, 23);
            this.tbyukseklik.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(724, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yarıçap :";
            // 
            // tbyaricap
            // 
            this.tbyaricap.Location = new System.Drawing.Point(781, 99);
            this.tbyaricap.Name = "tbyaricap";
            this.tbyaricap.Size = new System.Drawing.Size(100, 23);
            this.tbyaricap.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(727, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hacim :";
            // 
            // tbhacim
            // 
            this.tbhacim.Enabled = false;
            this.tbhacim.Location = new System.Drawing.Point(781, 206);
            this.tbhacim.Name = "tbhacim";
            this.tbhacim.Size = new System.Drawing.Size(100, 23);
            this.tbhacim.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(743, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fire :";
            // 
            // tbfire
            // 
            this.tbfire.Enabled = false;
            this.tbfire.Location = new System.Drawing.Point(781, 235);
            this.tbfire.Name = "tbfire";
            this.tbfire.Size = new System.Drawing.Size(100, 23);
            this.tbfire.TabIndex = 4;
            // 
            // FrmSilindir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 275);
            this.Controls.Add(this.tbfire);
            this.Controls.Add(this.tbhacim);
            this.Controls.Add(this.tbyaricap);
            this.Controls.Add(this.tbyukseklik);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dgvurun);
            this.Controls.Add(this.lburun);
            this.Name = "FrmSilindir";
            this.Text = "FrmSilindir";
            ((System.ComponentModel.ISupportInitialize)(this.dgvurun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lburun;
        private DataGridView dgvurun;
        private Button btnekle;
        private Button btnsil;
        private Button btnlistele;
        private Button btnguncelle;
        private Label label1;
        private TextBox tbid;
        private Label label2;
        private TextBox tbad;
        private Label label3;
        private TextBox tbyukseklik;
        private Label label4;
        private TextBox tbyaricap;
        private Label label5;
        private TextBox tbhacim;
        private Label label6;
        private TextBox tbfire;
    }
}