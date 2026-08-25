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
    public class ProgramaEstudioController : ApiController
    {
        //GET
        private static readonly HttpClient client = new HttpClient();
        [HttpGet]
        public async Task<HttpResponseMessage> Get(DataSourceLoadOptions loadOptions)
        {
            var apiUrl = "https://localhost:44300/api/ProgramaEstudio";
            var respuestaJson = await GetAsync(apiUrl);
            List<ProgramaEstudio> listaProgramaE = JsonConvert.DeserializeObject<List<ProgramaEstudio>>(respuestaJson);
            return Request.CreateResponse(DataSourceLoader.Load(listaProgramaE, loadOptions));
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

            var url = "https://localhost:44300/api/ProgramaEstudio";
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

            var apiUrlGetProgramaEstudio = $"https://localhost:44300/api/ProgramaEstudio/{key}";
            var respuestaProgramaEstudio = await client.GetStringAsync(apiUrlGetProgramaEstudio);
            ProgramaEstudio programaEstudio = JsonConvert.DeserializeObject<ProgramaEstudio>(respuestaProgramaEstudio);

            JsonConvert.PopulateObject(values, programaEstudio);

            string jsonString = JsonConvert.SerializeObject(programaEstudio);
            var httpContent = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json");

            var url = $"https://localhost:44300/api/ProgramaEstudio/{key}";
            var response = await client.PutAsync(url, httpContent);

            var result = await response.Content.ReadAsStringAsync();
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        //DELETE
        [HttpDelete]
        public async Task<HttpResponseMessage> Delete(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));

            var apiUrlDelProgramaEstudio = $"https://localhost:44300/api/ProgramaEstudio/{key}";
            var response = await client.DeleteAsync(apiUrlDelProgramaEstudio);

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
