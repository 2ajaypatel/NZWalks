using NZWalks.API.Models.Domain;
using System.Threading.Tasks;

namespace NZWalks.API.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllRegions();

        Task<Region> GetRegionAsync(Guid  id);

        Task<Region> AddAsync(Region region);
        Task<Region> DeleteAsync(Guid id);
        Task<Region> UpdateAsync(Guid id, Region region);
    }
}