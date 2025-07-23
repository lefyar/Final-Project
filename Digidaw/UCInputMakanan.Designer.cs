namespace Digidaw
{
    partial class UCInputMakanan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBarKalori = new System.Windows.Forms.ProgressBar();
            this.labelTotalKalori = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.progressBarProtein = new System.Windows.Forms.ProgressBar();
            this.comboBoxMakanan = new System.Windows.Forms.ComboBox();
            this.labelTotalProtein = new System.Windows.Forms.Label();
            this.numericUpDownPorsi = new System.Windows.Forms.NumericUpDown();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelMakanan = new System.Windows.Forms.Label();
            this.labelPorsi = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewMakanan = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPorsi)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarKalori
            // 
            this.progressBarKalori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarKalori.Location = new System.Drawing.Point(3, 20);
            this.progressBarKalori.Name = "progressBarKalori";
            this.progressBarKalori.Size = new System.Drawing.Size(685, 28);
            this.progressBarKalori.TabIndex = 14;
            // 
            // labelTotalKalori
            // 
            this.labelTotalKalori.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTotalKalori.AutoSize = true;
            this.labelTotalKalori.Location = new System.Drawing.Point(3, 0);
            this.labelTotalKalori.Name = "labelTotalKalori";
            this.labelTotalKalori.Size = new System.Drawing.Size(102, 16);
            this.labelTotalKalori.TabIndex = 15;
            this.labelTotalKalori.Text = "labelTotalKalori";
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.White;
            this.buttonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambah.ForeColor = System.Drawing.Color.Black;
            this.buttonTambah.Location = new System.Drawing.Point(127, 217);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(379, 37);
            this.buttonTambah.TabIndex = 13;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // progressBarProtein
            // 
            this.progressBarProtein.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarProtein.Location = new System.Drawing.Point(3, 71);
            this.progressBarProtein.Name = "progressBarProtein";
            this.progressBarProtein.Size = new System.Drawing.Size(685, 28);
            this.progressBarProtein.TabIndex = 17;
            // 
            // comboBoxMakanan
            // 
            this.comboBoxMakanan.FormattingEnabled = true;
            this.comboBoxMakanan.Location = new System.Drawing.Point(127, 133);
            this.comboBoxMakanan.Name = "comboBoxMakanan";
            this.comboBoxMakanan.Size = new System.Drawing.Size(379, 24);
            this.comboBoxMakanan.TabIndex = 0;
            // 
            // labelTotalProtein
            // 
            this.labelTotalProtein.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTotalProtein.AutoSize = true;
            this.labelTotalProtein.Location = new System.Drawing.Point(3, 51);
            this.labelTotalProtein.Name = "labelTotalProtein";
            this.labelTotalProtein.Size = new System.Drawing.Size(110, 16);
            this.labelTotalProtein.TabIndex = 18;
            this.labelTotalProtein.Text = "labelTotalProtein";
            // 
            // numericUpDownPorsi
            // 
            this.numericUpDownPorsi.Location = new System.Drawing.Point(127, 189);
            this.numericUpDownPorsi.Name = "numericUpDownPorsi";
            this.numericUpDownPorsi.Size = new System.Drawing.Size(379, 22);
            this.numericUpDownPorsi.TabIndex = 20;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.BackColor = System.Drawing.Color.White;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.ForeColor = System.Drawing.Color.Black;
            this.buttonReset.Location = new System.Drawing.Point(560, 118);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(128, 32);
            this.buttonReset.TabIndex = 19;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelMakanan
            // 
            this.labelMakanan.AutoSize = true;
            this.labelMakanan.Location = new System.Drawing.Point(124, 114);
            this.labelMakanan.Name = "labelMakanan";
            this.labelMakanan.Size = new System.Drawing.Size(91, 16);
            this.labelMakanan.TabIndex = 21;
            this.labelMakanan.Text = "Pilih Makanan";
            // 
            // labelPorsi
            // 
            this.labelPorsi.AutoSize = true;
            this.labelPorsi.Location = new System.Drawing.Point(124, 170);
            this.labelPorsi.Name = "labelPorsi";
            this.labelPorsi.Size = new System.Drawing.Size(38, 16);
            this.labelPorsi.TabIndex = 22;
            this.labelPorsi.Text = "Porsi";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonReset, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.progressBarProtein, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelTotalProtein, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBarKalori, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTotalKalori, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(127, 291);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.36364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.36364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(691, 153);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // listViewMakanan
            // 
            this.listViewMakanan.FullRowSelect = true;
            this.listViewMakanan.GridLines = true;
            this.listViewMakanan.HideSelection = false;
            this.listViewMakanan.Location = new System.Drawing.Point(512, 114);
            this.listViewMakanan.MultiSelect = false;
            this.listViewMakanan.Name = "listViewMakanan";
            this.listViewMakanan.Size = new System.Drawing.Size(303, 171);
            this.listViewMakanan.TabIndex = 24;
            this.listViewMakanan.UseCompatibleStateImageBehavior = false;
            this.listViewMakanan.View = System.Windows.Forms.View.Details;
            // 
            // UCInputMakanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewMakanan);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelPorsi);
            this.Controls.Add(this.labelMakanan);
            this.Controls.Add(this.numericUpDownPorsi);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.comboBoxMakanan);
            this.Name = "UCInputMakanan";
            this.Size = new System.Drawing.Size(850, 475);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPorsi)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarKalori;
        private System.Windows.Forms.Label labelTotalKalori;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.ProgressBar progressBarProtein;
        private System.Windows.Forms.ComboBox comboBoxMakanan;
        private System.Windows.Forms.Label labelTotalProtein;
        private System.Windows.Forms.NumericUpDown numericUpDownPorsi;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelMakanan;
        private System.Windows.Forms.Label labelPorsi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listViewMakanan;
    }
}
