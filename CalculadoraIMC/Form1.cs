using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculoIMC_Click(object sender, EventArgs e)
        {

            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);

            Paciente p1 = new Paciente(txtNome.Text, peso, altura);

            txtNome.Text = p1.nome;
            txtPeso.Text = Convert.ToString(p1.peso);
            txtAltura.Text = Convert.ToString(p1.altura);

            txtIMC.Text = Convert.ToString(p1.CalcularIMC(altura, peso)); 
            lblIMC.Visible = true;


           txtClassificacao.Text = "A classificação do IMC do paciente " + p1.nome + " é: " + Convert.ToString(p1.ClassificacaoIMC(altura, peso));
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIMC_Click(object sender, EventArgs e)
        {

        }

        private void txtIMC_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblClassificacao_Click(object sender, EventArgs e)
        {

        }

        private void txtClassificacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
