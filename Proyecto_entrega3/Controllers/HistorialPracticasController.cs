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
    public class HistorialPracticasController : ApiController
    {
        //GET
        private static readonly HttpClient client = new HttpClient();
        [HttpGet]
        public async Task<HttpResponseMessage> Get(DataSourceLoadOptions loadOptions)
        {
            var apiUrl = "https://localhost:44300/api/HistorialPractica";
            var respuestaJson = await GetAsync(apiUrl);
            List<HistorialPracticas> listaHistorialP = JsonConvert.DeserializeObject<List<HistorialPracticas>>(respuestaJson);
            return Request.CreateResponse(DataSourceLoader.Load(listaHistorialP, loadOptions));
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

            var url = "https://localhost:44300/api/HistorialPractica";
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

            var apiUrlGetHistorialPracticas = $"https://localhost:44300/api/HistorialPractica/{key}";
            var respuestaHistorialPracticas = await client.GetStringAsync(apiUrlGetHistorialPracticas);
            HistorialPracticas historialPracticas = JsonConvert.DeserializeObject<HistorialPracticas>(respuestaHistorialPracticas);

            JsonConvert.PopulateObject(values, historialPracticas);

            string jsonString = JsonConvert.SerializeObject(historialPracticas);
            var httpContent = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json");

            var url = $"https://localhost:44300/api/HistorialPractica/{key}";
            var response = await client.PutAsync(url, httpContent);

            var result = await response.Content.ReadAsStringAsync();
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        //DELETE
        [HttpDelete]
        public async Task<HttpResponseMessage> Delete(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));

            var apiUrlDelHistorialPracticas = $"https://localhost:44300/api/HistorialPractica/{key}";
            var response = await client.DeleteAsync(apiUrlDelHistorialPracticas);

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
