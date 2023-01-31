using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_chalenge    //ARSHIA VAHED
{
    public partial class Form1 : Form
    {
        int[,] xo = new int[3, 3];
        public Form1()
        {
            InitializeComponent();
        }
        private void lblclick(object sender, MouseEventArgs e)
        {
            int i, j;
            i = int.Parse(((Label)sender).Name[3].ToString());
            j = int.Parse(((Label)sender).Name[4].ToString());
            if (e.Button == MouseButtons.Left)
            {
                ((Label)sender).Text = "X";
                xo[i, j] = 1;
                check(i, j, 1);
            }
            else
            {
                ((Label)sender).Text = "O";
                xo[i, j] = 2;
                check(i, j, 2);
            }
        }
        public void check(int i , int j , int a)
        {
            rowcheck(i, j, a);
            colcheck(i, j, a);
            xcheck(a);
            ycheck(a);
        }
        public void rowcheck(int i,int j,int a)
        {
            if(xo[i,1]==a && xo[i,2]==a && xo[i, 0] == a)
            {
                MessageBox.Show("player " + a.ToString() + " win.");
            }
        }
        public void colcheck(int i, int j, int a)
        {
            if (xo[0, j] == a && xo[1, j] == a && xo[2, j] == a)
            {
                MessageBox.Show("player " + a.ToString() + " win.");
            }
        }
        public void xcheck(int a)
        {
            if (xo[0, 0] == a && xo[1, 1] == a && xo[2, 2] == a)
            {
                MessageBox.Show("player " + a.ToString() + " win.");
            }
        }
        public void ycheck(int a)
        {
            if (xo[0, 2] == a && xo[1, 1] == a && xo[2, 0] == a)
            {
                MessageBox.Show("player " + a.ToString() + " win.");
            }
        }
    }
}
