namespace SVT_Robotics_Recruiting_Assessment
{
    /// <summary>
    /// The API web response for finding the closest robot.
    /// </summary>
    public class ClosestRobotResponse
    {
        public string RobotId { get; set; }
        public double DistanceToGoal { get; set; }
        public int BatteryLevel { get; set; }

        public ClosestRobotResponse(string robotId, double distanceToGoal, int batteryLevel)
        {
            RobotId = robotId;
            DistanceToGoal = distanceToGoal;
            BatteryLevel = batteryLevel;
        }
    }
}
