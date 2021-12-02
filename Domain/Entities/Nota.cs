using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Nota
    {
        public Asignatura Asignatura { get; set; }
        public Estudiante Estudiante { get; set; }
        public int Sistematico { get; set; }
        public int IParcial { get; set; }
        public int IIParcial { get; set; }
        public int TareaCurso { get; set; }
        public int NotaFinal { get; set; }
    }
}
