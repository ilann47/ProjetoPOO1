using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulaPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int[] Numeros = { 1, 2, 3 };
                MessageBox.Show(Convert.ToString(Numeros[10]));

                MessageBox.Show("Segunda Mensagem");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Resultado: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int[] Numeros = { 1, 2, 3 };
                MessageBox.Show(Convert.ToString(Numeros[10]));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Resultado: " + (Convert.ToString(ex.HResult)) + " " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Segunda mensagem blabla:");
            }

        }
    }
}
