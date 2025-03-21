﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using practica2CRUD.Models;

namespace practica2CRUD.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Asignaturas> Asignaturas { get; set; } = default!;
        public DbSet<practica2CRUD.Models.Estudiante> Estudiante { get; set; } = default!;
    }
}
