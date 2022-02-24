using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Rectificadora.Views.Principal
{
    public partial class AddPrincipal : Form
    {
        //Se instancia el controlador para poder ser usado
        Controller.MainController mainController = new Controller.MainController();
        public int? id;
        public AddPrincipal(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                LlenarVistaEdit();
        }

        private void LlenarVistaEdit() 
        {
            var model = mainController.GetEdit(this.id);
            TXT_NOMBRE.Text = model.nombre;
            TXT_EDAD.Text = model.edad.ToString();

        }

        //Ir al controlador para registrar
        private void button1_Click(object sender, EventArgs e)
        {
            if(id == null)
                 mainController.AddRegistro(TXT_NOMBRE.Text, Convert.ToInt32(TXT_EDAD.Text));
            else
                mainController.Edit(Convert.ToInt32(id), TXT_NOMBRE.Text, Convert.ToInt32(TXT_EDAD.Text));

            this.Close();
        }

        private void AddPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
