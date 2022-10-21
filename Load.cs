using System.Text.Json.Serialization;

namespace SVT_Robotics_Recruiting_Assessment
{
    /// <summary>
    /// Represents a physical load or pallet for a robot to transport.
    /// </summary>
    public class Load : Physical
    {
        /// <summary>
        /// The identifier for the specific object.</param>
        /// </summary>
        [JsonPropertyName("loadId")]
        public string LoadId { get; set; }

        /// <summary>
        /// Create a load.
        /// </summary>
        /// <param name="x">The load's x-coordinate.</param>
        /// <param name="y">The load's y-coordinate.</param>
        /// <param name="loadId">The ID of the load.</param>
        [JsonConstructor]
        public Load(int x, int y, string loadId) : base(x, y)
        {
            LoadId = loadId;
        }

    }
}
