using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class NotaRepository : BaseRepository<Nota>, INotas
    {
        public decimal CalculatePromedio(List<Nota> nota)
        {
            decimal promedio = 0;

            foreach (Nota e in nota)
            {
                promedio += e.NotaFinal;
            }

            return Math.Round(promedio);
        }
        public List<Nota> ClasificateNota(Estudiante est)
        {
            return data.Where(x => x.Estudiante == est).ToList();
        }
        public List<Estudiante> MejoresPromedio(List<Estudiante> est, decimal[] promedios)
        {
            Array.Sort(promedios);
            List<Nota> estNotas = new List<Nota>();
            List<Estudiante> bestAverages = new List<Estudiante>();
            decimal promAux = 0;

            for (int i = 0; i > est.Count; i++)
            {
                estNotas = ClasificateNota(est[i]);
                promAux = CalculatePromedio(estNotas);

                if (promAux == promedios[1])
                {
                    bestAverages.Add(est[i]);
                }
                else if (promAux == promedios[2])
                {
                    bestAverages.Add(est[i]);
                }
                else if (promAux == promedios[2])
                {
                    bestAverages.Add(est[i]);
                }
            }

            return bestAverages;
        }
    }
}
