namespace Capability_Generator
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
            this.button1 = new System.Windows.Forms.Button();
            this.Max_texbox_text = new System.Windows.Forms.TextBox();
            this.Max_textbox = new System.Windows.Forms.Label();
            this.Min_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plus_tol_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tol_minus_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Genereaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Max_texbox_text
            // 
            this.Max_texbox_text.Location = new System.Drawing.Point(157, 42);
            this.Max_texbox_text.Name = "Max_texbox_text";
            this.Max_texbox_text.Size = new System.Drawing.Size(100, 20);
            this.Max_texbox_text.TabIndex = 1;
            // 
            // Max_textbox
            // 
            this.Max_textbox.AutoSize = true;
            this.Max_textbox.Location = new System.Drawing.Point(180, 26);
            this.Max_textbox.Name = "Max_textbox";
            this.Max_textbox.Size = new System.Drawing.Size(51, 13);
            this.Max_textbox.TabIndex = 2;
            this.Max_textbox.Text = "Maximum";
            // 
            // Min_textbox
            // 
            this.Min_textbox.Location = new System.Drawing.Point(279, 43);
            this.Min_textbox.Name = "Min_textbox";
            this.Min_textbox.Size = new System.Drawing.Size(100, 20);
            this.Min_textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Minimum";
            // 
            // plus_tol_textbox
            // 
            this.plus_tol_textbox.Location = new System.Drawing.Point(482, 43);
            this.plus_tol_textbox.Name = "plus_tol_textbox";
            this.plus_tol_textbox.Size = new System.Drawing.Size(100, 20);
            this.plus_tol_textbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Toleranta Plus";
            // 
            // tol_minus_textbox
            // 
            this.tol_minus_textbox.Location = new System.Drawing.Point(620, 43);
            this.tol_minus_textbox.Name = "tol_minus_textbox";
            this.tol_minus_textbox.Size = new System.Drawing.Size(100, 20);
            this.tol_minus_textbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Toleranta Minus";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(318, 89);
            this.button2.TabIndex = 9;
            this.button2.Text = "Copiaza_numerele_generate";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tol_minus_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plus_tol_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Min_textbox);
            this.Controls.Add(this.Max_textbox);
            this.Controls.Add(this.Max_texbox_text);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Capability generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Max_texbox_text;
        private System.Windows.Forms.Label Max_textbox;
        private System.Windows.Forms.TextBox Min_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plus_tol_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tol_minus_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

