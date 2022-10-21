namespace SVT_Robotics_Recruiting_Assessment
{
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
