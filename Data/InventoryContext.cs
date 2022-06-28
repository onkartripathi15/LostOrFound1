using LostOrFound.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostOrFound.Data
{
    public class InventoryContext:/* Identity*/DbContext
    {
        public InventoryContext(DbContextOptions options):base(options)
        {

        }


        public virtual DbSet<Unit> Units { get; set; } 
   


    }
}
