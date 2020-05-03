using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cu_baza_de_date_Access
{
    public partial class Form1 : Form
    {
        int scor, nrIntrebari, crt, cate;
        DataTable d;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.intrebariTableAdapter1.Fill(this.quizDataSet1.intrebari);
            scor = 0;
            d = quizDataSet1.intrebari;
            cate = d.Rows.Count;
            crt = 1;
            pune(crt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crt--;
            if (crt < 0) crt = cate - 1;
            pune(crt);
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crt++;
            if (crt == cate) crt = 0;
            pune(crt);
        }

        public Form1()
        {
            InitializeComponent();
        }
        
        private void pune(int n)
        {
            if(n>=0 && n<cate)
            {
                intrebare.Text = d.Rows[n]["intrebare"].ToString();
                r1.Text = d.Rows[n]["v1"].ToString();
                r2.Text = d.Rows[n]["v2"].ToString();
                r3.Text = d.Rows[n]["v3"].ToString();
                r4.Text = d.Rows[n]["v4"].ToString();
                MemoryStream ms = new MemoryStream((byte[])d.Rows[n]["Poza"]);
                poza.Image = Image.FromStream(ms);



            }
        }
        private void intrebare_Click(object sender, EventArgs e)
        {

        }
    }
}
