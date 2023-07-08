namespace HouseRentingSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static HouseRentingSystem.Common.EntityValidationConstants.Category;

    public class Category
    {
        public Category()
        {
            this.Houses = new HashSet<House>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public ICollection<House> Houses { get; set; }
    }
}