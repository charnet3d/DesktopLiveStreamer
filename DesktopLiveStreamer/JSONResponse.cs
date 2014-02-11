using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopLiveStreamer
{
    public class Links
    {
        public string self { get; set; }
        public string channel { get; set; }
    }

    public class Links2
    {
        public string self { get; set; }
    }

    public class Links3
    {
        public string self { get; set; }
        public string follows { get; set; }
        public string commercial { get; set; }
        public string stream_key { get; set; }
        public string chat { get; set; }
        public string features { get; set; }
        public string subscriptions { get; set; }
        public string editors { get; set; }
        public string videos { get; set; }
    }

    public class Links4
    {
        public string self { get; set; }
    }

    public class Team
    {
        public int _id { get; set; }
        public string name { get; set; }
        public string info { get; set; }
        public string display_name { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string logo { get; set; }
        public string banner { get; set; }
        public string background { get; set; }
        public Links4 _links { get; set; }
    }

    public class Channel
    {
        public object mature { get; set; }
        public string status { get; set; }
        public string display_name { get; set; }
        public string game { get; set; }
        public int _id { get; set; }
        public string name { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string logo { get; set; }
        public object banner { get; set; }
        public object video_banner { get; set; }
        public object background { get; set; }
        public string url { get; set; }
        public Links3 _links { get; set; }
        public List<Team> teams { get; set; }
    }

    public class StreamJson
    {
        public string name { get; set; }
        public string broadcaster { get; set; }
        public long _id { get; set; }
        public string game { get; set; }
        public int viewers { get; set; }
        public string preview { get; set; }
        public Links2 _links { get; set; }
        public Channel channel { get; set; }
    }

    public class RootObject
    {
        public Links _links { get; set; }
        public StreamJson stream { get; set; }
    }
}
