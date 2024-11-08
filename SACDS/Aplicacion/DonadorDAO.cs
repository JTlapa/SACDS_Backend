using Microsoft.EntityFrameworkCore;
using SACDS.Modelo.EntityFramework;

namespace SACDS.Aplicacion
{
    public static class DonadorDAO
    {

        private static readonly SADCDSDbContext _context;
        public static async Task<bool> VerifyCorreoDisponible(string correo)
        {
            try
            {
                Donador donador = await _context.donadors.FirstOrDefaultAsync(d => d.Correo == correo);
                return donador == null ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
