namespace GAMERS
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkOrchid;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(530, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 36);
            textBox1.TabIndex = 0;
            textBox1.Text = "ADMINISTRACION";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkOrchid;
            textBox2.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(33, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 34);
            textBox2.TabIndex = 2;
            textBox2.Text = "Stock de mercancia";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.DarkOrchid;
            comboBox1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = SystemColors.InfoText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "Semanales", "Quincenales", "Mensuales", "Anales" });
            comboBox1.Location = new Point(989, 87);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 36);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Ingresos";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrchid;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(64, 129);
            button1.Name = "button1";
            button1.Size = new Size(115, 46);
            button1.TabIndex = 5;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(330, 201);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(612, 404);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-4, -10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1244, 627);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.BlueViolet;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(571, 87);
            button2.Name = "button2";
            button2.Size = new Size(170, 75);
            button2.TabIndex = 8;
            button2.Text = "Agregar Usuario";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 617);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox3);
            Name = "Admin";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button2;
    }
}