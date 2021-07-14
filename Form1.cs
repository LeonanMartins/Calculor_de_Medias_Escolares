using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            TxtNota1.Text = "";
            TxtNota2.Text = "";
            TxtNota3.Text = "";
            TxtNota4.Text = "";
            txtmedia.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            string nome;
            double n1, n2, n3, n4, media;
            nome = (txtNome.Text);
            n1 = Convert.ToDouble(TxtNota1.Text);
            n2 = Convert.ToDouble(TxtNota2.Text);
            n3 = Convert.ToDouble(TxtNota3.Text);
            n4 = Convert.ToDouble(TxtNota4.Text);
            media = (n1 + n2 + n3 + n4) / 4;
            Convert.ToString(media);
             if (media < 5)
                txtmedia.Text = $"O Aluno {nome} teve a média {media}. Aluno esta REPROVADO!";
             else if (media >= 7)
                txtmedia.Text = $"O Aluno {nome} teve a média {media} Aluno esta APROVADO!";
             else
                txtmedia.Text = $"O Aluno {nome} teve a média {media} Aluno em RECUPERAÇÃO!";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
