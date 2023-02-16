using _11_Mvc_NetCore_EF.Data;
using _11_Mvc_NetCore_EF.Models;

namespace _11_Mvc_NetCore_EF.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;

        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }

        public List<Hospital> GetHospitales()
        {
            var consulta = from datos in this.context.Hospitales
                           select datos;
            return consulta.ToList();
        }

        public Hospital FindHospital(int hospitalCod)
        {
            var consulta = from datos in this.context.Hospitales
                           select new Hospital
                           {
                               HospitalCod = datos.HospitalCod,
                               Nombre = datos.Nombre,
                               Direccion = datos.Direccion,
                               Telefono = datos.Telefono,
                               NumCama = datos.NumCama
                           };
            return consulta.First();
        }
    }
}
