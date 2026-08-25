using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Newtonsoft.Json;
using Proyecto_entrega3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web.Http;

namespace Proyecto_entrega3.Controllers
{
    public class CarreraController : ApiController
    {
        //GET
        private static readonly HttpClient client = new HttpClient();
        [HttpGet]
        public async Task<HttpResponseMessage> Get(DataSourceLoadOptions loadOptions)
        {
            var apiUrl = "https://localhost:44300/api/Carrera";
            var respuestaJson = await GetAsync(apiUrl);
            List<Carrera> listaCarrera = JsonConvert.DeserializeObject<List<Carrera>>(respuestaJson);
            return Request.CreateResponse(DataSourceLoader.Load(listaCarrera, loadOptions));
        }

        public static async Task<string> GetAsync(string uri)
        {
            var response = await client.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        //POST
        [HttpPost]
        public async Task<HttpResponseMessage> Post(FormDataCollection form)
        {

            var values = form.Get("values");

            var httpContent = new StringContent(values, System.Text.Encoding.UTF8, "application/json");

            var url = "https://localhost:44300/api/Carrera";
            var response = await client.PostAsync(url, httpContent);

            var result = response.Content.ReadAsStringAsync().Result;

            return Request.CreateResponse(HttpStatusCode.Created);
        }

        //PUT
        [HttpPut]
        public async Task<HttpResponseMessage> Put(FormDataCollection form)
        {
            //Parámetros del form
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");

            var apiUrlGetCarrera = $"https://localhost:44300/api/Carrera/{key}";
            var respuestaCarrera = await client.GetStringAsync(apiUrlGetCarrera);
            Carrera carrera = JsonConvert.DeserializeObject<Carrera>(respuestaCarrera);

            JsonConvert.PopulateObject(values, carrera);

            string jsonString = JsonConvert.SerializeObject(carrera);
            var httpContent = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json");

            var url = $"https://localhost:44300/api/Carrera/{key}";
            var response = await client.PutAsync(url, httpContent);

            var result = await response.Content.ReadAsStringAsync();
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        //DELETE
        [HttpDelete]
        public async Task<HttpResponseMessage> Delete(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));

            var apiUrlDelaCarrera = $"https://localhost:44300/api/Carrera/{key}";
            var response = await client.DeleteAsync(apiUrlDelaCarrera);

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
