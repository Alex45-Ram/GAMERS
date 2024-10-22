namespace GAMERS
{
    partial class Validacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Validacion));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Pass = new TextBox();
            pictureBox1 = new PictureBox();
            btnValidar = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Snap ITC", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 12);
            label1.Name = "label1";
            label1.Size = new Size(685, 103);
            label1.TabIndex = 0;
            label1.Text = "GAME ZONE ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(350, 138);
            label2.Name = "label2";
            label2.Size = new Size(453, 33);
            label2.TabIndex = 1;
            label2.Text = "Ingrese los siguientes datos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(486, 239);
            label3.Name = "label3";
            label3.Size = new Size(144, 33);
            label3.TabIndex = 2;
            label3.Text = "Usuario:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(450, 396);
            label4.Name = "label4";
            label4.Size = new Size(199, 33);
            label4.TabIndex = 3;
            label4.Text = "Contraseña:";
            // 
            // Pass
            // 
            Pass.Location = new Point(386, 459);
            Pass.Name = "Pass";
            Pass.Size = new Size(326, 27);
            Pass.TabIndex = 5;
            Pass.TextChanged += Pass_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-31, -187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1277, 800);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnValidar
            // 
            btnValidar.BackColor = SystemColors.ActiveCaption;
            btnValidar.Cursor = Cursors.Hand;
            btnValidar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidar.Location = new Point(1068, 552);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(178, 64);
            btnValidar.TabIndex = 7;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(917, 49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(311, 437);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 107);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(295, 400);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Empleado", "Admin" });
            comboBox1.Location = new Point(386, 297);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(326, 36);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "    Seleccione un usuario:";
            // 
            // Validacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 617);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(btnValidar);
            Controls.Add(Pass);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Validacion";
            Load += Validacion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Pass;
        private PictureBox pictureBox1;
        private Button btnValidar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ComboBox comboBox1;
    }
}
