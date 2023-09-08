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
            var validTracks = new List<string> { "backend" };
     
            return !string.IsNullOrEmpty(track) && validTracks.Contains(track.ToLowerInvariant());
        }

        public static bool IsValidSlackName(string slackName, string providedSlackName)
        {
            return !string.IsNullOrEmpty(slackName) &&
                   slackName.Equals(providedSlackName, StringComparison.OrdinalIgnoreCase);
        }
    }
}
