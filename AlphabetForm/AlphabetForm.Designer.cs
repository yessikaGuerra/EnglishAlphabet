namespace AlphabetForm
{
    partial class AlphabetForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TopLabel = new System.Windows.Forms.Label();
            this.MiddleLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(756, 39);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Location = new System.Drawing.Point(20, 50);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(485, 32);
            this.TopLabel.TabIndex = 0;
            this.TopLabel.Text = "This app displays all of the English alphabet.";
            // 
            // MiddleLabel
            // 
            this.MiddleLabel.AutoSize = true;
            this.MiddleLabel.Location = new System.Drawing.Point(20, 97);
            this.MiddleLabel.Name = "MiddleLabel";
            this.MiddleLabel.Size = new System.Drawing.Size(558, 32);
            this.MiddleLabel.TabIndex = 1;
            this.MiddleLabel.Text = "To exclude letters enter them in the textbox below:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Location = new System.Drawing.Point(20, 340);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(604, 64);
            this.ResultsLabel.TabIndex = 4;
            this.ResultsLabel.Text = "Too many characters entered, maximum allowed is 256.\nPlease delete some character" +
    "s.";
            this.ResultsLabel.Visible = false;
            // 
            // AlphabetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MiddleLabel);
            this.Controls.Add(this.TopLabel);
            this.Name = "AlphabetForm";
            this.Text = "Alphabet Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox1;
        private Label TopLabel;
        private Label MiddleLabel;
        private Button button1;
        private Label ResultsLabel;
    }
}