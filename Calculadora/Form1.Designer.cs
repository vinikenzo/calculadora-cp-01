namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mostrador = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.potencia = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.numero7 = new System.Windows.Forms.Button();
            this.numero8 = new System.Windows.Forms.Button();
            this.numero9 = new System.Windows.Forms.Button();
            this.soma = new System.Windows.Forms.Button();
            this.numero6 = new System.Windows.Forms.Button();
            this.numero5 = new System.Windows.Forms.Button();
            this.numero4 = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.numero0 = new System.Windows.Forms.Button();
            this.numero3 = new System.Windows.Forms.Button();
            this.numero2 = new System.Windows.Forms.Button();
            this.numero1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mostrador
            // 
            this.mostrador.Location = new System.Drawing.Point(125, 20);
            this.mostrador.Multiline = true;
            this.mostrador.Name = "mostrador";
            this.mostrador.Size = new System.Drawing.Size(551, 61);
            this.mostrador.TabIndex = 37;
            this.mostrador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(402, 107);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(134, 60);
            this.clear.TabIndex = 36;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // raiz
            // 
            this.raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.raiz.Location = new System.Drawing.Point(262, 107);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(134, 60);
            this.raiz.TabIndex = 35;
            this.raiz.Text = "√y";
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // potencia
            // 
            this.potencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.potencia.Location = new System.Drawing.Point(125, 107);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(134, 60);
            this.potencia.TabIndex = 34;
            this.potencia.Text = "x^y";
            this.potencia.UseVisualStyleBackColor = true;
            this.potencia.Click += new System.EventHandler(this.potencia_Click);
            // 
            // resultado
            // 
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.resultado.Location = new System.Drawing.Point(542, 371);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(134, 60);
            this.resultado.TabIndex = 33;
            this.resultado.Text = "=";
            this.resultado.UseVisualStyleBackColor = true;
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // divisao
            // 
            this.divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.divisao.Location = new System.Drawing.Point(542, 107);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(134, 60);
            this.divisao.TabIndex = 32;
            this.divisao.Text = "÷";
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // subtracao
            // 
            this.subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.subtracao.Location = new System.Drawing.Point(542, 239);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(134, 60);
            this.subtracao.TabIndex = 31;
            this.subtracao.Text = "-";
            this.subtracao.UseVisualStyleBackColor = true;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // numero7
            // 
            this.numero7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numero7.Location = new System.Drawing.Point(125, 173);
            this.numero7.Name = "numero7";
            this.numero7.Size = new System.Drawing.Size(131, 60);
            this.numero7.TabIndex = 30;
            this.numero7.Text = "7";
            this.numero7.UseVisualStyleBackColor = true;
            this.numero7.Click += new System.EventHandler(this.numero7_Click);
            // 
            // numero8
            // 
            this.numero8.Location = new System.Drawing.Point(262, 173);
            this.numero8.Name = "numero8";
            this.numero8.Size = new System.Drawing.Size(134, 60);
            this.numero8.TabIndex = 29;
            this.numero8.Text = "8";
            this.numero8.UseVisualStyleBackColor = true;
            this.numero8.Click += new System.EventHandler(this.numero8_Click);
            // 
            // numero9
            // 
            this.numero9.Location = new System.Drawing.Point(402, 173);
            this.numero9.Name = "numero9";
            this.numero9.Size = new System.Drawing.Size(134, 60);
            this.numero9.TabIndex = 28;
            this.numero9.Text = "9";
            this.numero9.UseVisualStyleBackColor = true;
            this.numero9.Click += new System.EventHandler(this.numero9_Click);
            // 
            // soma
            // 
            this.soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.soma.Location = new System.Drawing.Point(542, 305);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(134, 60);
            this.soma.TabIndex = 27;
            this.soma.Text = "+";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // numero6
            // 
            this.numero6.Location = new System.Drawing.Point(402, 239);
            this.numero6.Name = "numero6";
            this.numero6.Size = new System.Drawing.Size(134, 60);
            this.numero6.TabIndex = 26;
            this.numero6.Text = "6";
            this.numero6.UseVisualStyleBackColor = true;
            this.numero6.Click += new System.EventHandler(this.numero6_Click);
            // 
            // numero5
            // 
            this.numero5.Location = new System.Drawing.Point(262, 239);
            this.numero5.Name = "numero5";
            this.numero5.Size = new System.Drawing.Size(134, 60);
            this.numero5.TabIndex = 25;
            this.numero5.Text = "5";
            this.numero5.UseVisualStyleBackColor = true;
            this.numero5.Click += new System.EventHandler(this.numero5_Click);
            // 
            // numero4
            // 
            this.numero4.Location = new System.Drawing.Point(125, 239);
            this.numero4.Name = "numero4";
            this.numero4.Size = new System.Drawing.Size(131, 60);
            this.numero4.TabIndex = 24;
            this.numero4.Text = "4";
            this.numero4.UseVisualStyleBackColor = true;
            this.numero4.Click += new System.EventHandler(this.numero4_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.multiplicacao.Location = new System.Drawing.Point(542, 173);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(134, 60);
            this.multiplicacao.TabIndex = 23;
            this.multiplicacao.Text = "x";
            this.multiplicacao.UseVisualStyleBackColor = true;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // numero0
            // 
            this.numero0.Location = new System.Drawing.Point(262, 371);
            this.numero0.Name = "numero0";
            this.numero0.Size = new System.Drawing.Size(134, 60);
            this.numero0.TabIndex = 22;
            this.numero0.Text = "0";
            this.numero0.UseVisualStyleBackColor = true;
            this.numero0.Click += new System.EventHandler(this.numero0_Click);
            // 
            // numero3
            // 
            this.numero3.Location = new System.Drawing.Point(402, 305);
            this.numero3.Name = "numero3";
            this.numero3.Size = new System.Drawing.Size(134, 60);
            this.numero3.TabIndex = 21;
            this.numero3.Text = "3";
            this.numero3.UseVisualStyleBackColor = true;
            this.numero3.Click += new System.EventHandler(this.numero3_Click);
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(262, 305);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(134, 60);
            this.numero2.TabIndex = 20;
            this.numero2.Text = "2";
            this.numero2.UseVisualStyleBackColor = true;
            this.numero2.Click += new System.EventHandler(this.numero2_Click);
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(125, 305);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(131, 60);
            this.numero1.TabIndex = 19;
            this.numero1.Text = "1";
            this.numero1.UseVisualStyleBackColor = true;
            this.numero1.Click += new System.EventHandler(this.numero1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Sobre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Sobre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mostrador);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.potencia);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.numero7);
            this.Controls.Add(this.numero8);
            this.Controls.Add(this.numero9);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.numero6);
            this.Controls.Add(this.numero5);
            this.Controls.Add(this.numero4);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.numero0);
            this.Controls.Add(this.numero3);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mostrador;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button potencia;
        private System.Windows.Forms.Button resultado;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button numero7;
        private System.Windows.Forms.Button numero8;
        private System.Windows.Forms.Button numero9;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button numero6;
        private System.Windows.Forms.Button numero5;
        private System.Windows.Forms.Button numero4;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button numero0;
        private System.Windows.Forms.Button numero3;
        private System.Windows.Forms.Button numero2;
        private System.Windows.Forms.Button numero1;
        private System.Windows.Forms.Button button1;
    }
}

