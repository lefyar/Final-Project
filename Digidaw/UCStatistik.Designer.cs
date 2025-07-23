namespace Digidaw
{
    partial class UCStatistik
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
            this.chartStatistik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.radio7Hari = new System.Windows.Forms.RadioButton();
            this.radio30Hari = new System.Windows.Forms.RadioButton();
            this.radioSemua = new System.Windows.Forms.RadioButton();
            this.buttonGenerateDummy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistik)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStatistik
            // 
            this.chartStatistik.Location = new System.Drawing.Point(113, 95);
            this.chartStatistik.Name = "chartStatistik";
            this.chartStatistik.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartStatistik.Size = new System.Drawing.Size(707, 253);
            this.chartStatistik.TabIndex = 0;
            this.chartStatistik.Text = "chart1";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.BackColor = System.Drawing.Color.White;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.ForeColor = System.Drawing.Color.Black;
            this.buttonRefresh.Location = new System.Drawing.Point(692, 369);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(128, 32);
            this.buttonRefresh.TabIndex = 37;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // radio7Hari
            // 
            this.radio7Hari.AutoSize = true;
            this.radio7Hari.Location = new System.Drawing.Point(113, 360);
            this.radio7Hari.Name = "radio7Hari";
            this.radio7Hari.Size = new System.Drawing.Size(63, 20);
            this.radio7Hari.TabIndex = 38;
            this.radio7Hari.TabStop = true;
            this.radio7Hari.Text = "7 Hari";
            this.radio7Hari.UseVisualStyleBackColor = true;
            this.radio7Hari.CheckedChanged += new System.EventHandler(this.radio7Hari_CheckedChanged);
            // 
            // radio30Hari
            // 
            this.radio30Hari.AutoSize = true;
            this.radio30Hari.Location = new System.Drawing.Point(182, 360);
            this.radio30Hari.Name = "radio30Hari";
            this.radio30Hari.Size = new System.Drawing.Size(70, 20);
            this.radio30Hari.TabIndex = 39;
            this.radio30Hari.TabStop = true;
            this.radio30Hari.Text = "30 Hari";
            this.radio30Hari.UseVisualStyleBackColor = true;
            this.radio30Hari.CheckedChanged += new System.EventHandler(this.radio30Hari_CheckedChanged);
            // 
            // radioSemua
            // 
            this.radioSemua.AutoSize = true;
            this.radioSemua.Location = new System.Drawing.Point(258, 360);
            this.radioSemua.Name = "radioSemua";
            this.radioSemua.Size = new System.Drawing.Size(112, 20);
            this.radioSemua.TabIndex = 40;
            this.radioSemua.TabStop = true;
            this.radioSemua.Text = "Semua Waktu";
            this.radioSemua.UseVisualStyleBackColor = true;
            this.radioSemua.CheckedChanged += new System.EventHandler(this.radioSemua_CheckedChanged);
            // 
            // buttonGenerateDummy
            // 
            this.buttonGenerateDummy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateDummy.BackColor = System.Drawing.Color.White;
            this.buttonGenerateDummy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateDummy.ForeColor = System.Drawing.Color.Black;
            this.buttonGenerateDummy.Location = new System.Drawing.Point(692, 407);
            this.buttonGenerateDummy.Name = "buttonGenerateDummy";
            this.buttonGenerateDummy.Size = new System.Drawing.Size(128, 32);
            this.buttonGenerateDummy.TabIndex = 41;
            this.buttonGenerateDummy.Text = "Generate";
            this.buttonGenerateDummy.UseVisualStyleBackColor = false;
            this.buttonGenerateDummy.Click += new System.EventHandler(this.buttonGenerateDummy_Click);
            // 
            // UCStatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonGenerateDummy);
            this.Controls.Add(this.radioSemua);
            this.Controls.Add(this.radio30Hari);
            this.Controls.Add(this.radio7Hari);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.chartStatistik);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCStatistik";
            this.Size = new System.Drawing.Size(850, 475);
            this.Load += new System.EventHandler(this.UCStatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistik;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.RadioButton radio7Hari;
        private System.Windows.Forms.RadioButton radio30Hari;
        private System.Windows.Forms.RadioButton radioSemua;
        private System.Windows.Forms.Button buttonGenerateDummy;
    }
}
