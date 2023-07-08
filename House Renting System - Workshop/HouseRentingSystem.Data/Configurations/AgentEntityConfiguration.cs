namespace HouseRentingSystem.Data.Configurations
{
    using HouseRentingSystem.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class AgentEntityConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            builder.HasData(this.GenerateAgens());
        }

        private Agent[] GenerateAgens()
        {
            ICollection<Agent> agents = new HashSet<Agent>();

            Agent agent = new Agent()
            {
                Id = Guid.Parse("98C666AC-9AEE-80C3-5686-08DB7FBB6666"),
                PhoneNumber = "+359888888888",
                UserId = Guid.Parse("98C929AC-9AEE-40C3-5691-08DB7FBB6193")
            };
            agents.Add(agent);

            return agents.ToArray();
        }
    }
}
