using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MyDBtestEntity;
using System;
using System.Security.Cryptography.X509Certificates;

namespace MyLibDBAccess
{
    public class MyDbContext : DbContext
    {

        public MyDbContext()
        {
            
        }
        public MyDbContext(DbContextOptions<MyDbContext> dbContextOptions):base(dbContextOptions)
        {
        }
        public DbSet<EBRANCH_VTMA_DETAIL> eBRANCH_VTMA_DETAILs { get; set; }
        
       
    }
    
}
