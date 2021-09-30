using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Libreria
{
    public class Paginador<T>
    {
        private List<T> dataList;
        private Label label;
        private static int maxReg, _regPorPagina, pageCount, numPagina = 1;

        public Paginador(List<T> dataList, Label label, int regPorPagina)
        {
            this.dataList = dataList;
            this.label = label;
            _regPorPagina = regPorPagina;
            cargarDatos();
        }

        private void cargarDatos() 
        {
            numPagina = 1;
            maxReg = dataList.Count;
            pageCount = (maxReg / _regPorPagina);

            if (maxReg % _regPorPagina > 0)
            {
                pageCount++;
            }
            label.Text = $"Página 1/{pageCount}";
        }

        public int primeraPagina()
        {
            numPagina = 1;
            label.Text = $"Página {numPagina}/{pageCount}";
            return numPagina;
        }
        public int anteriorPagina()
        {
            if (numPagina > 1)
            {
                --numPagina;
                label.Text = $"Página {numPagina}/{pageCount}";
            }
            return numPagina;
        }
        public int siguientePagina()
        {
            if (numPagina == pageCount) numPagina = 1;
            if (numPagina < pageCount)
            {
                ++numPagina;
                label.Text = $"Página {numPagina}/{pageCount}";
            }
            return numPagina;
        }
        public int ultimaPagina()
        {
            numPagina = pageCount;
            label.Text = $"Página {numPagina}/{pageCount}";
            return numPagina;
        }
        
    }
}
