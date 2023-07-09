namespace HouseRentingSystem.Services.Interfaces
{
    using HouseRentingSystem.Services.Models.House;
    using HouseRentingSystem.ViewModels.Home;
    using HouseRentingSystem.ViewModels.House;

    public interface IHouseService
    {
        Task<IEnumerable<HomeViewModel>> LastThreeHousesAsync();

        Task<AllHousesFilteredAndPagedServiceModel> AllAsync(AllHousesQueryModel queryModel);

        Task<IEnumerable<HouseAllViewModel>> AllByAgentIdAsync(string agentId);

        Task<IEnumerable<HouseAllViewModel>> AllByUserIdAsync(string userId);

        Task<bool> ExistsByIdAsync(string houseId);

        Task<string> CreateAndReturnIdAsync(HouseFormModel formModel, string agentId);

        Task<HouseDetailsViewModel> GetDetailsByIdAsync(string houseId);

        Task<HouseFormModel> GetHouseForEditByIdAsync(string houseId);

        Task<HousePreDeleteDetailsViewModel> GetHouseForDeleteByIdAsync(string houseId);

        Task<bool> IsAgentWithIdOwnerOfHouseWithIdAsync(string houseId, string agentId);

        Task EditHouseByIdAndFormModelAsync(string houseId, HouseFormModel formModel);

        Task DeleteHouseByIdAsync(string houseId);
    }
}
