using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxExceptions
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				double val1 = Convert.ToDouble(textBox1.Text);
				double val2 = Convert.ToDouble(textBox2.Text);
				double val3 = Convert.ToDouble(textBox3.Text);
				double val4 = Convert.ToDouble(textBox4.Text);

				double media = (val1 + val2 + val3 + val4) / 4;

				lblResultado.Text = "Resultado: " + media.ToString();

			}

			catch (FormatException)
			{
				DialogResult result = MessageBox.Show("Você algo que não é um numero!, gostaria de continuar","Erro de conversão",MessageBoxButtons.YesNo, MessageBoxIcon.Error);
				if (result == DialogResult.No)
				{
					Application.Exit(); 
				}
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void lblResultado_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnCliqueAqui_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Esta é uma mensagem informativa","OLHA A MENSAGEM",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void button1_Click_1(object sender, EventArgs e)
		{

			DialogResult result = MessageBox.Show("Deseja realmente apagar os campos","Confirmação", 
												MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);

			if (result == DialogResult.Yes)
			{
				textBox1.Text = "";
				textBox2.Text = "";
				textBox3.Text = "";
				textBox4.Text = "";
			}
		}

		private void btnErro_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Você errou","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}

		private void brnAlerta_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Você foi alertado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void btnExclamação_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Você ?", "?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void btnPergunta_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Você foi perguntado", "Pergunta", MessageBoxButtons.OK, MessageBoxIcon.Question);
		}

		private void btnInfo_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Você foi informado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
