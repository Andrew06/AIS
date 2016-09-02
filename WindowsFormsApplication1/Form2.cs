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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kompserviceDataSet.Материал' table. You can move, or remove it, as needed.
            this.материалTableAdapter.Fill(this.kompserviceDataSet.Материал);
            // TODO: This line of code loads data into the 'kompserviceDataSet.Категории' table. You can move, or remove it, as needed.
            this.категорииTableAdapter.Fill(this.kompserviceDataSet.Категории);
        } 

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            IUIService UIservice = (IUIService)this.GetService(
                       typeof(System.Windows.Forms.Design.IUIService));
            if (menuStrip1.Visible == true) 
                UIservice.ShowMessage("Выберите расходные материалы для ремонта и нажмите на кнопку 'Добавить расход' !", "Test caption", System.Windows.Forms.MessageBoxButtons.OK);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuStrip1.Visible = false;
        }
    }
}
