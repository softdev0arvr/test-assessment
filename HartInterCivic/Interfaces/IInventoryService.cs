using HartInterCivic.DTOs;

namespace HartInterCivic.Interfaces
{
    public interface IInventoryService
    {
        public List<ItemDTO> GetInventoryItems(); 
    }
}
