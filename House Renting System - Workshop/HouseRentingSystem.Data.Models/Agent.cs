namespace HouseRentingSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static HouseRentingSystem.Common.EntityValidationConstants.Agent;

    public class Agent
    {
        public Agent()
        {
            this.Id = Guid.NewGuid();
            this.OwnedHouses = new HashSet<House>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(PhoneNumberMinLength)]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = null!;

        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; } = null!;

        public ICollection<House> OwnedHouses { get; set; }
    }
}