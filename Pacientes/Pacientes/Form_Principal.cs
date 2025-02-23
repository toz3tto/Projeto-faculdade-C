using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacientes
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }
     
        private void btnCriarTreinos_Click(object sender, EventArgs e)
        {
            FormExercicios formExercicios = new FormExercicios();
            formExercicios.ShowDialog();
        }
    }
}
