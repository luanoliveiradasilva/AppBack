using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models;

[Table("cliente")]
public class Cliente
{

    [Key]
    public int EmpId { get; set; }
    public string? UserAccount { get; set; }
    public decimal PasswordAccount { get; set; }
}
