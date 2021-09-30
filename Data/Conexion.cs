using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Data;
using LinqToDB;

namespace Data
{
    public class Conexion : DataConnection
    {
        public Conexion() : base("connString") 
        {
            
        }
        public ITable<Estudiante> tablaEstudiante { get => GetTable<Estudiante>(); }
    }
}
