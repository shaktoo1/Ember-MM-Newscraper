﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Trakttv.TraktAPI.Model
{
    [DataContract]
    public class TraktRatingEpisode
    {
        [DataMember(Name = "username")]
        public string UserName { get; set; }

        [DataMember(Name = "password")]
        public string Password { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "year")]
        public string Year { get; set; }

        [DataMember(Name = "season")]
        public string Season { get; set; }

        [DataMember(Name = "episode")]
        public string Episode { get; set; }

        [DataMember(Name = "tvdb_id")]
        public string SeriesID { get; set; }

        [DataMember(Name = "rating")]
        public string Rating { get; set; }
    }
}
