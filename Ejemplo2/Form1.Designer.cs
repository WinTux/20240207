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
            button6 = new Button();
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
            groupBox3 = new GroupBox();
            lblColorCirc = new Label();
            lblAreaCirc = new Label();
            label16 = new Label();
            label15 = new Label();
            button8 = new Button();
            txtRadio = new TextBox();
            label14 = new Label();
            lblColor = new Label();
            label13 = new Label();
            lblArea = new Label();
            label12 = new Label();
            button7 = new Button();
            txtBase = new TextBox();
            txtAltura = new TextBox();
            label11 = new Label();
            label10 = new Label();
            tabPage2 = new TabPage();
            groupBox5 = new GroupBox();
            lblEliminado = new Label();
            button13 = new Button();
            lblPila = new Label();
            button12 = new Button();
            txtGetPila = new TextBox();
            label21 = new Label();
            groupBox4 = new GroupBox();
            button11 = new Button();
            lblMostrarListaEmpleados = new Label();
            button10 = new Button();
            txtTelefonoEmpleado = new TextBox();
            txtApellidoEmpleado = new TextBox();
            txtNombreEmpleado = new TextBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            lblMostrarLista = new Label();
            button9 = new Button();
            txtGetLista = new TextBox();
            label17 = new Label();
            groupBox6 = new GroupBox();
            label22 = new Label();
            txtCola = new TextBox();
            button14 = new Button();
            button15 = new Button();
            lblElementosCola = new Label();
            lblEliminadoCola = new Label();
            tabControl1.SuspendLayout();
            tab1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab1);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
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
            groupBox2.Controls.Add(button6);
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
            // button6
            // 
            button6.Location = new Point(102, 86);
            button6.Name = "button6";
            button6.Size = new Size(57, 23);
            button6.TabIndex = 6;
            button6.Text = "VACIAR";
            button6.UseVisualStyleBackColor = true;
            button6.Click += VaciarCampos;
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
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(lblColor);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(lblArea);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(button7);
            tabPage1.Controls.Add(txtBase);
            tabPage1.Controls.Add(txtAltura);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label10);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(623, 419);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Polimorfismo";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblColorCirc);
            groupBox3.Controls.Add(lblAreaCirc);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(button8);
            groupBox3.Controls.Add(txtRadio);
            groupBox3.Controls.Add(label14);
            groupBox3.Location = new Point(6, 151);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(319, 113);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // lblColorCirc
            // 
            lblColorCirc.AutoSize = true;
            lblColorCirc.Location = new Point(71, 86);
            lblColorCirc.Name = "lblColorCirc";
            lblColorCirc.Size = new Size(0, 15);
            lblColorCirc.TabIndex = 6;
            // 
            // lblAreaCirc
            // 
            lblAreaCirc.AutoSize = true;
            lblAreaCirc.Location = new Point(71, 62);
            lblAreaCirc.Name = "lblAreaCirc";
            lblAreaCirc.Size = new Size(0, 15);
            lblAreaCirc.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(12, 86);
            label16.Name = "label16";
            label16.Size = new Size(39, 15);
            label16.TabIndex = 4;
            label16.Text = "Color:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 62);
            label15.Name = "label15";
            label15.Size = new Size(34, 15);
            label15.TabIndex = 3;
            label15.Text = "Area:";
            // 
            // button8
            // 
            button8.Location = new Point(198, 26);
            button8.Name = "button8";
            button8.Size = new Size(99, 23);
            button8.TabIndex = 2;
            button8.Text = "Area circulo";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(71, 26);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(100, 23);
            txtRadio.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 29);
            label14.Name = "label14";
            label14.Size = new Size(40, 15);
            label14.TabIndex = 0;
            label14.Text = "Radio:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(77, 113);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(0, 15);
            lblColor.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 113);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 7;
            label13.Text = "Color:";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(77, 79);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(0, 15);
            lblArea.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 79);
            label12.Name = "label12";
            label12.Size = new Size(34, 15);
            label12.TabIndex = 5;
            label12.Text = "Area:";
            // 
            // button7
            // 
            button7.Location = new Point(204, 11);
            button7.Name = "button7";
            button7.Size = new Size(99, 23);
            button7.TabIndex = 4;
            button7.Text = "Area cuadrado";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(77, 39);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(100, 23);
            txtBase.TabIndex = 3;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(77, 11);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 42);
            label11.Name = "label11";
            label11.Size = new Size(34, 15);
            label11.TabIndex = 1;
            label11.Text = "Base:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 14);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 0;
            label10.Text = "Altura:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox6);
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(623, 419);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Estructuras de datos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblEliminado);
            groupBox5.Controls.Add(button13);
            groupBox5.Controls.Add(lblPila);
            groupBox5.Controls.Add(button12);
            groupBox5.Controls.Add(txtGetPila);
            groupBox5.Controls.Add(label21);
            groupBox5.Location = new Point(231, 18);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(197, 387);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Pilas";
            // 
            // lblEliminado
            // 
            lblEliminado.AutoSize = true;
            lblEliminado.Location = new Point(80, 119);
            lblEliminado.Name = "lblEliminado";
            lblEliminado.Size = new Size(0, 15);
            lblEliminado.TabIndex = 5;
            // 
            // button13
            // 
            button13.Location = new Point(81, 86);
            button13.Name = "button13";
            button13.Size = new Size(98, 23);
            button13.TabIndex = 4;
            button13.Text = "Eliminar";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // lblPila
            // 
            lblPila.AutoSize = true;
            lblPila.Location = new Point(15, 94);
            lblPila.Name = "lblPila";
            lblPila.Size = new Size(0, 15);
            lblPila.TabIndex = 3;
            // 
            // button12
            // 
            button12.Location = new Point(79, 53);
            button12.Name = "button12";
            button12.Size = new Size(100, 23);
            button12.TabIndex = 2;
            button12.Text = "Agregar";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // txtGetPila
            // 
            txtGetPila.Location = new Point(79, 18);
            txtGetPila.Name = "txtGetPila";
            txtGetPila.Size = new Size(100, 23);
            txtGetPila.TabIndex = 1;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(10, 23);
            label21.Name = "label21";
            label21.Size = new Size(63, 15);
            label21.TabIndex = 0;
            label21.Text = "Lenguajes:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button11);
            groupBox4.Controls.Add(lblMostrarListaEmpleados);
            groupBox4.Controls.Add(button10);
            groupBox4.Controls.Add(txtTelefonoEmpleado);
            groupBox4.Controls.Add(txtApellidoEmpleado);
            groupBox4.Controls.Add(txtNombreEmpleado);
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(lblMostrarLista);
            groupBox4.Controls.Add(button9);
            groupBox4.Controls.Add(txtGetLista);
            groupBox4.Controls.Add(label17);
            groupBox4.Location = new Point(11, 11);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(210, 394);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Listas";
            // 
            // button11
            // 
            button11.Location = new Point(139, 293);
            button11.Name = "button11";
            button11.Size = new Size(65, 23);
            button11.TabIndex = 12;
            button11.Text = "Eliminar";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // lblMostrarListaEmpleados
            // 
            lblMostrarListaEmpleados.AutoSize = true;
            lblMostrarListaEmpleados.Location = new Point(6, 330);
            lblMostrarListaEmpleados.Name = "lblMostrarListaEmpleados";
            lblMostrarListaEmpleados.Size = new Size(44, 15);
            lblMostrarListaEmpleados.TabIndex = 11;
            lblMostrarListaEmpleados.Text = "label21";
            // 
            // button10
            // 
            button10.Location = new Point(18, 293);
            button10.Name = "button10";
            button10.Size = new Size(115, 23);
            button10.TabIndex = 10;
            button10.Text = "Agregar Empleado";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // txtTelefonoEmpleado
            // 
            txtTelefonoEmpleado.Location = new Point(85, 264);
            txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            txtTelefonoEmpleado.Size = new Size(100, 23);
            txtTelefonoEmpleado.TabIndex = 9;
            // 
            // txtApellidoEmpleado
            // 
            txtApellidoEmpleado.Location = new Point(89, 237);
            txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            txtApellidoEmpleado.Size = new Size(100, 23);
            txtApellidoEmpleado.TabIndex = 8;
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(88, 207);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(100, 23);
            txtNombreEmpleado.TabIndex = 7;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(18, 259);
            label20.Name = "label20";
            label20.Size = new Size(55, 15);
            label20.TabIndex = 6;
            label20.Text = "Telefono:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(18, 237);
            label19.Name = "label19";
            label19.Size = new Size(54, 15);
            label19.TabIndex = 5;
            label19.Text = "Apellido:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(16, 209);
            label18.Name = "label18";
            label18.Size = new Size(54, 15);
            label18.TabIndex = 4;
            label18.Text = "Nombre:";
            // 
            // lblMostrarLista
            // 
            lblMostrarLista.AutoSize = true;
            lblMostrarLista.Location = new Point(15, 116);
            lblMostrarLista.Name = "lblMostrarLista";
            lblMostrarLista.Size = new Size(0, 15);
            lblMostrarLista.TabIndex = 3;
            // 
            // button9
            // 
            button9.Location = new Point(82, 65);
            button9.Name = "button9";
            button9.Size = new Size(100, 23);
            button9.TabIndex = 2;
            button9.Text = "Agregar";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // txtGetLista
            // 
            txtGetLista.Location = new Point(82, 25);
            txtGetLista.Name = "txtGetLista";
            txtGetLista.Size = new Size(100, 23);
            txtGetLista.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(12, 28);
            label17.Name = "label17";
            label17.Size = new Size(54, 15);
            label17.TabIndex = 0;
            label17.Text = "Nombre:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lblEliminadoCola);
            groupBox6.Controls.Add(lblElementosCola);
            groupBox6.Controls.Add(button15);
            groupBox6.Controls.Add(button14);
            groupBox6.Controls.Add(txtCola);
            groupBox6.Controls.Add(label22);
            groupBox6.Location = new Point(437, 27);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(180, 378);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Colas";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(10, 29);
            label22.Name = "label22";
            label22.Size = new Size(42, 15);
            label22.TabIndex = 0;
            label22.Text = "Platos:";
            // 
            // txtCola
            // 
            txtCola.Location = new Point(62, 27);
            txtCola.Name = "txtCola";
            txtCola.Size = new Size(100, 23);
            txtCola.TabIndex = 1;
            // 
            // button14
            // 
            button14.Location = new Point(61, 60);
            button14.Name = "button14";
            button14.Size = new Size(75, 23);
            button14.TabIndex = 2;
            button14.Text = "Agergar";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(62, 90);
            button15.Name = "button15";
            button15.Size = new Size(75, 23);
            button15.TabIndex = 3;
            button15.Text = "Eliminar";
            button15.UseVisualStyleBackColor = true;
            // 
            // lblElementosCola
            // 
            lblElementosCola.AutoSize = true;
            lblElementosCola.Location = new Point(10, 172);
            lblElementosCola.Name = "lblElementosCola";
            lblElementosCola.Size = new Size(0, 15);
            lblElementosCola.TabIndex = 4;
            // 
            // lblEliminadoCola
            // 
            lblEliminadoCola.AutoSize = true;
            lblEliminadoCola.Location = new Point(63, 117);
            lblEliminadoCola.Name = "lblEliminadoCola";
            lblEliminadoCola.Size = new Size(0, 15);
            lblEliminadoCola.TabIndex = 5;
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
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
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
        private Button button6;
        private TextBox txtBase;
        private TextBox txtAltura;
        private Label label11;
        private Label label10;
        private Label lblArea;
        private Label label12;
        private Button button7;
        private Label lblColor;
        private Label label13;
        private GroupBox groupBox3;
        private Label lblAreaCirc;
        private Label label16;
        private Label label15;
        private Button button8;
        private TextBox txtRadio;
        private Label label14;
        private Label lblColorCirc;
        private TabPage tabPage2;
        private GroupBox groupBox4;
        private Label lblMostrarLista;
        private Button button9;
        private TextBox txtGetLista;
        private Label label17;
        private Label lblMostrarListaEmpleados;
        private Button button10;
        private TextBox txtTelefonoEmpleado;
        private TextBox txtApellidoEmpleado;
        private TextBox txtNombreEmpleado;
        private Label label20;
        private Label label19;
        private Label label18;
        private Button button11;
        private GroupBox groupBox5;
        private Button button12;
        private TextBox txtGetPila;
        private Label label21;
        private Label lblPila;
        private Label lblEliminado;
        private Button button13;
        private GroupBox groupBox6;
        private Label lblEliminadoCola;
        private Label lblElementosCola;
        private Button button15;
        private Button button14;
        private TextBox txtCola;
        private Label label22;
    }
}
