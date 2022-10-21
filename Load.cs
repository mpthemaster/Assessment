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

        [JsonConstructor]
        public Load(int x, int y, string loadId) : base(x, y)
        {
            LoadId = loadId;
        }

    }
}
