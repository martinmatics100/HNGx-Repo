namespace TaskOne.Implementation
{
    public class RequestValidator
    {
        public static bool IsNullOrEmpty(string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsValidTrack(string track)
        {
            // Define a list of valid tracks (e.g., "backend" as specified in the requirements)
            var validTracks = new List<string> { "backend" };

            // Check if the provided track (case-insensitive) is in the list of valid tracks
            return !string.IsNullOrEmpty(track) && validTracks.Contains(track.ToLowerInvariant());
        }

        public static bool IsValidSlackName(string slackName, string providedSlackName)
        {
            // Ensure the provided Slack name matches exactly (case-insensitive)
            return !string.IsNullOrEmpty(slackName) &&
                   slackName.Equals(providedSlackName, StringComparison.OrdinalIgnoreCase);
        }
    }
}
