using Domain.Entities;
using Domain.Interfaces;
using Infraestructure.Repositories;
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
        public EstudianteRepository estudianteModel;
        public NotaRepository notasModel;
        public FrmEstudiante()
        {
            estudianteModel = AccesData.estudiante == null ? new EstudianteRepository() : AccesData.estudiante;
            notasModel = AccesData.notas == null ? new NotaRepository() : AccesData.notas;
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
            dgvEstudiantes.DataSource = AccesData.estudiante.GetAll();

        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            List<decimal> promedios = new List<decimal>();

            foreach (Estudiante est in AccesData.estudiante.GetAll())
            {
                promedios.Add(notasModel.CalculatePromedio(notasModel.ClasificateNota(est)));
            }

            List<Estudiante> mejoresProm = notasModel.MejoresPromedio(AccesData.estudiante.GetAll(), promedios.ToArray());

            dgvEstudiantes.DataSource = mejoresProm;

        }
    }
}
