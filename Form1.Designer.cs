namespace dB_konversor
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
            this.btnConverter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorAConverter = new System.Windows.Forms.TextBox();
            this.rbMiliWatts = new System.Windows.Forms.RadioButton();
            this.rbDb = new System.Windows.Forms.RadioButton();
            this.rbDbm = new System.Windows.Forms.RadioButton();
            this.txtValorSaida = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConverter.Location = new System.Drawing.Point(26, 251);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(153, 33);
            this.btnConverter.TabIndex = 0;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor a converter (w)";
            // 
            // txtValorAConverter
            // 
            this.txtValorAConverter.Location = new System.Drawing.Point(26, 153);
            this.txtValorAConverter.Name = "txtValorAConverter";
            this.txtValorAConverter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtValorAConverter.Size = new System.Drawing.Size(153, 20);
            this.txtValorAConverter.TabIndex = 2;
            // 
            // rbMiliWatts
            // 
            this.rbMiliWatts.AutoSize = true;
            this.rbMiliWatts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMiliWatts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbMiliWatts.Location = new System.Drawing.Point(54, 194);
            this.rbMiliWatts.Name = "rbMiliWatts";
            this.rbMiliWatts.Size = new System.Drawing.Size(125, 20);
            this.rbMiliWatts.TabIndex = 4;
            this.rbMiliWatts.TabStop = true;
            this.rbMiliWatts.Text = "mW (miliwatts)";
            this.rbMiliWatts.UseVisualStyleBackColor = true;
            this.rbMiliWatts.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbDb
            // 
            this.rbDb.AutoSize = true;
            this.rbDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbDb.Location = new System.Drawing.Point(208, 194);
            this.rbDb.Name = "rbDb";
            this.rbDb.Size = new System.Drawing.Size(45, 20);
            this.rbDb.TabIndex = 5;
            this.rbDb.TabStop = true;
            this.rbDb.Text = "dB";
            this.rbDb.UseVisualStyleBackColor = true;
            this.rbDb.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbDbm
            // 
            this.rbDbm.AutoSize = true;
            this.rbDbm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDbm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbDbm.Location = new System.Drawing.Point(299, 194);
            this.rbDbm.Name = "rbDbm";
            this.rbDbm.Size = new System.Drawing.Size(57, 20);
            this.rbDbm.TabIndex = 6;
            this.rbDbm.TabStop = true;
            this.rbDbm.Text = "dBm";
            this.rbDbm.UseVisualStyleBackColor = true;
            this.rbDbm.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // txtValorSaida
            // 
            this.txtValorSaida.Location = new System.Drawing.Point(245, 153);
            this.txtValorSaida.Name = "txtValorSaida";
            this.txtValorSaida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtValorSaida.Size = new System.Drawing.Size(164, 20);
            this.txtValorSaida.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(107, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 39);
            this.label3.TabIndex = 10;
            this.label3.Text = "Conversor dBm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(242, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valor convertido";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnReiniciar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbDbm);
            this.panel1.Controls.Add(this.txtValorAConverter);
            this.panel1.Controls.Add(this.rbDb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbMiliWatts);
            this.panel1.Controls.Add(this.txtValorSaida);
            this.panel1.Controls.Add(this.btnConverter);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 314);
            this.panel1.TabIndex = 12;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Red;
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReiniciar.Location = new System.Drawing.Point(245, 251);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(153, 33);
            this.btnReiniciar.TabIndex = 12;
            this.btnReiniciar.Text = "Reset";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 315);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dBm Konversor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorAConverter;
        private System.Windows.Forms.RadioButton rbMiliWatts;
        private System.Windows.Forms.RadioButton rbDb;
        private System.Windows.Forms.RadioButton rbDbm;
        private System.Windows.Forms.TextBox txtValorSaida;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

