using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace пирамида // Ханойские башни
{
    public partial class Form1 : Form
    {
        Graphics  [] gr;
        Piramida [] D;
        List<Panel> Pan;
        Wheel[] W;
        int n = 0;
        int time = 1000;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gr = new Graphics[3];
            gr[0] = panel2.CreateGraphics();
            gr[1] = panel3.CreateGraphics();
            gr[2] = panel4.CreateGraphics();
        Pan = new List<Panel>();
        Pan.Add(panel2);
            
        Pan.Add(panel3);
        Pan.Add(panel4);
           
            for (int i = 3; i < 10; i++)
            {
                comboBox1.Items.Add(i);

            }
            for (int i = 1; i < 4; i++)
            {
                comboBox2.Items.Add(i);
                comboBox3.Items.Add(i);

            }
            D = new Piramida[3];
            for (int i = 0; i < 3; i++)
            {
                D[i] = new Piramida(i);
            }

          
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            Hanoy(n, Convert.ToInt32(comboBox2.Text)-1, Convert.ToInt32(comboBox3.Text)-1);
            comboBox2.Text = comboBox3.Text;
            comboBox3.Text = "";
           
        }
        public void Hanoy(int n, int from, int to)
        {
            if (n==0)
                return;
            Hanoy(n - 1, from, 3 - from - to);
            Peremeshenie(D[from], D[to]);
            
            // Переложить n-ое кольцо переложить  на to
            Hanoy(n - 1, 3 - from - to, to);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void Peremeshenie(Piramida p1, Piramida p2)
        {
            p2.AddWheel(p1.Wheelss());
            p1.DeleteWheel();
            
            for (int i = 0; i < D.Length; i++)
            {gr[i].FillRectangle(new SolidBrush(Color.White), 0, 0, Pan[i].Width, Pan[i].Height);
            D[i].DrawPiramida(gr[i], Pan[i].Width, Pan[i].Height, n);
            }
            Thread.Sleep(time);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Hanoy(3, 0, 2);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            n =Convert.ToInt32( comboBox1.Text);
            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            n = Convert.ToInt32(comboBox1.Text);
            
            for (int i = 0; i <3; i++)
            {

                D[i].DeleteAllWheels();
                gr[i].FillRectangle(new SolidBrush(Color.White), 0, 0, Pan[i].Width, Pan[i].Height);
                D[i].DrawPiramida(gr[i], Pan[i].Width, Pan[i].Height, n);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32( comboBox2.Text)-1;
            for (int i = 0; i < 3; i++)
            {
                gr[i].FillRectangle(new SolidBrush(Color.White), 0, 0, Pan[i].Width, Pan[i].Height);

            }
            for (int i = 0; i < D.Length;i++ )
            {

                D[i].DeleteAllWheels();
            }
                W = new Wheel[n];
            
           
            int h = n - 1;
            for (int i = 0; i < W.Count(); i++)
            {
                W[i] = new Wheel(i + 1);

            }
            for (int i = 0; i < W.Count(); i++)
            {
                D[a].AddWheel(W[h]);
                h--;

            } 
            for (int i = 0; i < 3; i++)
            {
               D[i].DrawPiramida(gr[i], Pan[i].Width, Pan[i].Height, n); 
            }
            
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            time = 1000 - (trackBar1.Value * 100);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
