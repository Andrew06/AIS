using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kompsericeDataSet.Производитель' table. You can move, or remove it, as needed.
            this.производительTableAdapter.Fill(this.kompsericeDataSet.Производитель);
            // TODO: This line of code loads data into the 'kompsericeDataSet.Материал' table. You can move, or remove it, as needed.
            this.материалTableAdapter.Fill(this.kompsericeDataSet.Материал);
            // TODO: This line of code loads data into the 'kompsericeDataSet.Мастер' table. You can move, or remove it, as needed.
            this.мастерTableAdapter.Fill(this.kompsericeDataSet.Мастер);
            // TODO: This line of code loads data into the 'kompsericeDataSet.Клиент' table. You can move, or remove it, as needed.
            this.клиентTableAdapter.Fill(this.kompsericeDataSet.Клиент);
            // TODO: This line of code loads data into the 'kompsericeDataSet.Категории' table. You can move, or remove it, as needed.
            this.категорииTableAdapter.Fill(this.kompsericeDataSet.Категории);
            // TODO: This line of code loads data into the 'kompsericeDataSet.Вид' table. You can move, or remove it, as needed.
            this.видTableAdapter.Fill(this.kompsericeDataSet.Вид);
            // TODO: This line of code loads data into the 'kompsericeDataSet.Ремонт' table. You can move, or remove it, as needed.
            this.ремонтTableAdapter.Fill(this.kompsericeDataSet.Ремонт);
            // TODO: This line of code loads data into the 'kompsericeDataSet.Расход' table. You can move, or remove it, as needed.
            this.расходTableAdapter.Fill(this.kompsericeDataSet.Расход);
            // TODO: This line of code loads data into the 'kompsericeDataSet.Работа' table. You can move, or remove it, as needed.
            this.работаTableAdapter.Fill(this.kompsericeDataSet.Работа);
            // TODO: This line of code loads data into the 'kompsericeDataSet.Заказ' table. You can move, or remove it, as needed.
            this.заказTableAdapter.Fill(this.kompsericeDataSet.Заказ);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = System.DateTime.Now.ToLongTimeString() + ' ' + DateTime.Now.ToShortDateString();

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cnmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripMenuItem4_Click(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                string St = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                object missing = Type.Missing;
                object fileName = Application.StartupPath + "\\Doc1.doc";
                object fileSave = Application.StartupPath + "\\Doc\\Справка №"+St;
                object fileFormat = Word.WdSaveFormat.wdFormatDocumentDefault;
                Word.Application WordApplication = new Word.Application();
                Word.Document worddocument = new Word.Document();
                this.WindowState = FormWindowState.Minimized;
                WordApplication.Visible = true;
                worddocument = WordApplication.Documents.Open(fileName);
                Word.Range wordcellrange = worddocument.Tables[1].Cell(14, 2).Range;
                wordcellrange.Text = St;

                worddocument.SaveAs2(fileSave, fileFormat);
//              WordApplication.Quit(ref missing, ref missing, ref missing);
//              WordApplication = null;
                this.WindowState = FormWindowState.Normal;
            }
            catch (Exception ex)
            {
              //  MessageBox.Show("Шаблон документа не найден!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                string St = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                object missing = Type.Missing;
                object fileName = Application.StartupPath + "\\Doc2.doc";
                object fileSave = Application.StartupPath + "\\Doc\\Наряд №" + St;
                object fileFormat = Word.WdSaveFormat.wdFormatDocumentDefault;
                Word.Application WordApplication = new Word.Application();
                Word.Document worddocument = new Word.Document();
                this.WindowState = FormWindowState.Minimized;
                WordApplication.Visible = true;
                worddocument = WordApplication.Documents.Open(fileName);
                Word.Range wordcellrange = worddocument.Tables[1].Cell(12, 2).Range;
                wordcellrange.Text = St;

                worddocument.SaveAs2(fileSave, fileFormat);
                //  WordApplication.Quit(ref missing, ref missing, ref missing);
                //  WordApplication = null;
                this.WindowState = FormWindowState.Normal;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Шаблон документа не найден!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.Message);
            }
        }
     }
}
