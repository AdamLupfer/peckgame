namespace DesktopApp1
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
            this.Startbutn = new System.Windows.Forms.Button();
            this.Pecklbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Wordlbl = new System.Windows.Forms.Label();
            this.Countlbl = new System.Windows.Forms.Label();
            this.mistakelbl = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Startbutn
            // 
            this.Startbutn.Location = new System.Drawing.Point(199, 116);
            this.Startbutn.Margin = new System.Windows.Forms.Padding(2);
            this.Startbutn.Name = "Startbutn";
            this.Startbutn.Size = new System.Drawing.Size(97, 28);
            this.Startbutn.TabIndex = 0;
            this.Startbutn.Text = "START";
            this.Startbutn.UseVisualStyleBackColor = true;
            this.Startbutn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pecklbl
            // 
            this.Pecklbl.Location = new System.Drawing.Point(196, 26);
            this.Pecklbl.Name = "Pecklbl";
            this.Pecklbl.Size = new System.Drawing.Size(100, 23);
            this.Pecklbl.TabIndex = 3;
            this.Pecklbl.Text = "PECK";
            this.Pecklbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Wordlbl
            // 
            this.Wordlbl.Location = new System.Drawing.Point(170, 91);
            this.Wordlbl.Name = "Wordlbl";
            this.Wordlbl.Size = new System.Drawing.Size(151, 23);
            this.Wordlbl.TabIndex = 1;
            this.Wordlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Countlbl
            // 
            this.Countlbl.Location = new System.Drawing.Point(81, 229);
            this.Countlbl.Name = "Countlbl";
            this.Countlbl.Size = new System.Drawing.Size(100, 23);
            this.Countlbl.TabIndex = 4;
            this.Countlbl.Text = "Words Pecked: ";
            this.Countlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Countlbl.Visible = false;
            // 
            // mistakelbl
            // 
            this.mistakelbl.Location = new System.Drawing.Point(327, 234);
            this.mistakelbl.Name = "mistakelbl";
            this.mistakelbl.Size = new System.Drawing.Size(124, 23);
            this.mistakelbl.TabIndex = 5;
            this.mistakelbl.Text = "Mistakes:";
            this.mistakelbl.Visible = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(390, 35);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(41, 13);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "Score: ";
            this.scoreLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.mistakelbl);
            this.Controls.Add(this.Countlbl);
            this.Controls.Add(this.Wordlbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Pecklbl);
            this.Controls.Add(this.Startbutn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peck";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Startbutn;
        private System.Windows.Forms.Label Pecklbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Wordlbl;
        private System.Windows.Forms.Label Countlbl;
        private System.Windows.Forms.Label mistakelbl;
        private System.Windows.Forms.Label scoreLabel;
    }
}

