﻿namespace Case.IssueTracker.Data
{
    public class AvatarUrls
    {
        [RestSharp.Deserializers.DeserializeAs(Name = "16x16")]
        public string img16x16 { get; set; }
        [RestSharp.Deserializers.DeserializeAs(Name="24x24")]
        public string img24x24 { get; set; }
        [RestSharp.Deserializers.DeserializeAs(Name = "32x32")]
        public string img32x32 { get; set; }
        [RestSharp.Deserializers.DeserializeAs(Name = "48x48")]
        public string img48x48 { get; set; }
    }
}
