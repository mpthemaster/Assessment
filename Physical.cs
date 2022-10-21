using System.Text.Json.Serialization;

namespace SVT_Robotics_Recruiting_Assessment
{
    /// <summary>
    /// Represents objects located in the real-world.
    /// </summary>
    public abstract class Physical
    {
        /// <summary>
        /// The X-coordinate where this object is located.
        /// </summary>
        [JsonPropertyName("x")]
        public int X { get; set; }

        /// <summary>
        /// The Y-coordinate where this object is located.
        /// </summary>
        [JsonPropertyName("y")]
        public int Y { get; set; }

        /// <summary>
        /// Creates a new representation of a Physical object in the real-world.
        /// </summary>
        /// <param name="x">The X-coordinate where this object is located.</param>
        /// <param name="y">The Y-coordinate where this object is located.</param>
        public Physical(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
