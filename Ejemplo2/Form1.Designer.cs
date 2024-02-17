namespace Ejemplo2
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
            tabControl1 = new TabControl();
            tab1 = new TabPage();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            resultado = new Label();
            label9 = new Label();
            num1 = new TextBox();
            num2 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            tabPage1 = new TabPage();
            tabControl1.SuspendLayout();
            tab1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab1);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(3, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(631, 447);
            tabControl1.TabIndex = 0;
            // 
            // tab1
            // 
            tab1.Controls.Add(groupBox2);
            tab1.Controls.Add(groupBox1);
            tab1.Location = new Point(4, 24);
            tab1.Name = "tab1";
            tab1.Padding = new Padding(3);
            tab1.Size = new Size(623, 419);
            tab1.TabIndex = 0;
            tab1.Text = "Herramientas";
            tab1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(resultado);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(num1);
            groupBox2.Controls.Add(num2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(15, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(590, 154);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operaciones";
            // 
            // button5
            // 
            button5.Location = new Point(230, 55);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "RESTAR";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(311, 55);
            button3.Name = "button3";
            button3.Size = new Size(87, 23);
            button3.TabIndex = 5;
            button3.Text = "DIVIDIR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(230, 30);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "SUMAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(311, 30);
            button2.Name = "button2";
            button2.Size = new Size(87, 23);
            button2.TabIndex = 4;
            button2.Text = "MULTIPLICAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(100, 108);
            resultado.Name = "resultado";
            resultado.Size = new Size(0, 15);
            resultado.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 108);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 2;
            label9.Text = "Resultado:";
            // 
            // num1
            // 
            num1.Location = new Point(100, 30);
            num1.Name = "num1";
            num1.Size = new Size(59, 23);
            num1.TabIndex = 1;
            // 
            // num2
            // 
            num2.Location = new Point(100, 56);
            num2.Name = "num2";
            num2.Size = new Size(59, 23);
            num2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 33);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 0;
            label8.Text = "Numero A:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 59);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 0;
            label7.Text = "Numero B:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 188);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(590, 213);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Propiedades de dispositivo";
            // 
            // button1
            // 
            button1.Location = new Point(486, 170);
            button1.Name = "button1";
            button1.Size = new Size(83, 23);
            button1.TabIndex = 2;
            button1.Text = "Propiedades";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(136, 110);
            label6.Name = "label6";
            label6.Size = new Size(221, 15);
            label6.TabIndex = 1;
            label6.Text = "Este dispositivo funciona correctamente.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 71);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 1;
            label4.Text = "Bus Number 2, Target 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 36);
            label2.Name = "label2";
            label2.Size = new Size(179, 15);
            label2.TabIndex = 1;
            label2.Text = "(Unidades de CD-ROM estandar)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 110);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 0;
            label5.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 71);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 0;
            label3.Text = "Ubicacion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 36);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Fabricante:";
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(623, 419);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Propiedades: Disco local (C:)";
            tabControl1.ResumeLayout(false);
            tab1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tab1;
        private GroupBox groupBox1;
        private TabPage tabPage1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button button1;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private TextBox num2;
        private Label label7;
        private Button button5;
        private Button button3;
        private Button button4;
        private Button button2;
        private Label resultado;
        private Label label9;
        private TextBox num1;
        private Label label8;
    }
}
