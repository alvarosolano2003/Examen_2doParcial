using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmEstudiante : Form
    {
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void BtnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            FrmNotaEstudiante sc = new FrmNotaEstudiante();
            sc.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnMostrarEstudiante_Click(object sender, EventArgs e)
        {
            //dgvEstudiantes.DataSource = 
        }
    }
}
