﻿using ConsultaRegistroswasm.Shared;
using Microsoft.EntityFrameworkCore;

namespace ConsultaRegistroswasm.Server.DAL
{
    public class Context : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<Tickets> Tickets { get; set; }

        public DbSet<Prioridades> Prioridades { get; set; }

        public DbSet<Sistemas> Sistemas { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
