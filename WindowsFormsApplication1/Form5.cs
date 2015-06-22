using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kompsericeDataSet.Вид' table. You can move, or remove it, as needed.
            this.видTableAdapter.Fill(this.kompsericeDataSet.Вид);
            // TODO: This line of code loads data into the 'kompsericeDataSet.Производитель' table. You can move, or remove it, as needed.
            this.производительTableAdapter.Fill(this.kompsericeDataSet.Производитель);
            // TODO: This line of code loads data into the 'kompsericeDataSet.Техника' table. You can move, or remove it, as needed.
            this.техникаTableAdapter.Fill(this.kompsericeDataSet.Техника);
            // TODO: This line of code loads data into the 'kompsericeDataSet.Клиент' table. You can move, or remove it, as needed.
            this.клиентTableAdapter.Fill(this.kompsericeDataSet.Клиент);

        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuStrip1.Visible = false;
        }

        private void клиентBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Activated(object sender, EventArgs e)
        {
            IUIService UIservice = (IUIService)this.GetService(
                typeof(System.Windows.Forms.Design.IUIService));
            if (UIservice != null && menuStrip1.Visible == true)
                UIservice.ShowMessage("Выберите технику клиента для ремонта и нажмите на кнопку 'Добавить заказ' !", "Test caption", System.Windows.Forms.MessageBoxButtons.OK);
        }

        private void выбратьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Form6 Frm6 = new Form6();
            Frm6.menuStrip1.Visible = true;
            Frm6.ShowDialog();      
            
         }

           
    }
}
