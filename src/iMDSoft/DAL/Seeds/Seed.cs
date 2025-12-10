using DAL.Entities;

namespace DAL.Seeds
{
    public static class Seed
    {
        public static void SeedDatabase(this DatabaseContext context)
        {
            if (context.Patients.Any())
                return;

            var patients = new List<Patient>
            {
                new Patient { Name = "John Doe",        DateOfBirth = new DateTime(1991, 3, 15),  Gender = "Male"   },
                new Patient { Name = "Jane Smith",      DateOfBirth = new DateTime(1993, 7, 22),  Gender = "Female" },
                new Patient { Name = "Michael Johnson", DateOfBirth = new DateTime(1990, 11, 5),  Gender = "Male"   },
                new Patient { Name = "Emily Davis",     DateOfBirth = new DateTime(1994, 2, 18),  Gender = "Female" },
                new Patient { Name = "Daniel Brown",    DateOfBirth = new DateTime(1992, 9, 30),  Gender = "Male"   },
                new Patient { Name = "Sarah Wilson",    DateOfBirth = new DateTime(1996, 1, 9),   Gender = "Female" },
                new Patient { Name = "Christopher Lee", DateOfBirth = new DateTime(1995, 6, 2),   Gender = "Male"   },
                new Patient { Name = "Laura Anderson",  DateOfBirth = new DateTime(1998, 12, 14), Gender = "Female" },
                new Patient { Name = "Matthew Thomas",  DateOfBirth = new DateTime(1991, 4, 27),  Gender = "Male"   },
                new Patient { Name = "Olivia Harris",   DateOfBirth = new DateTime(1997, 3, 1),   Gender = "Female" },
                new Patient { Name = "Andrew Martin",   DateOfBirth = new DateTime(1990, 8, 19),  Gender = "Male"   },
                new Patient { Name = "Sophia Clark",    DateOfBirth = new DateTime(1999, 10, 11), Gender = "Female" },
                new Patient { Name = "Ryan Walker",     DateOfBirth = new DateTime(1995, 5, 23),  Gender = "Male"   },
                new Patient { Name = "Chloe Hall",      DateOfBirth = new DateTime(1993, 1, 30),  Gender = "Female" },
                new Patient { Name = "Benjamin Young",  DateOfBirth = new DateTime(1994, 7, 7),   Gender = "Male"   },
                new Patient { Name = "Grace King",      DateOfBirth = new DateTime(1992, 11, 21), Gender = "Female" },
                new Patient { Name = "Joshua Wright",   DateOfBirth = new DateTime(1998, 9, 13),  Gender = "Male"   },
                new Patient { Name = "Lily Scott",      DateOfBirth = new DateTime(1996, 4, 5),   Gender = "Female" },
                new Patient { Name = "Adam Green",      DateOfBirth = new DateTime(1993, 12, 2),  Gender = "Male"   },
                new Patient { Name = "Megan Baker",     DateOfBirth = new DateTime(1999, 6, 17),  Gender = "Female" }
            };

            context.Patients.AddRange(patients);
            context.SaveChanges();

            var date = DateTime.Now.Date.AddDays(-1);

            var tests = new List<Test>();

            foreach (var patient in patients)
            {
                tests.Add(new Test
                {
                    PatientId = patient.Id,
                    TestName = "Complete Blood Count",
                    TestDate = date,
                    Result = 4.8m,
                    IsWithinThreshold = true
                });
                date = date.AddDays(-1);

                tests.Add(new Test
                {
                    PatientId = patient.Id,
                    TestName = "Fasting Glucose",
                    TestDate = date,
                    Result = 5.6m,
                    IsWithinThreshold = true
                });
                date = date.AddDays(-1);

                tests.Add(new Test
                {
                    PatientId = patient.Id,
                    TestName = "Total Cholesterol",
                    TestDate = date,
                    Result = 6.2m,
                    IsWithinThreshold = patient.Id % 4 != 0
                });
                date = date.AddDays(-1);

                tests.Add(new Test
                {
                    PatientId = patient.Id,
                    TestName = "Serum Creatinine",
                    TestDate = date,
                    Result = 85m,
                    IsWithinThreshold = true
                });
                date = date.AddDays(-1);

                tests.Add(new Test
                {
                    PatientId = patient.Id,
                    TestName = "ALT (Alanine Transaminase)",
                    TestDate = date,
                    Result = patient.Id % 5 == 0 ? 55m : 25m,
                    IsWithinThreshold = patient.Id % 5 != 0
                });
                date = date.AddDays(-1);
            }

            context.Tests.AddRange(tests);
            context.SaveChanges();
        }
    }
}
