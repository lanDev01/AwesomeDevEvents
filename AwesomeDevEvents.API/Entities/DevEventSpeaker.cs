namespace AwesomeDevEvents.API.Entities
{
    public class DevEventSpeaker
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string TalkTilte { get; set; }
        public string TalkDescription { get; set; }
        public string LinkedInProfile { get; set; }
    }
}