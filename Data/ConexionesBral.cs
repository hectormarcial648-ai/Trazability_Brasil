using Microsoft.EntityFrameworkCore;
using TrazabilityBrasil.Models;

namespace TrazabilityBrasil.Data
{
    public class ConexionesBral : DbContext
    {
        public ConexionesBral(DbContextOptions<ConexionesBral> options)
            : base(options)
        {
        }

        public DbSet<B11Bal> Bal11 { get; set; }
        public DbSet<B12Bal> Bal12 { get; set; }
        public DbSet<B15Bal> Bal15 { get; set; }
        public DbSet<B16Bal> Bal16 { get; set; }
        public DbSet<B17Bal> Bal17 { get; set; }
        public DbSet<B18Bal> Bal18 { get; set; }
        public DbSet<TorquesBrasilFanMotor> FanMotor { get; set; }
        public DbSet<TorquesBrasilFinalAssembly> FinalAssembly { get; set; }

    }
}
