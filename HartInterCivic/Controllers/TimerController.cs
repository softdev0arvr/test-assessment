using HartInterCivic.Interfaces;
using HartInterCivic.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HartInterCivic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimerController : ControllerBase
    {
        private readonly ITimerConfigurationService _timerConfigurationService;

        public TimerController(ITimerConfigurationService timerConfigurationService)
        {
            _timerConfigurationService = timerConfigurationService;
        }

        // GET: Timer/Configure
        [HttpGet]
        [Route("Configure")]
        public ActionResult GetConfiguration()
        {
            try 
            {
                var timerConfiguration = _timerConfigurationService.GetLatestTimerConfiguration();
                if(timerConfiguration != null)
                {
                    return Ok(timerConfiguration);
                }
                return NotFound();
            }
            catch (Exception ex) 
            {
                //TODO: Logging to Console for now
                Console.WriteLine(ex);
                return new ObjectResult(ex.Message) { StatusCode = (int?)HttpStatusCode.InternalServerError};
            }
            
        }

        // POST: Timer/Stop
        [HttpPost]
        [Route("Stop")]
        public IActionResult TimerFinished()
        {
            // TODO: What more can be done here?
            return Ok();
        }

    }
}