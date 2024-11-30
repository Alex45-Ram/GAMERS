namespace GAMERS
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            pictureBoxCaptcha = new PictureBox();
            button1 = new Button();
            textBoxCaptcha = new TextBox();
            button2 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCaptcha).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCaptcha
            // 
            pictureBoxCaptcha.Location = new Point(308, 191);
            pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            pictureBoxCaptcha.Size = new Size(223, 64);
            pictureBoxCaptcha.TabIndex = 0;
            pictureBoxCaptcha.TabStop = false;
            pictureBoxCaptcha.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 402);
            button1.Name = "button1";
            button1.Size = new Size(124, 49);
            button1.TabIndex = 1;
            button1.Text = "Otro texto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxCaptcha
            // 
            textBoxCaptcha.Location = new Point(279, 311);
            textBoxCaptcha.Name = "textBoxCaptcha";
            textBoxCaptcha.Size = new Size(270, 27);
            textBoxCaptcha.TabIndex = 2;
            textBoxCaptcha.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(675, 402);
            button2.Name = "button2";
            button2.Size = new Size(124, 49);
            button2.TabIndex = 3;
            button2.Text = "Verificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PowderBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox5);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 39);
            panel2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(759, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 35);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1762, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 35);
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 62);
            label1.Name = "label1";
            label1.Size = new Size(447, 41);
            label1.TabIndex = 20;
            label1.Text = "Complete el siguiente Captcha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 274);
            label2.Name = "label2";
            label2.Size = new Size(202, 20);
            label2.TabIndex = 21;
            label2.Text = "Ingrese el texto de la imagen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(279, 103);
            label3.Name = "label3";
            label3.Size = new Size(296, 41);
            label3.TabIndex = 22;
            label3.Text = "para poder ingresar";
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(textBoxCaptcha);
            Controls.Add(button1);
            Controls.Add(pictureBoxCaptcha);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Test";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test";
            Load += Test_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCaptcha).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxCaptcha;
        private Button button1;
        private TextBox textBoxCaptcha;
        private Button button2;
        private Panel panel2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}