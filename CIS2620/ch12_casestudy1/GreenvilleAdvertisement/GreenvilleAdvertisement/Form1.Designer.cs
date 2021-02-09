
namespace GreenvilleAdvertisement
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.redRadio = new System.Windows.Forms.RadioButton();
            this.greenRadio = new System.Windows.Forms.RadioButton();
            this.blueRadio = new System.Windows.Forms.RadioButton();
            this.colorPickLabel = new System.Windows.Forms.Label();
            this.textBoxLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.Label();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.creadAdButton = new System.Windows.Forms.Button();
            this.secondLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(24, 33);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(171, 20);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome To Greenville";
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // redRadio
            // 
            this.redRadio.AutoSize = true;
            this.redRadio.Location = new System.Drawing.Point(28, 237);
            this.redRadio.Name = "redRadio";
            this.redRadio.Size = new System.Drawing.Size(45, 17);
            this.redRadio.TabIndex = 1;
            this.redRadio.TabStop = true;
            this.redRadio.Text = "Red";
            this.redRadio.UseVisualStyleBackColor = true;
            this.redRadio.CheckedChanged += new System.EventHandler(this.redRadio_CheckedChanged);
            // 
            // greenRadio
            // 
            this.greenRadio.AutoSize = true;
            this.greenRadio.Location = new System.Drawing.Point(28, 260);
            this.greenRadio.Name = "greenRadio";
            this.greenRadio.Size = new System.Drawing.Size(54, 17);
            this.greenRadio.TabIndex = 2;
            this.greenRadio.TabStop = true;
            this.greenRadio.Text = "Green";
            this.greenRadio.UseVisualStyleBackColor = true;
            this.greenRadio.CheckedChanged += new System.EventHandler(this.greenRadio_CheckedChanged);
            // 
            // blueRadio
            // 
            this.blueRadio.AutoSize = true;
            this.blueRadio.Location = new System.Drawing.Point(28, 283);
            this.blueRadio.Name = "blueRadio";
            this.blueRadio.Size = new System.Drawing.Size(46, 17);
            this.blueRadio.TabIndex = 3;
            this.blueRadio.TabStop = true;
            this.blueRadio.Text = "Blue";
            this.blueRadio.UseVisualStyleBackColor = true;
            this.blueRadio.CheckedChanged += new System.EventHandler(this.blueRadio_CheckedChanged);
            // 
            // colorPickLabel
            // 
            this.colorPickLabel.AutoSize = true;
            this.colorPickLabel.Location = new System.Drawing.Point(23, 213);
            this.colorPickLabel.Name = "colorPickLabel";
            this.colorPickLabel.Size = new System.Drawing.Size(136, 13);
            this.colorPickLabel.TabIndex = 4;
            this.colorPickLabel.Text = "What is your favorite color?";
            this.colorPickLabel.Click += new System.EventHandler(this.colorPickLabel_Click);
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.AutoSize = true;
            this.textBoxLabel.Location = new System.Drawing.Point(23, 151);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(102, 13);
            this.textBoxLabel.TabIndex = 5;
            this.textBoxLabel.Text = "What\'s Your Name?";
            this.textBoxLabel.Click += new System.EventHandler(this.textBoxLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // locationBox
            // 
            this.locationBox.AutoSize = true;
            this.locationBox.Location = new System.Drawing.Point(25, 331);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(112, 13);
            this.locationBox.TabIndex = 7;
            this.locationBox.Text = "Where Are You From?";
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.Items.AddRange(new object[] {
            "New York",
            "Minnesota",
            "Florida"});
            this.locationListBox.Location = new System.Drawing.Point(28, 357);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(120, 56);
            this.locationListBox.TabIndex = 8;
            this.locationListBox.SelectedIndexChanged += new System.EventHandler(this.locationListBox_SelectedIndexChanged);
            // 
            // creadAdButton
            // 
            this.creadAdButton.Location = new System.Drawing.Point(375, 390);
            this.creadAdButton.Name = "creadAdButton";
            this.creadAdButton.Size = new System.Drawing.Size(75, 23);
            this.creadAdButton.TabIndex = 9;
            this.creadAdButton.Text = "Create Ad";
            this.creadAdButton.UseVisualStyleBackColor = true;
            this.creadAdButton.Click += new System.EventHandler(this.creadAdButton_Click);
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Location = new System.Drawing.Point(28, 73);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(172, 13);
            this.secondLabel.TabIndex = 10;
            this.secondLabel.Text = "Create an Ad with the menu below.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.creadAdButton);
            this.Controls.Add(this.locationListBox);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.colorPickLabel);
            this.Controls.Add(this.blueRadio);
            this.Controls.Add(this.greenRadio);
            this.Controls.Add(this.redRadio);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Form1";
            this.Text = "Greenville Advertisement";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.RadioButton redRadio;
        private System.Windows.Forms.RadioButton greenRadio;
        private System.Windows.Forms.RadioButton blueRadio;
        private System.Windows.Forms.Label colorPickLabel;
        private System.Windows.Forms.Label textBoxLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label locationBox;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.Button creadAdButton;
        private System.Windows.Forms.Label secondLabel;
    }
}

