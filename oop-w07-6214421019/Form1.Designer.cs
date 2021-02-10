
namespace oop-w07-6214421019
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.Income = new System.Windows.Forms.TextBox();
            this.Dispense = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.taxtopay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "แบบฟอร์มภาษีบุคคลธรรมดา";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(73, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อ / นามสกุล";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(74, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "รายได้";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(70, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "เงินสดหย่อน";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(149, 128);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(92, 20);
            this.nametxt.TabIndex = 4;
            this.nametxt.TextChanged += new System.EventHandler(this.nametxt_TextChanged);
            // 
            // Income
            // 
            this.Income.Location = new System.Drawing.Point(149, 164);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(92, 20);
            this.Income.TabIndex = 5;
            this.Income.TextChanged += new System.EventHandler(this.Income_TextChanged);
            // 
            // Dispense
            // 
            this.Dispense.Location = new System.Drawing.Point(149, 198);
            this.Dispense.Name = "Dispense";
            this.Dispense.Size = new System.Drawing.Size(92, 20);
            this.Dispense.TabIndex = 6;
            this.Dispense.TextChanged += new System.EventHandler(this.Dispense_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.button1.Location = new System.Drawing.Point(73, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "เริ่มการคำณวน";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Location = new System.Drawing.Point(73, 299);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(47, 13);
            this.lbloutput.TabIndex = 8;
            this.lbloutput.Text = "รายได้ =";
            this.lbloutput.Click += new System.EventHandler(this.lbloutput_Click);
            // 
            // taxtopay
            // 
            this.taxtopay.AutoSize = true;
            this.taxtopay.Location = new System.Drawing.Point(72, 328);
            this.taxtopay.Name = "taxtopay";
            this.taxtopay.Size = new System.Drawing.Size(79, 13);
            this.taxtopay.TabIndex = 9;
            this.taxtopay.Text = "ภาษีที่ต้องจ่าย =";
            this.taxtopay.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(337, 412);
            this.Controls.Add(this.taxtopay);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dispense);
            this.Controls.Add(this.Income);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAX_CAL[.EXE]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox Income;
        private System.Windows.Forms.TextBox Dispense;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label taxtopay;
    }
}

