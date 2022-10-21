using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SVT_Robotics_Recruiting_Assessment.Controllers
{
    [Route("api/robots/closest")]
    [ApiController]
    public class RobotsController : ControllerBase
    {
        // POST api/<RobotsController>
        [HttpPost]
        public async Task<ClosestRobotResponse> Post([FromBody] Load load)
        {
            Robot robot = await ClosestRobotFinder.FindClosestTo(load);

            return new ClosestRobotResponse(robot.RobotId, robot.DistanceToLoad, robot.BatteryLevel);
        }
    }
}
