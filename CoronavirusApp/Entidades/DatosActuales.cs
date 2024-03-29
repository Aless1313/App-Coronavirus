﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CoronavirusApp.Entidades
{
    public partial class DatosActuales
    {
        [JsonProperty("Global")]
        public Global Global { get; set; }

        [JsonProperty("Countries")]
        public List<Country> Countries { get; set; }

        [JsonProperty("Date")]
        public DateTimeOffset Date { get; set; }
    }

    public partial class Country
    {
        [JsonProperty("Country")]
        public string CountryCountry { get; set; }

        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("Slug")]
        public string Slug { get; set; }

        [JsonProperty("NewConfirmed")]
        public long NewConfirmed { get; set; }

        [JsonProperty("TotalConfirmed")]
        public long TotalConfirmed { get; set; }

        [JsonProperty("NewDeaths")]
        public long NewDeaths { get; set; }

        [JsonProperty("TotalDeaths")]
        public long TotalDeaths { get; set; }

        [JsonProperty("NewRecovered")]
        public long NewRecovered { get; set; }

        [JsonProperty("TotalRecovered")]
        public long TotalRecovered { get; set; }

        [JsonProperty("Date")]
        public DateTimeOffset Date { get; set; }
        public override string ToString()
        {
            return $"{CountryCountry}-->Infectados: {TotalConfirmed} Fallecidos: {TotalDeaths} Recuperados {TotalRecovered}";
        }
    }

    public partial class Global
    {
        [JsonProperty("NewConfirmed")]
        public long NewConfirmed { get; set; }

        [JsonProperty("TotalConfirmed")]
        public long TotalConfirmed { get; set; }

        [JsonProperty("NewDeaths")]
        public long NewDeaths { get; set; }

        [JsonProperty("TotalDeaths")]
        public long TotalDeaths { get; set; }

        [JsonProperty("NewRecovered")]
        public long NewRecovered { get; set; }

        [JsonProperty("TotalRecovered")]
        public long TotalRecovered { get; set; }
    }
}
