using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* Var builder = new ContainerBuilder();

            builder.RegisterType<ObjetoRepository>().As<IObjetoRepository>();
            builder.RegisterType<ObjetoService>().As<IObjetoService>();

            Var container = new builder.build();

            App.run(new Formulario(container.Resolve(IObjetoService))); */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmEstudiante());
        }
    }
}
