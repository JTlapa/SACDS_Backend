using Microsoft.EntityFrameworkCore;
using SACDS.Modelo.EntityFramework;

namespace SACDS.Aplicacion
{
    public static class DonadorDAO
    {

        public static SADCDSDbContext _context;
        public static async Task<bool> VerifyCorreoDisponible(string correo)
        {
            try
            {
                Donador donador = await _context.donadors.FirstOrDefaultAsync(d => d.Correo == correo);
                if (donador == null)
                {
                    return true;
                }else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
