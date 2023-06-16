using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentRecordSystem.Models;

namespace StudentRecordSystem.Data
{
    public class ApplicationDbContext:IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<University> Universities { get; set;}
        public DbSet<Faculty> Faculties { get; set;}
        public DbSet<School> Schools { get; set;}
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<University>().HasData(
                new University 
                {
                    Id=1,
                    Name= "Cairo Univeristy",
                    Description= "Cairo University (Arabic: جامعة القاهرة, romanized: Jāmi‘a al-Qāhira), also known as the Egyptian University from 1908 to 1940, and King Fuad I University and Fu'ād al-Awwal University from 1940 to 1952, is Egypt's premier public university. Its main campus is in Giza, immediately across the Nile from Cairo. It was founded on 21 December 1908;however, after being housed in various parts of Cairo, its faculties, beginning with the Faculty of Arts, were established on its current main campus in Giza in October 1929. It is the second oldest institution of higher education in Egypt after Al-Azhar University, notwithstanding the pre-existing higher professional schools that later became constituent colleges of the university. It was founded and funded as the Egyptian University by a committee of private citizens with royal patronage in 1908 and became a state institution under King Fuad I in 1925. In 1940, four years following his death, the university was renamed King Fuad I University in his honor. It was renamed a second time after the 1952 Egyptian Revolution. The university currently enrolls approximately 155,000 students in 20 faculties and 3 institutions. It counts three Nobel Laureates among its graduates and is one of the 50 largest institutions of higher education in the world by enrollment.",
                    Location= "1 University Street, Giza 12613",
                    City="Giza",
                    EstablishmentDate= "December 21, 1908",
                    ImageUrl= "https://uni-find.com/en/wp-content/uploads/2020/03/Cairo-University.png"
                },
                 new University
                 {
                     Id = 2,
                     Name = "Ain Shams University",
                     Description = "Ain Shams University, as the third Egyptian university, was founded in July 1950 under the name of 'Ibrahim Pasha University'. It participated with the two earlier universities, 'Cairo University' (Fua'd the 1st ) and 'Alexandria University' (Farouk the 1st) in fulfilling the message of universities and meeting the increasing demand of youth for higher education. When it was first established, Ain Shams University comprised a number of distinguished faculties and academic institutes, which were later developed into university",
                     Location= "El-Khalyfa El-Mamoun Street Abbasya, Cairo , Eygpt",
                     City = "Cairo",
                     EstablishmentDate = "July 1950",
                     ImageUrl= "https://www.asu.edu.eg/storage//uploads/2022/slider/nUIegg3j.jpg"

                 },
                  new University
                  {
                      Id = 3,
                      Name = "Helwan University",
                      Description = "Helwan University is a member of the Egyptian Supreme Council of Universities. It was established on July 26, 1980 by Act No. 70 of 1975 over 350 acres of land. It is the youngest of 3 major governmental universities in Cairo.However, it goes back to the 19th century during the reign of Muhammad Ali of Egypt who established “The Operations School”. The fields of that school were the basis of many institutes that formed Helwan University later.Although Helwan University is the most recent of 3 major governmental universities in Cairo, it encompasses some of the oldest faculties not only in Egypt but also in the Middle East. The Faculty of Applied Arts, for example, was established in 1839, while the Faculty of Fine Arts and Art Education were established in 1908 and 1936 respectively.",
                      Location= "Al Sikka Al Hadid Al Gharbeya, Qism Helwan",
                      City = "Helwan",
                      EstablishmentDate = "July 26, 1980",
                     ImageUrl= "https://www.egypttoday.com/siteimages/Larg/20211207032202222.jpg"
                  }
                );
            modelBuilder.Entity<Faculty>().HasData
                (
                new Faculty { Id=1,Name= "Faculty of Engineering",FacultyYears=5 },
                new Faculty { Id=2,Name= "Faculty of Medicine",FacultyYears = 7 },
                new Faculty { Id=3,Name= "Faculty of Computers and Artificial Intelligence",FacultyYears=4 },
                new Faculty { Id=4,Name= "Faculty of Pharmacy",FacultyYears = 5 },
                new Faculty { Id=5,Name= "Faculty of Agriculture " , FacultyYears = 4 },
                new Faculty { Id=6,Name= "Faculty of Science", FacultyYears = 4 },
                new Faculty { Id=7,Name= "Faculty of Economics and Political Science", FacultyYears = 4 },
                new Faculty { Id=8,Name= "Faculty of Mass Communication", FacultyYears = 4 },
                new Faculty { Id=9,Name= "Faculty of Archaeology ", FacultyYears = 4 },
                new Faculty { Id=10,Name= "Faculty of Arts", FacultyYears = 4 },
                new Faculty { Id=11,Name= "Faculty of Commerce", FacultyYears = 4 },
                new Faculty { Id=12,Name= "Faculty of Specific Education" , FacultyYears = 4 },
                new Faculty { Id=13,Name= "Faculty of Nursing",FacultyYears = 4 },
                new Faculty { Id=14,Name= "Faculty of Law",FacultyYears = 4 },
                new Faculty { Id=15,Name= "Faculty of Physical Therapy" , FacultyYears = 4 },
                new Faculty { Id=16,Name= "Faculty of Oral and Dental Medicine" , FacultyYears = 4 },
                new Faculty { Id=17,Name= "Faculty of Dar El-Ulum" , FacultyYears = 4 }
                );
            modelBuilder.Entity<School>().HasData
                (
                new School { Id = 1,Name="Shobra-ElKhima",Location="15 Damnhor Shobra Elkima ",City="Qaluobia",Type= "Elementary School" },
                new School { Id = 2,Name="El-yosr",Location= "jazira warraq el-hadr", City="Giza",Type= "Middle School" },
                new School { Id = 3,Name="El-Tawfikia elthanawya banen",Location= "shobra street", City="Cairo",Type= "High School" }
                );
        }

    }
}
