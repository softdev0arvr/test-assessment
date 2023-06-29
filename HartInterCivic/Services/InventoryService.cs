using HartInterCivic.Interfaces;
using HartInterCivic.DTOs;
using HartInterCivic.Data;

namespace HartInterCivic.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly HartInterCivicDbContext _hartInterCivicDbContext;

        public InventoryService(HartInterCivicDbContext hartInterCivicDbContext) 
        {
            _hartInterCivicDbContext = hartInterCivicDbContext;
        }
        public List<ItemDTO> GetInventoryItems()
        {
            // TODO: Can Improve this in future to cater larger count of records.
            // Can Introduce Pagination maybe?

            var itemLists = _hartInterCivicDbContext.Items.ToList();
            var itemDTOList = new List<ItemDTO>();
            foreach (var item in itemLists)
            {
                itemDTOList.Add(new ItemDTO(item));
            }
            return itemDTOList;
        }
    }
}
