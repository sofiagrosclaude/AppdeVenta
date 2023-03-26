using Mística_Cosmética_Natural;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfilPersona
{
    public partial class MisticaPrincipal : Form
    {
        public MisticaPrincipal()
        {
            InitializeComponent();
        }

        
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Pedidos ventana = new Pedidos();
            //ventana.MdiParent = this; (para que quede alojada la ventana dentro de la ventana madre)
            ventana.Show(); 
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Stock ventana = new Stock();
           // ventana.MdiParent = this;
            ventana.Show();  
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Insumos ventana = new Insumos();
           // ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
