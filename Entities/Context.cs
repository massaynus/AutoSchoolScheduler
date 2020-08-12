using Microsoft.EntityFrameworkCore;

namespace Scheduler
{
    public class SchedulerContext : DbContext
    {
        public DbSet<Groupe> Groupes { get; set; }
        public DbSet<Branche> Branches { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<Equipement> Equipements { get; set; }

        public DbSet<BrancheModule> BrancheModules { get; set; }
        public DbSet<TeacherModule> TeacherModules { get; set; }
        public DbSet<ClassRoomEquipement> ClassRoomEquipements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=.; Integrated Security=True;Initial Catalog=SchoolSchedulerDB");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Groupe)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.GroupeID);

            modelBuilder.Entity<BrancheModule>()
                .HasOne(bm => bm.Branche)
                .WithMany(b => b.Modules)
                .HasForeignKey(bm => bm.BrancheID);

            modelBuilder.Entity<BrancheModule>()
                .HasOne(bm => bm.Module)
                .WithMany(m => m.Branches)
                .HasForeignKey(bm => bm.ModuleID);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Groupe)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.GroupeID);

            modelBuilder.Entity<TeacherModule>()
                .HasOne(tm => tm.Teacher)
                .WithMany(t => t.ModuleTeachers)
                .HasForeignKey(tm => tm.TeacherID);

            modelBuilder.Entity<TeacherModule>()
                .HasOne(tm => tm.Module)
                .WithMany(m => m.ModuleTeachers)
                .HasForeignKey(tm => tm.ModuleID);

            modelBuilder.Entity<ClassRoomEquipement>()
                .HasOne(c => c.Room)
                .WithMany(r => r.Equipements)
                .HasForeignKey(c => c.RoomID);

            modelBuilder.Entity<ClassRoomEquipement>()
                .HasOne(c => c.Equipement)
                .WithMany(e => e.ClassRooms)
                .HasForeignKey(c => c.EquipementID);
        }
    }
}