using MyLib.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using MyLib.Repositories.Interfaces;

namespace MyLib.Repositories
{
    public class RestAnimalIcadRepository : IAnimalIcadRepository
    {
        HttpClient client;
        string icad_url;

        public RestAnimalIcadRepository()
        {
            this.client = new();
            this.icad_url = Environment.GetEnvironmentVariable("URL_ICAD");
        }

        public Animal getAnimalParIdICAD(string IdICAD)
        {
            
            Task<HttpResponseMessage> response = client.GetAsync(this.icad_url);
            
            Animal animal = new(
                "",
                response.Result.ToString(),
                "",
                "",
                DateOnly.MinValue
                );
            

            return animal;
        }
    }
}
