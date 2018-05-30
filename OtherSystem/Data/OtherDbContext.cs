using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Other.Data
{
    public  class OtherDbContext : DbContext
    {
        public OtherDbContext()
            : base("Forest")
        {
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new DefaultDbContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<LoggingAccount>().HasRequired(x => x.LoggingMethod).WithMany().HasForeignKey(x => x.LoggingMethodId).WillCascadeOnDelete(false);

            //modelBuilder.Entity<LoggingAccount>().HasMany(x => x.LoggingGPSInfoes).WithRequired(x => x.LoggingAccount).HasForeignKey(x => x.LoggingAccountId).WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }
    }

    public class DefaultDbContextInitializer : DropCreateDatabaseIfModelChanges<OtherDbContext>
    {
        protected override void Seed(OtherDbContext context)
        {
            #region 初始化采伐方式
            //var methods = new List<LoggingMethod>
            //{
            //    new LoggingMethod { Name = "择伐", Order = 10 },
            //    new LoggingMethod { Name = "皆伐", Order = 20 },
            //    new LoggingMethod { Name = "征占用林地采伐", Order = 30 },
            //    new LoggingMethod { Name = "移植", Order = 40 },
            //    new LoggingMethod { Name = "渐伐", Order = 50 },
            //    new LoggingMethod { Name = "生态疏伐", Order = 60 },
            //    new LoggingMethod { Name = "用材林抚育采伐", Order = 70 },
            //    new LoggingMethod { Name = "防护林抚育采伐", Order = 80 },
            //    new LoggingMethod { Name = "低产用材林改造采伐", Order = 90 },
            //    new LoggingMethod { Name = "低效防护林改造采伐", Order = 100 },
            //    new LoggingMethod { Name = "林分更新采伐", Order = 110 },
            //    new LoggingMethod { Name = "林带更新采伐", Order = 120 },
            //    new LoggingMethod { Name = "薪炭林采伐", Order = 130 },
            //    new LoggingMethod { Name = "经济林采伐", Order = 140 },
            //    new LoggingMethod { Name = "特用林采伐", Order = 150 },
            //    new LoggingMethod { Name = "森林防火隔离带建设采伐", Order = 160 },
            //    new LoggingMethod { Name = "病虫害防治隔离带采伐", Order = 170 },
            //    new LoggingMethod { Name = "散生木采伐", Order = 180 },
            //    new LoggingMethod { Name = "四旁树采伐", Order = 190 },
            //    new LoggingMethod { Name = "透光伐", Order = 200 },
            //    new LoggingMethod { Name = "除伐", Order = 210 },
            //    new LoggingMethod { Name = "疏伐", Order = 220 },
            //    new LoggingMethod { Name = "生长伐", Order = 230 },
            //    new LoggingMethod { Name = "卫生伐", Order = 240 },
            //    new LoggingMethod { Name = "多次渐伐", Order = 250 },
            //    new LoggingMethod { Name = "综合改造", Order = 260 },
            //    new LoggingMethod { Name = "其他采伐方式", Order = 999 }
            //};
            //context.Set<LoggingMethod>().AddRange(methods);
            //context.SaveChanges();
            #endregion

            base.Seed(context);
        }
    }
}
