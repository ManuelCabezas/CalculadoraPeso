namespace CalculadoraIMC
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
            label2 = new Label();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            label3 = new Label();
            label4 = new Label();
            rbtnMujer = new RadioButton();
            groupBox1 = new GroupBox();
            rbtnHombre = new RadioButton();
            txtEdad = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 249);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Altura(cm):";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(163, 246);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(138, 312);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(112, 61);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 5;
            label3.Text = "Calcular peso ideal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 198);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "Edad:";
            // 
            // rbtnMujer
            // 
            rbtnMujer.AutoSize = true;
            rbtnMujer.Location = new Point(66, 26);
            rbtnMujer.Name = "rbtnMujer";
            rbtnMujer.Size = new Size(37, 24);
            rbtnMujer.TabIndex = 12;
            rbtnMujer.TabStop = true;
            rbtnMujer.Text = "F";
            rbtnMujer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnHombre);
            groupBox1.Controls.Add(rbtnMujer);
            groupBox1.Location = new Point(75, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(123, 56);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sexo";
            // 
            // rbtnHombre
            // 
            rbtnHombre.AutoSize = true;
            rbtnHombre.Location = new Point(17, 26);
            rbtnHombre.Name = "rbtnHombre";
            rbtnHombre.Size = new Size(43, 24);
            rbtnHombre.TabIndex = 13;
            rbtnHombre.TabStop = true;
            rbtnHombre.Text = "M";
            rbtnHombre.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(163, 198);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 27);
            txtEdad.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(366, 450);
            Controls.Add(txtEdad);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(label2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Peso Ideal";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Label label3;
        private Label label4;
        private Label label7;
        private RadioButton radioButton1;
        private RadioButton rbtnMujer;
        private GroupBox groupBox1;
        private TextBox txtEdad;
        private RadioButton rbtnHombre;
    }
}
