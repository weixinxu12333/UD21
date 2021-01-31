using System;
using System.Windows.Forms;

namespace Geometria.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = 
                @"
                Area cuadrado: 
                Area Circulo: 
                Area triangulo:
                Area rectangulo:
                Area pentagono
                Area rombo:
                Area romboide:
                Area trapecio:
                Figura: 
                Id:
                Nombre:
                Area:";
        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            // probar try catch
            if (textBox1.Text==null || textBox2.Text==null || textBox3.Text == null || textBox4.Text == null 
                || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Indroduce valor donde pone *");
            }
            else
            {
                int n1 = Convert.ToInt32(textBox1.Text);
                int n2 = Convert.ToInt32(textBox2.Text);
                int n3 = Convert.ToInt32(textBox3.Text);
                int n4 = Convert.ToInt32(textBox4.Text);

                Geometria g = new Geometria();

                if (!string.IsNullOrEmpty(textBox5.Text))
                    g.setId(Convert.ToInt32(textBox5.Text));
                if (!string.IsNullOrEmpty(textBox6.Text))
                    g.setNom(textBox6.Text);
                if (!string.IsNullOrEmpty(textBox7.Text))
                    g.setArea(Convert.ToDouble(textBox7.Text));

                label2.Text = "\n" +
                                g.areacuadrado(n1).ToString() + "\n" +
                                g.areaCirculo(n1).ToString() + "\n" +
                                g.areatriangulo(n1, n2).ToString() + "\n" +
                                g.arearectangulo(n1, n2).ToString() + "\n" +
                                g.areapentagono(n1, n2).ToString() + "\n" +
                                g.arearombo(n1, n2).ToString() + "\n" +
                                g.arearomboide(n1, n2).ToString() + "\n" +
                                g.areatrapecio(n1, n2, n3).ToString() + "\n" +
                                g.figura(n4).ToString() + "\n" +
                                g.getId().ToString() + "\n" +
                                g.getNom().ToString() + "\n" +
                                g.getArea().ToString();
            }
        }
    }
}
