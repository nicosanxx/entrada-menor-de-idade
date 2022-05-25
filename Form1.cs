using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entrada_menor_de_idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (txt_idade.Text != "")
            {



                int idade = Convert.ToInt32(txt_idade.Text);

                if (idade >= 18)
                {

                    lb_result.Text = "PERMISSÃO CONCEDIDA";
                    lb_result.ForeColor = Color.Green;
                    lb_result.Font = new Font("Arial", 13, FontStyle.Bold);


                }
                else
                {

                    lb_result.Text = "SEM PERMISSÃO";
                    lb_result.ForeColor = Color.Red;
                    lb_result.Font = new Font("Arial", 15, FontStyle.Bold);



                }






            }
            else
            {

                MessageBox.Show("Favor preencher o campo corretamente", "ATENÇÃO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
        }
    }
}