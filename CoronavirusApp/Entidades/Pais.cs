using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CoronavirusApp.Entidades
{
    public partial class Pais
    {
        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("Slug")]
        public string Slug { get; set; }

        [JsonProperty("ISO2")]
        public string Iso2 { get; set; }
        public override string ToString()
        {
            return Country;
        }
    }
}
