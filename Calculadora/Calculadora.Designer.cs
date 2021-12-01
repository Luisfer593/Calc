
namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnMasMenos = new System.Windows.Forms.Button();
            this.btnRaizCuadrada = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnPorciento = new System.Windows.Forms.Button();
            this.btnMedio = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnDivicion = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.Black;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtResultado.Location = new System.Drawing.Point(51, 47);
            this.txtResultado.MaxLength = 21;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(269, 35);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1.Location = new System.Drawing.Point(51, 256);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 45);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn2.Location = new System.Drawing.Point(102, 256);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 45);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn3.Location = new System.Drawing.Point(153, 256);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 45);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn6.Location = new System.Drawing.Point(153, 205);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 45);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn5.Location = new System.Drawing.Point(102, 205);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 45);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Black;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn4.Location = new System.Drawing.Point(51, 205);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 45);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Black;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn9.Location = new System.Drawing.Point(153, 154);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 45);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn8.Location = new System.Drawing.Point(102, 154);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 45);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Black;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn7.Location = new System.Drawing.Point(51, 154);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 45);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBorrar.Location = new System.Drawing.Point(153, 103);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(45, 45);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "◄";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnC.Location = new System.Drawing.Point(102, 102);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(45, 45);
            this.btnC.TabIndex = 11;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCE.Location = new System.Drawing.Point(51, 103);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(45, 45);
            this.btnCE.TabIndex = 10;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPunto.Location = new System.Drawing.Point(153, 307);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(45, 45);
            this.btnPunto.TabIndex = 15;
            this.btnPunto.Text = ",";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn0.Location = new System.Drawing.Point(102, 307);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(45, 45);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnMasMenos
            // 
            this.btnMasMenos.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnMasMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasMenos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMasMenos.Location = new System.Drawing.Point(51, 307);
            this.btnMasMenos.Name = "btnMasMenos";
            this.btnMasMenos.Size = new System.Drawing.Size(45, 45);
            this.btnMasMenos.TabIndex = 13;
            this.btnMasMenos.Text = "±";
            this.btnMasMenos.UseVisualStyleBackColor = false;
            this.btnMasMenos.Click += new System.EventHandler(this.btnMasMenos_Click);
            // 
            // btnRaizCuadrada
            // 
            this.btnRaizCuadrada.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnRaizCuadrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaizCuadrada.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRaizCuadrada.Location = new System.Drawing.Point(224, 153);
            this.btnRaizCuadrada.Name = "btnRaizCuadrada";
            this.btnRaizCuadrada.Size = new System.Drawing.Size(45, 45);
            this.btnRaizCuadrada.TabIndex = 18;
            this.btnRaizCuadrada.Tag = "²";
            this.btnRaizCuadrada.Text = "x²";
            this.btnRaizCuadrada.UseVisualStyleBackColor = false;
            this.btnRaizCuadrada.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRaiz.Location = new System.Drawing.Point(275, 154);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(45, 45);
            this.btnRaiz.TabIndex = 17;
            this.btnRaiz.Tag = "√";
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnPorciento
            // 
            this.btnPorciento.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnPorciento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorciento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPorciento.Location = new System.Drawing.Point(224, 102);
            this.btnPorciento.Name = "btnPorciento";
            this.btnPorciento.Size = new System.Drawing.Size(45, 45);
            this.btnPorciento.TabIndex = 16;
            this.btnPorciento.Tag = "%";
            this.btnPorciento.Text = "%";
            this.btnPorciento.UseVisualStyleBackColor = false;
            this.btnPorciento.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnMedio
            // 
            this.btnMedio.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMedio.Location = new System.Drawing.Point(275, 102);
            this.btnMedio.Name = "btnMedio";
            this.btnMedio.Size = new System.Drawing.Size(45, 45);
            this.btnMedio.TabIndex = 29;
            this.btnMedio.Tag = "M+";
            this.btnMedio.Text = "M+";
            this.btnMedio.UseVisualStyleBackColor = false;
            this.btnMedio.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIgual.Location = new System.Drawing.Point(224, 307);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(96, 45);
            this.btnIgual.TabIndex = 27;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnDivicion
            // 
            this.btnDivicion.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnDivicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivicion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDivicion.Location = new System.Drawing.Point(275, 205);
            this.btnDivicion.Name = "btnDivicion";
            this.btnDivicion.Size = new System.Drawing.Size(45, 45);
            this.btnDivicion.TabIndex = 25;
            this.btnDivicion.Tag = "÷";
            this.btnDivicion.Text = "÷";
            this.btnDivicion.UseVisualStyleBackColor = false;
            this.btnDivicion.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMultiplicacion.Location = new System.Drawing.Point(224, 205);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(45, 45);
            this.btnMultiplicacion.TabIndex = 23;
            this.btnMultiplicacion.Tag = "*";
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResta.Location = new System.Drawing.Point(275, 254);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(45, 45);
            this.btnResta.TabIndex = 21;
            this.btnResta.Tag = "-";
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSuma.Location = new System.Drawing.Point(224, 254);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(45, 45);
            this.btnSuma.TabIndex = 19;
            this.btnSuma.Tag = "+";
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.clickoperador);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(363, 380);
            this.Controls.Add(this.btnMedio);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnDivicion);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnRaizCuadrada);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnPorciento);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnMasMenos);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtResultado);
            this.Name = "Calculadora";
            this.Text = "CALCULADORA BÁSICA";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnMasMenos;
        private System.Windows.Forms.Button btnRaizCuadrada;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnPorciento;
        private System.Windows.Forms.Button btnMedio;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnDivicion;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSuma;
    }
}

