using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace DbAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext([NotNull] DbContextOptions options) : base(options)
        {
        }
    }
}
