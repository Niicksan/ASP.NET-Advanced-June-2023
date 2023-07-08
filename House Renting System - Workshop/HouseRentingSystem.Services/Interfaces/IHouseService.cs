namespace HouseRentingSystem.Services.Interfaces
{
    using HouseRentingSystem.Services.Models.House;
    using HouseRentingSystem.ViewModels.Home;
    using HouseRentingSystem.ViewModels.House;

    public interface IHouseService
    {
        Task<IEnumerable<HomeViewModel>> LastThreeHousesAsync();
        Task<AllHousesFilteredAndPagedServiceModel> AllAsync(AllHousesQueryModel queryModel);
    }
}
