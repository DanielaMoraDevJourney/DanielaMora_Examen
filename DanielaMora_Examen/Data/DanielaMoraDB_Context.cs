using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DanielaMora_Examen.Models;

    public class DanielaMoraDB_Context : DbContext
    {
        public DanielaMoraDB_Context (DbContextOptions<DanielaMoraDB_Context> options)
            : base(options)
        {
        }

        public DbSet<DanielaMora_Examen.Models.DM_tabla1> DM_tabla1 { get; set; } = default!;
    }
