using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CoronavirusApp
{
    public class GenericRepository<T> where T : class
    {
        public async Task<T> TraerDatos(string url)
        {
            HttpClient cliente = new HttpClient
            {
                BaseAddress = new Uri("https://api.covid19api.com/")
            };
            cliente.DefaultRequestHeaders.Accept.Clear();
            cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await cliente.GetAsync(url).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                T datos = JsonConvert.DeserializeObject<T>(content);
                return datos;
            }
            else { return null; }

        }
    }
}
