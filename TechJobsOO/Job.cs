using System;
using System.Text;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            this.Name = name;
            this.EmployerName = employerName;
            this.EmployerLocation = employerLocation;
            this.JobType = jobType;
            this.JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            StringBuilder jobString = new StringBuilder();
            jobString.Append("\n");

            if (!(Equals(Name, "") && Equals(EmployerName.ToString(), "") && Equals(EmployerLocation.ToString(), "") && Equals(JobType.ToString(), "") && Equals(JobCoreCompetency.ToString(), "")))
            {
                jobString.Append("ID: ").Append(Id).Append("\n");
                jobString.Append("Name: ").Append(Name != "" ? Name : "Data not available").Append("\n");
                jobString.Append("Employer: ").Append(EmployerName.ToString() != "" ? EmployerName.ToString() : "Data not available").Append("\n");
                jobString.Append("Location: ").Append(EmployerLocation.ToString() != "" ? EmployerLocation.ToString() : "Data not available").Append("\n");
                jobString.Append("Position Type: ").Append(JobType.ToString() != "" ? JobType.ToString() : "Data not available").Append("\n");
                jobString.Append("Core Competency: ").Append(JobCoreCompetency.ToString() != "" ? JobCoreCompetency.ToString() : "Data not available").Append("\n");
            }
            else
            {
                jobString.Append("OOPS! This job does not seem to exist.").Append("\n");
            }

            jobString.Append("\n");

            return jobString.ToString();
        }
    
    }
}
