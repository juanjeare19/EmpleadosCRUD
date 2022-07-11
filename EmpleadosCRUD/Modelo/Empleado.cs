using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosCRUD.Modelo
{
    class Empleado
    {
        private string id;
        private string nombres;
        private string apellidos;
        private int edad;
        private string direccion;
        private string fecha_nac;

        public Empleado()
        {
            this.id = "";
            this.nombres = "";
            this.apellidos = "";
            this.edad = 0;
            this.direccion = "";
            this.fecha_nac = "";
        }

        public string Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
    }
}
