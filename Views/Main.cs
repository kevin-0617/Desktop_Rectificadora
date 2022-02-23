using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Rectificadora
{
    public partial class Main : Form
    {
        Controller.MainController mainController = new Controller.MainController();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mainController.GetList();
        }
    }
}
