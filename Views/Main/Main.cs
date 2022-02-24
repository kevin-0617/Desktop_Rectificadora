using Desktop_Rectificadora.Views.Principal;
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
        //Metodo Inicializador
        private void Main_Load(object sender, EventArgs e)
        {
            //Se refresca la lista 
            UpdateTable();
        }

        //Boton Crear
        private void button1_Click(object sender, EventArgs e)
        {
            AddPrincipal OpenWindowCreate = new AddPrincipal();

            OpenWindowCreate.ShowDialog();

            UpdateTable();
        }

        //Boton Editar
        private void button2_Click(object sender, EventArgs e)
        {
            int id = GetId();
            if (id != null) 
            {
                AddPrincipal Ventana = new AddPrincipal(id);

                //Se muestra la ventana 
                Ventana.ShowDialog();
                UpdateTable();
            }   
        }

        //Boton Eliminar 
        private void button3_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
                mainController.Delete(id);
            UpdateTable();
        }
        //Obtiene el id seleccionado
        private int GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return 0;
            }

        }
        //Refresca la tabla 
        private void UpdateTable()
        {
            dataGridView1.DataSource = mainController.GetList();
        }

        //private void Mostrar()
        //{
        //    int? id = GetId();
        //    //Se instancia la ventanda 
        //    AddPrincipal n = new AddPrincipal(id);

        //    //Se muestra la ventana 
        //    n.ShowDialog();
        //}
    }
}
