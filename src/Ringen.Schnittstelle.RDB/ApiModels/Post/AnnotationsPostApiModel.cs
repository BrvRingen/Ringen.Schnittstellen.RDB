using Newtonsoft.Json;

namespace Ringen.Schnittstellen.RDB.ApiModels.Post
{
    internal class AnnotationsPostApiModel
    {
        [JsonProperty("points")]
        public RoundValuePostApiModel Points { get; set; }

        [JsonProperty("duration")]
        public RoundValuePostApiModel Duration { get; set; }
    }
}
