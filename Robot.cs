using System.Text.Json.Serialization;

namespace SVT_Robotics_Recruiting_Assessment
{
    public class Robot : Physical
    {
        [JsonPropertyName("robotId")]
        public string RobotId { get; set; }

        [JsonPropertyName("batteryLevel")]
        public int BatteryLevel { get; set; }

        [JsonIgnore]
        public double DistanceToLoad { get; set; }

        /// <summary>
        /// Create a robot.
        /// </summary>
        /// <param name="x">The x-coordinate of the robot.</param>
        /// <param name="y">The y-coordinate of the robot.</param>
        /// <param name="robotId">The ID of the robot.</param>
        /// <param name="batteryLevel">The battery level of the robot.</param>
        public Robot(int x, int y, string robotId, int batteryLevel) : base(x, y)
        {
            DistanceToLoad = double.MaxValue;
            RobotId = robotId;
            BatteryLevel = batteryLevel;
        }

        /// <summary>
        /// Calculate the distance between this robot and another object, such as a pallet or load.
        /// </summary>
        /// <param name="physical">The object to calculate the distance to.</param>
        public void CalculateDistanceTo(Physical physical)
        {
            double xDifferenceSquared = Math.Pow((X - physical.X), 2);
            double yDifferenceSquared = Math.Pow((Y - physical.Y), 2);

            double distance = Math.Sqrt(xDifferenceSquared + yDifferenceSquared);
            DistanceToLoad = distance;
        }
    }
}
