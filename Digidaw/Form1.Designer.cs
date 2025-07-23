namespace Digidaw
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPengaturan = new System.Windows.Forms.Button();
            this.btnStatistik = new System.Windows.Forms.Button();
            this.btnFormInput = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.timerJam = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelJam = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.labelHeader);
            this.panelMenu.Controls.Add(this.btnPengaturan);
            this.panelMenu.Controls.Add(this.btnStatistik);
            this.panelMenu.Controls.Add(this.btnFormInput);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 673);
            this.panelMenu.TabIndex = 10;
            // 
            // btnPengaturan
            // 
            this.btnPengaturan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPengaturan.FlatAppearance.BorderSize = 0;
            this.btnPengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengaturan.ForeColor = System.Drawing.Color.White;
            this.btnPengaturan.Location = new System.Drawing.Point(0, 311);
            this.btnPengaturan.Name = "btnPengaturan";
            this.btnPengaturan.Size = new System.Drawing.Size(150, 80);
            this.btnPengaturan.TabIndex = 2;
            this.btnPengaturan.Text = "Pengaturan";
            this.btnPengaturan.UseVisualStyleBackColor = false;
            this.btnPengaturan.Click += new System.EventHandler(this.btnPengaturan_Click);
            this.btnPengaturan.Enter += new System.EventHandler(this.btnPengaturan_Enter);
            // 
            // btnStatistik
            // 
            this.btnStatistik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStatistik.FlatAppearance.BorderSize = 0;
            this.btnStatistik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistik.ForeColor = System.Drawing.Color.White;
            this.btnStatistik.Location = new System.Drawing.Point(0, 234);
            this.btnStatistik.Name = "btnStatistik";
            this.btnStatistik.Size = new System.Drawing.Size(150, 80);
            this.btnStatistik.TabIndex = 1;
            this.btnStatistik.Text = "Statistik";
            this.btnStatistik.UseVisualStyleBackColor = false;
            this.btnStatistik.Click += new System.EventHandler(this.btnStatistik_Click);
            this.btnStatistik.Enter += new System.EventHandler(this.btnStatistik_Enter);
            // 
            // btnFormInput
            // 
            this.btnFormInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFormInput.FlatAppearance.BorderSize = 0;
            this.btnFormInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormInput.ForeColor = System.Drawing.Color.White;
            this.btnFormInput.Location = new System.Drawing.Point(0, 158);
            this.btnFormInput.Name = "btnFormInput";
            this.btnFormInput.Size = new System.Drawing.Size(150, 80);
            this.btnFormInput.TabIndex = 0;
            this.btnFormInput.Text = "Input Makanan";
            this.btnFormInput.UseVisualStyleBackColor = false;
            this.btnFormInput.Click += new System.EventHandler(this.btnFormInput_Click);
            this.btnFormInput.Enter += new System.EventHandler(this.btnFormInput_Enter);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1262, 673);
            this.panelContent.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelHeader);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(150, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1112, 100);
            this.panel3.TabIndex = 12;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.tableLayoutPanel1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1112, 100);
            this.panelHeader.TabIndex = 13;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(6, 34);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(141, 34);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "DIGIDAW";
            // 
            // timerJam
            // 
            this.timerJam.Enabled = true;
            this.timerJam.Interval = 1000;
            this.timerJam.Tick += new System.EventHandler(this.timerJam_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.06115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.93885F));
            this.tableLayoutPanel1.Controls.Add(this.labelJam, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelWelcome, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1112, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelJam
            // 
            this.labelJam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJam.AutoSize = true;
            this.labelJam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJam.ForeColor = System.Drawing.Color.Black;
            this.labelJam.Location = new System.Drawing.Point(933, 0);
            this.labelJam.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.labelJam.Name = "labelJam";
            this.labelJam.Size = new System.Drawing.Size(169, 100);
            this.labelJam.TabIndex = 1;
            this.labelJam.Text = "No Profile Found";
            this.labelJam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.Black;
            this.labelWelcome.Location = new System.Drawing.Point(0, 0);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(395, 100);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Digital Daily Of Awareness";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelContent);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnPengaturan;
        private System.Windows.Forms.Button btnStatistik;
        private System.Windows.Forms.Button btnFormInput;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Timer timerJam;
        private System.Windows.Forms.Label labelJam;
        private System.Windows.Forms.Label labelWelcome;
    }
}

