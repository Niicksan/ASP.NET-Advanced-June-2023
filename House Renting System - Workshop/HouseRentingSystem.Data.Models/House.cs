namespace HouseRentingSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static HouseRentingSystem.Common.EntityValidationConstants.House;

    public class House
    {
        public House()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(TitleMinLength)]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MinLength(AddressMinLength)]
        [MaxLength(AddressMaxLength)]
        public string Address { get; set; } = null!;

        [Required]
        [MinLength(DescriptionMinLength)]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(ImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), PricePerMonthMinValue, PricePerMonthMaxValue)]
        public decimal PricePerMonth { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public bool IsActive { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;

        [Required]
        public Guid AgentId { get; set; }

        public Agent Agent { get; set; } = null!;

        public Guid? RenterId { get; set; }

        public ApplicationUser? Renter { get; set; }
    }
}
