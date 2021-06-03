using Microsoft.AspNetCore.Mvc;

namespace LLC.Server.Controllers.Utilities
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreferencesController : ControllerBase
    {
        //private readonly IServerPreferenceManager _serverPreferenceManager;

        public PreferencesController(
            //IServerPreferenceManager serverPreferenceManager
            )
        {
            //_serverPreferenceManager = serverPreferenceManager;
        }

        //TODO - add actions
    }
}
