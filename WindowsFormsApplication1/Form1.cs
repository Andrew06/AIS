using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kompsericeDataSet.Расход' table. You can move, or remove it, as needed.
            this.расходTableAdapter.Fill(this.kompsericeDataSet.Расход);
            // TODO: This line of code loads data into the 'kompsericeDataSet.Работа' table. You can move, or remove it, as needed.
            this.работаTableAdapter.Fill(this.kompsericeDataSet.Работа);
            // TODO: This line of code loads data into the 'kompsericeDataSet.Заказ' table. You can move, or remove it, as needed.
            this.заказTableAdapter.Fill(this.kompsericeDataSet.Заказ);

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = System.DateTime.Now.ToLongTimeString() + ' ' + DateTime.Now.ToShortDateString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cnmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void расходныеМатериалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Frm2 = new Form2();
            Frm2.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 About = new AboutBox1();
            About.ShowDialog(); 
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form5 Frm5 = new Form5();
            Frm5.menuStrip1.Visible = true;
            Frm5.ShowDialog();
        }
        private void видТехникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Frm3 = new Form3();
            Frm3.ShowDialog();
        }

        private void маркиТехникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Frm4 = new Form4();
            Frm4.ShowDialog();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 Frm5 = new Form5();
            Frm5.ShowDialog();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 Frm6 = new Form6();
            Frm6.ShowDialog();
        }

        private void ремонтыеРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 Frm7 = new Form7();
            Frm7.ShowDialog();
        }

 
     }
}
