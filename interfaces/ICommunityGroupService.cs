using ShopSuphan.Models;

namespace ShopSuphan.interfaces
{
    public interface ICommunityGroupService
    {
        Task<IEnumerable<CommunityGroup>> GetAll();

        Task<CommunityGroup> GetByID(int id);
        Task Create(CommunityGroup แommunityGroup);
        Task Update(CommunityGroup แommunityGroup);
        Task Delete(CommunityGroup แommunityGroup);
    }
}
