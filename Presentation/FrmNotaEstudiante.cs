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
    public partial class FrmNotaEstudiante : Form
    {
        public EstudianteRepository estudianteModel;
        public NotaRepository notasModel;
        public int Cont {get; set;}
        public FrmNotaEstudiante()
        {
            estudianteModel = AccesData.estudiante == null ? new EstudianteRepository() : AccesData.estudiante;
            notasModel = AccesData.notas == null ? new NotaRepository() : AccesData.notas;
            InitializeComponent();
        }

        private void CbContabilidadCostos_CheckedChanged(object sender, EventArgs e)
        {
            if(cbContabilidadCostos.Checked == true)
            {
                nudSistematicoCC.Visible = true;
                nudIParcialCC.Visible = true;
                nudIIParcialCC.Visible = true;
                nudTareaCursoCC.Visible = true;
            }
            else
            {
                nudSistematicoCC.Visible = false;
                nudIParcialCC.Visible = false;
                nudIIParcialCC.Visible = false;
                nudTareaCursoCC.Visible = false;
            }

        }

        private void FrmNotaEstudiante_Load(object sender, EventArgs e)
        {
            CLS();
        }

        private void CbSociologia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSociologia.Checked == true)
            {
                nudSistematicoSociologia.Visible = true;
                nudIParcialSociologia.Visible = true;
                nudIIParcialSociologia.Visible = true;
                nudTareaCursoSociologia.Visible = true;
            }
            else
            {
                nudSistematicoSociologia.Visible = false;
                nudIParcialSociologia.Visible = false;
                nudIIParcialSociologia.Visible = false;
                nudTareaCursoSociologia.Visible = false;
            }
        }

        private void CbMatematicaII_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMatematicaII.Checked == true)
            {
                nudSistematicoMatematicaII.Visible = true;
                nudIParcialMatematicaII.Visible = true;
                nudIIParcialMatematicaII.Visible = true;
                nudTareaCursoMatematicaII.Visible = true;
            }
            else
            {
                nudSistematicoMatematicaII.Visible = false;
                nudIParcialMatematicaII.Visible = false;
                nudIIParcialMatematicaII.Visible = false;
                nudTareaCursoMatematicaII.Visible = false;
            }
        }

        private void CbInglesII_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInglesII.Checked == true)
            {
                nudSistematicoInglesII.Visible = true;
                nudIParcialInglesII.Visible = true;
                nudIIParcialInglesII.Visible = true;
                nudTareaCursoInglesII.Visible = true;
            }
            else
            {
                nudSistematicoInglesII.Visible = false;
                nudIParcialInglesII.Visible = false;
                nudIIParcialInglesII.Visible = false;
                nudTareaCursoInglesII.Visible = false;
            }
        }

        private void CbAlgebraLineal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAlgebraLineal.Checked == true)
            {
                nudSistematicoAlgebraLineal.Visible = true;
                nudIParcialAlgebraLineal.Visible = true;
                nudIIParcialAlgebraLineal.Visible = true;
                nudTareaCursoAlgebraLineal.Visible = true;
            }
            else
            {
                nudSistematicoAlgebraLineal.Visible = false;
                nudIParcialAlgebraLineal.Visible = false;
                nudIIParcialAlgebraLineal.Visible = false;
                nudTareaCursoAlgebraLineal.Visible = false;
            }
        }

        private void CbProgramacionI_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProgramacionI.Checked == true)
            {
                nudSistematicoProgramacionI.Visible = true;
                nudIParcialProgramacionI.Visible = true;
                nudIIParcialProgramacionI.Visible = true;
                nudTareaCursoProgramacionI.Visible = true;
            }
            else
            {
                nudSistematicoProgramacionI.Visible = false;
                nudIParcialProgramacionI.Visible = false;
                nudIIParcialProgramacionI.Visible = false;
                nudTareaCursoProgramacionI.Visible = false;
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            AccesData.estudiante = estudianteModel;
            AccesData.notas = notasModel;

            FrmEstudiante frmEst = new FrmEstudiante();
            ////frmEst.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Estudiante est = new Estudiante()
            {
                Id = ++Cont,
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Carnet = txtCarnet.Text,
                Departamento = txtDepartamento.Text,
                Municipio = txtMunicipio.Text
            };

            estudianteModel.Create(est);



            if (cbAlgebraLineal.Checked == true)
            {
                Nota n = new Nota()
                {
                    Asignatura = Domain.Enums.Asignatura.AlgebraLineal,
                    Estudiante = est,
                    Sistematico = (int)nudSistematicoAlgebraLineal.Value,
                    IParcial = (int)nudIParcialAlgebraLineal.Value,
                    IIParcial = (int)nudIIParcialAlgebraLineal.Value,
                    TareaCurso = (int)nudTareaCursoAlgebraLineal.Value
                };

                notasModel.Create(n);
            }

            if (cbContabilidadCostos.Checked == true)
            {
                Nota n = new Nota()
                {
                    Asignatura = Domain.Enums.Asignatura.ContabilidadCostos,
                    Estudiante = est,
                    Sistematico = (int)nudSistematicoCC.Value,
                    IParcial = (int)nudIParcialCC.Value,
                    IIParcial = (int)nudIIParcialCC.Value,
                    TareaCurso = (int)nudTareaCursoCC.Value
                };

                notasModel.Create(n);
            }

            if (cbSociologia.Checked == true)
            {
                Nota n = new Nota()
                {
                    Asignatura = Domain.Enums.Asignatura.Sociologia,
                    Estudiante = est,
                    Sistematico = (int)nudSistematicoSociologia.Value,
                    IParcial = (int)nudIParcialSociologia.Value,
                    IIParcial = (int)nudIIParcialSociologia.Value,
                    TareaCurso = (int)nudTareaCursoSociologia.Value
                };

                notasModel.Create(n);
            }

            if (cbInglesII.Checked == true)
            {
                Nota n = new Nota()
                {
                    Asignatura = Domain.Enums.Asignatura.InglesII,
                    Estudiante = est,
                    Sistematico = (int)nudSistematicoInglesII.Value,
                    IParcial = (int)nudIParcialInglesII.Value,
                    IIParcial = (int)nudIIParcialInglesII.Value,
                    TareaCurso = (int)nudTareaCursoInglesII.Value
                };

                notasModel.Create(n);
            }

            if (cbMatematicaII.Checked == true)
            {
                Nota n = new Nota()
                {
                    Asignatura = Domain.Enums.Asignatura.MatematicaII,
                    Estudiante = est,
                    Sistematico = (int)nudSistematicoMatematicaII.Value,
                    IParcial = (int)nudIParcialMatematicaII.Value,
                    IIParcial = (int)nudIIParcialMatematicaII.Value,
                    TareaCurso = (int)nudTareaCursoMatematicaII.Value
                };

                notasModel.Create(n);
            }

            if (cbProgramacionI.Checked == true)
            {
                Nota n = new Nota()
                {
                    Asignatura = Domain.Enums.Asignatura.ProgramacionI,
                    Estudiante = est,
                    Sistematico = (int)nudSistematicoProgramacionI.Value,
                    IParcial = (int)nudIParcialProgramacionI.Value,
                    IIParcial = (int)nudIIParcialProgramacionI.Value,
                    TareaCurso = (int)nudTareaCursoProgramacionI.Value
                };

                notasModel.Create(n);
            }

            MessageBox.Show("El estudiando ha sido agregado con exito.", "Informacion",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            CLS();
        }

        public void CLS() 
        {
            txtId.Text = string.Empty;
            txtCarnet.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtMunicipio.Text = string.Empty;
            txtDepartamento.Text = string.Empty;

            nudIIParcialAlgebraLineal.Value = 0;
            nudIIParcialCC.Value = 0;
            nudIIParcialInglesII.Value = 0;
            nudIIParcialMatematicaII.Value = 0;
            nudIIParcialProgramacionI.Value = 0;
            nudIIParcialSociologia.Value = 0;
            nudIParcialAlgebraLineal.Value = 0;
            nudIParcialCC.Value = 0;
            nudIParcialInglesII.Value = 0;
            nudIParcialMatematicaII.Value = 0;
            nudIParcialProgramacionI.Value = 0;
            nudIParcialSociologia.Value = 0;
            nudSistematicoAlgebraLineal.Value = 0;
            nudSistematicoCC.Value = 0;
            nudSistematicoInglesII.Value = 0;
            nudSistematicoMatematicaII.Value = 0;
            nudSistematicoProgramacionI.Value = 0;
            nudSistematicoSociologia.Value = 0;
            nudTareaCursoAlgebraLineal.Value = 0;
            nudTareaCursoCC.Value = 0;
            nudTareaCursoInglesII.Value = 0;
            nudTareaCursoMatematicaII.Value = 0;
            nudTareaCursoProgramacionI.Value = 0;
            nudTareaCursoSociologia.Value = 0;

            nudSistematicoCC.Visible = false;
            nudIParcialCC.Visible = false;
            nudIIParcialCC.Visible = false;
            nudTareaCursoCC.Visible = false;
            nudSistematicoSociologia.Visible = false;
            nudIParcialSociologia.Visible = false;
            nudIIParcialSociologia.Visible = false;
            nudTareaCursoSociologia.Visible = false;
            nudSistematicoMatematicaII.Visible = false;
            nudIParcialMatematicaII.Visible = false;
            nudIIParcialMatematicaII.Visible = false;
            nudTareaCursoMatematicaII.Visible = false;
            nudSistematicoInglesII.Visible = false;
            nudIParcialInglesII.Visible = false;
            nudIIParcialInglesII.Visible = false;
            nudTareaCursoInglesII.Visible = false;
            nudSistematicoAlgebraLineal.Visible = false;
            nudIParcialAlgebraLineal.Visible = false;
            nudIIParcialAlgebraLineal.Visible = false;
            nudTareaCursoAlgebraLineal.Visible = false;
            nudSistematicoProgramacionI.Visible = false;
            nudIParcialProgramacionI.Visible = false;
            nudIIParcialProgramacionI.Visible = false;
            nudTareaCursoProgramacionI.Visible = false;
        }
    }
}
