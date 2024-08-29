using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_IdAu1.Models.Database
{
    public class Users : IdentityUser
    {
        public int IdUser { get; set; }
    }
}
