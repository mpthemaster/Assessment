using SVT_Robotics_Recruiting_Assessment.Controllers;

namespace SVT_Robotics_Recruiting_Assessment
{
    /// <summary>
    /// Finds the closest robot to an object.
    /// </summary>
    public static class ClosestRobotFinder
    {
        /// <summary>
        /// Find the robot closest to the specified load. In the case of more than one robot within 10 units of an object, it will pick the robot with the highest battery level.
        /// </summary>
        /// <param name="load">The load to find a nearby robot.</param>
        /// <returns>The closest robot to the load.</returns>
        public static async Task<Robot> FindClosestTo(Load load)
        {
            List<Robot> robots = await CurrentRobotStatusAPI.GetRobots();

            // Find the closest robot to the load as well as all the robots within 10 units of the pallet.
            // Has a theta(n+k) time-complexity when combined with figuring out which robot has the most battery remaining. 
            List<Robot> robotsWithin10Units = new List<Robot>();
            Robot closestRobot = robots[0];
            foreach (Robot robot in robots)
            {
                robot.CalculateDistanceTo(load);

                if (robot.DistanceToLoad <= 10)
                {
                    robotsWithin10Units.Add(robot);
                }

                if (closestRobot.DistanceToLoad > robot.DistanceToLoad)
                {
                    closestRobot = robot;
                }
            }

            // For more than one robot within 10 feet, check which one has the highest battery level and return that robot instead of the closest robot.
            Robot mostBatteryRemaining = closestRobot;
            foreach (Robot robot in robotsWithin10Units)
            {
                if (robot.BatteryLevel > mostBatteryRemaining.BatteryLevel)
                {
                    mostBatteryRemaining = robot;
                }
            }
            return mostBatteryRemaining;
        }
    }
}
