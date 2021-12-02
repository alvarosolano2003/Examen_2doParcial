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
        public FrmNotaEstudiante()
        {
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
    }
}
