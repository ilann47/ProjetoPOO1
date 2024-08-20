namespace MessageBoxExceptions
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.btnCalcularMedia = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnCliqueAqui = new System.Windows.Forms.Button();
			this.btnLimpaText = new System.Windows.Forms.Button();
			this.btnErro = new System.Windows.Forms.Button();
			this.brnAlerta = new System.Windows.Forms.Button();
			this.btnExclamação = new System.Windows.Forms.Button();
			this.btnPergunta = new System.Windows.Forms.Button();
			this.btnInfo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(115, 15);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(221, 15);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 0;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(327, 15);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 0;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(433, 15);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 0;
			// 
			// btnCalcularMedia
			// 
			this.btnCalcularMedia.Location = new System.Drawing.Point(12, 12);
			this.btnCalcularMedia.Name = "btnCalcularMedia";
			this.btnCalcularMedia.Size = new System.Drawing.Size(97, 23);
			this.btnCalcularMedia.TabIndex = 1;
			this.btnCalcularMedia.Text = "Calcular Media";
			this.btnCalcularMedia.UseVisualStyleBackColor = true;
			this.btnCalcularMedia.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Location = new System.Drawing.Point(112, 58);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(55, 13);
			this.lblResultado.TabIndex = 2;
			this.lblResultado.Text = "Resultado";
			this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
			// 
			// btnCliqueAqui
			// 
			this.btnCliqueAqui.Location = new System.Drawing.Point(12, 103);
			this.btnCliqueAqui.Name = "btnCliqueAqui";
			this.btnCliqueAqui.Size = new System.Drawing.Size(776, 55);
			this.btnCliqueAqui.TabIndex = 3;
			this.btnCliqueAqui.Text = "Clique aqui";
			this.btnCliqueAqui.UseVisualStyleBackColor = true;
			this.btnCliqueAqui.Click += new System.EventHandler(this.btnCliqueAqui_Click);
			// 
			// btnLimpaText
			// 
			this.btnLimpaText.Location = new System.Drawing.Point(12, 53);
			this.btnLimpaText.Name = "btnLimpaText";
			this.btnLimpaText.Size = new System.Drawing.Size(94, 23);
			this.btnLimpaText.TabIndex = 4;
			this.btnLimpaText.Text = "Limpar";
			this.btnLimpaText.UseVisualStyleBackColor = true;
			this.btnLimpaText.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// btnErro
			// 
			this.btnErro.Location = new System.Drawing.Point(12, 186);
			this.btnErro.Name = "btnErro";
			this.btnErro.Size = new System.Drawing.Size(133, 231);
			this.btnErro.TabIndex = 5;
			this.btnErro.Text = "ERRO";
			this.btnErro.UseVisualStyleBackColor = true;
			this.btnErro.Click += new System.EventHandler(this.btnErro_Click);
			// 
			// brnAlerta
			// 
			this.brnAlerta.Location = new System.Drawing.Point(167, 186);
			this.brnAlerta.Name = "brnAlerta";
			this.brnAlerta.Size = new System.Drawing.Size(133, 231);
			this.brnAlerta.TabIndex = 5;
			this.brnAlerta.Text = "ALERTA";
			this.brnAlerta.UseVisualStyleBackColor = true;
			this.brnAlerta.Click += new System.EventHandler(this.brnAlerta_Click);
			// 
			// btnExclamação
			// 
			this.btnExclamação.Location = new System.Drawing.Point(327, 186);
			this.btnExclamação.Name = "btnExclamação";
			this.btnExclamação.Size = new System.Drawing.Size(133, 231);
			this.btnExclamação.TabIndex = 5;
			this.btnExclamação.Text = "?";
			this.btnExclamação.UseVisualStyleBackColor = true;
			this.btnExclamação.Click += new System.EventHandler(this.btnExclamação_Click);
			// 
			// btnPergunta
			// 
			this.btnPergunta.Location = new System.Drawing.Point(478, 186);
			this.btnPergunta.Name = "btnPergunta";
			this.btnPergunta.Size = new System.Drawing.Size(133, 231);
			this.btnPergunta.TabIndex = 5;
			this.btnPergunta.Text = "PERGUNTA";
			this.btnPergunta.UseVisualStyleBackColor = true;
			this.btnPergunta.Click += new System.EventHandler(this.btnPergunta_Click);
			// 
			// btnInfo
			// 
			this.btnInfo.Location = new System.Drawing.Point(634, 186);
			this.btnInfo.Name = "btnInfo";
			this.btnInfo.Size = new System.Drawing.Size(133, 231);
			this.btnInfo.TabIndex = 5;
			this.btnInfo.Text = "INFORMAÇÂO";
			this.btnInfo.UseVisualStyleBackColor = true;
			this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnInfo);
			this.Controls.Add(this.btnPergunta);
			this.Controls.Add(this.btnExclamação);
			this.Controls.Add(this.brnAlerta);
			this.Controls.Add(this.btnErro);
			this.Controls.Add(this.btnLimpaText);
			this.Controls.Add(this.btnCliqueAqui);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnCalcularMedia);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button btnCalcularMedia;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnCliqueAqui;
		private System.Windows.Forms.Button btnLimpaText;
		private System.Windows.Forms.Button btnErro;
		private System.Windows.Forms.Button brnAlerta;
		private System.Windows.Forms.Button btnExclamação;
		private System.Windows.Forms.Button btnPergunta;
		private System.Windows.Forms.Button btnInfo;
	}
}

