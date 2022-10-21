using SVT_Robotics_Recruiting_Assessment.Controllers;

namespace SVT_Robotics_Recruiting_Assessment
{
    public static class ClosestRobotFinder
    {
        public static async Task<Robot> FindClosestTo(Load load)
        {
            List<Robot> robots = await CurrentRobotStatusAPI.GetRobots();

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
