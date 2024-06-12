using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models;
public class loginViewModel
{
    [Required]
    public string username { get; set; } = string.Empty;
    [Required]
    public string password { get; set; } = string.Empty;
    public string fullname { get; set; } = string.Empty;
}