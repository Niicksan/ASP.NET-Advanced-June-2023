namespace HouseRentingSystem.Services.Models.House
{
    using HouseRentingSystem.ViewModels.House;

    public class AllHousesFilteredAndPagedServiceModel
    {
        public AllHousesFilteredAndPagedServiceModel()
        {
            this.Houses = new HashSet<HouseAllViewModel>();
        }

        public int TotalHousesCount { get; set; }

        public IEnumerable<HouseAllViewModel> Houses { get; set; }
    }
}
