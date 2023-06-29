using HartInterCivic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HartInterCivic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        [HttpGet]
        public ActionResult Get() 
        {
            try 
            {
                var items = _inventoryService.GetInventoryItems();
                if(items.Count == 0)
                {
                    return NotFound();
                }
                // TODO: Do I need JSON Serializer here?
                return Ok(items);
            }
            catch (Exception ex) 
            {
                //TODO: Logging to Console for now
                Console.WriteLine(ex);
                return new ObjectResult(ex.Message) { StatusCode = (int?)HttpStatusCode.InternalServerError };
            }
        }
    }
}
