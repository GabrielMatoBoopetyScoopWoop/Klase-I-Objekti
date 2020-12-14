namespace Klase_I_Objekti
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
            this.UnosStringTextBox = new System.Windows.Forms.TextBox();
            this.UnosIntTextBox = new System.Windows.Forms.TextBox();
            this.UnesiButun = new System.Windows.Forms.Button();
            this.IspisiButun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // UnosStringTextBox
            // 
            this.UnosStringTextBox.Location = new System.Drawing.Point(50, 50);
            this.UnosStringTextBox.Multiline = true;
            this.UnosStringTextBox.Name = "UnosStringTextBox";
            this.UnosStringTextBox.Size = new System.Drawing.Size(134, 20);
            this.UnosStringTextBox.TabIndex = 0;
            // 
            // UnosIntTextBox
            // 
            this.UnosIntTextBox.Location = new System.Drawing.Point(50, 166);
            this.UnosIntTextBox.Multiline = true;
            this.UnosIntTextBox.Name = "UnosIntTextBox";
            this.UnosIntTextBox.Size = new System.Drawing.Size(134, 20);
            this.UnosIntTextBox.TabIndex = 2;
            // 
            // UnesiButun
            // 
            this.UnesiButun.Location = new System.Drawing.Point(283, 50);
            this.UnesiButun.Name = "UnesiButun";
            this.UnesiButun.Size = new System.Drawing.Size(129, 23);
            this.UnesiButun.TabIndex = 4;
            this.UnesiButun.Text = "Unesi";
            this.UnesiButun.UseVisualStyleBackColor = true;
            this.UnesiButun.Click += new System.EventHandler(this.UnesiButun_Click);
            // 
            // IspisiButun
            // 
            this.IspisiButun.Location = new System.Drawing.Point(283, 163);
            this.IspisiButun.Name = "IspisiButun";
            this.IspisiButun.Size = new System.Drawing.Size(129, 23);
            this.IspisiButun.TabIndex = 5;
            this.IspisiButun.Text = "Ispisi";
            this.IspisiButun.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unos String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Unos Int";
            // 
            // RichTextBox
            // 
            this.RichTextBox.Location = new System.Drawing.Point(50, 253);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(362, 115);
            this.RichTextBox.TabIndex = 8;
            this.RichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IspisiButun);
            this.Controls.Add(this.UnesiButun);
            this.Controls.Add(this.UnosIntTextBox);
            this.Controls.Add(this.UnosStringTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UnosStringTextBox;
        private System.Windows.Forms.TextBox UnosIntTextBox;
        private System.Windows.Forms.Button UnesiButun;
        private System.Windows.Forms.Button IspisiButun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RichTextBox;
    }
}

