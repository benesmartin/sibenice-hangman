
namespace Sibenice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.tbChar = new System.Windows.Forms.TextBox();
            this.lbWord = new System.Windows.Forms.Label();
            this.lbChars = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb1.Image = global::Sibenice.Properties.Resources.hangman11;
            this.pb1.InitialImage = null;
            this.pb1.Location = new System.Drawing.Point(1, 0);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(405, 450);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(412, 387);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(387, 63);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nové slovo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tbChar
            // 
            this.tbChar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbChar.Location = new System.Drawing.Point(412, 229);
            this.tbChar.MaxLength = 1;
            this.tbChar.Name = "tbChar";
            this.tbChar.Size = new System.Drawing.Size(387, 23);
            this.tbChar.TabIndex = 3;
            this.tbChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbChar.TextChanged += new System.EventHandler(this.tbChar_TextChanged);
            // 
            // lbWord
            // 
            this.lbWord.BackColor = System.Drawing.SystemColors.Control;
            this.lbWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbWord.Cursor = System.Windows.Forms.Cursors.No;
            this.lbWord.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWord.Location = new System.Drawing.Point(412, 0);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(387, 226);
            this.lbWord.TabIndex = 5;
            this.lbWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbChars
            // 
            this.lbChars.BackColor = System.Drawing.SystemColors.Control;
            this.lbChars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbChars.Cursor = System.Windows.Forms.Cursors.No;
            this.lbChars.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbChars.Location = new System.Drawing.Point(412, 255);
            this.lbChars.Name = "lbChars";
            this.lbChars.Size = new System.Drawing.Size(387, 129);
            this.lbChars.TabIndex = 6;
            this.lbChars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbChars);
            this.Controls.Add(this.lbWord);
            this.Controls.Add(this.tbChar);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.pb1);
            this.Name = "Form1";
            this.Text = "Teacher Hangman";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox tbChar;
        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.Label lbChars;
    }
}

