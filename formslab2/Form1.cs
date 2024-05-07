using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;


namespace formslab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = formslab2.Resource1.Logo1;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = formslab2.Resource1.Logo2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = formslab2.Resource1.Logo3;
        }

        private void AplicarIdioma()
        {
            button1.Text = Recursos.StringResources.Boton1;
            button2.Text = Recursos.StringResources.Boton2;
            button3.Text = Recursos.StringResources.Boton3;
            this.Text = Recursos.StringResources.TituloVentana;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 1;
            AplicarIdioma();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo((string)listBox1.SelectedItem);
            AplicarIdioma();
        }
    }
}
