using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVCG20250324S14.AppMVCWeb.Models;

public partial class ClientesDb2Context : DbContext
{
    public ClientesDb2Context()
    {
    }

    public ClientesDb2Context(DbContextOptions<ClientesDb2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3214EC0762BF9642");

            entity.Property(e => e.Direccion).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
