using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface INotas : IModel<Nota>
    {
        List<Nota> ClasificateNota(Estudiante est);
        decimal CalculatePromedio(List<Nota> nota);
        List<Estudiante> MejoresPromedio(List<Estudiante> est, decimal[] promedios);
    }
}
