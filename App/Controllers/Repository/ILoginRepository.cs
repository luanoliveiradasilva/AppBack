using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models;

namespace App.Controllers.Repository;
public interface ILoginRepository
{
    Task<IEnumerable<Cliente>> GetClientesAsync();
/*     Task<Cliente> GetClienteByIdAsync(int empId);
    Task AddClienteAsync(Cliente cliente);
    Task UpdateClienteAsync(Cliente cliente);
    Task DeleteClienteAsync(int empId);
    Task<bool> ClienteExistsAsync(int empId); */
}
