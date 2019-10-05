using System.Security.Cryptography.X509Certificates;
using DatingApp.API.models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext :Microsoft.EntityFrameworkCore.DbContext
    {

        public DataContext(DbContextOptions<DataContext> options): base(options){}
        
        public DbSet<Value>  Values { get; set; }

        
    }
}