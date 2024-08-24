using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using App.Models;

namespace App.Controllers.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly LoginDbContext _context;

        public LoginRepository(LoginDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        /* public async Task<Cliente> GetClienteByIdAsync(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task AddClienteAsync(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateClienteAsync(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteClienteAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> ClienteExistsAsync(int id)
        {
            return await _context.Clientes.AnyAsync(e => e.EmpId == id);
        } */
    }
}