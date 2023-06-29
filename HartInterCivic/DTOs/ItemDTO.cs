using HartInterCivic.Models;

namespace HartInterCivic.DTOs
{
    public class ItemDTO
    {
        public ItemDTO(Item item) 
        {
            Description = item.Description;
            Count= item.Count;
        }
        public string? Description { get; set; }
        public int? Count { get; set; }
    }
}
