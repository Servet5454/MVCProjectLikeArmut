using Newtonsoft.Json;

namespace BideryaMvcProject.DataBase.IlIlceJson
{
    public class JasonSerilizear
    {
        
        public List<SehirJson> jsonSehirgetir()
        {
            var path = @"C:\Users\halic\source\Repos\BideryaMvcProject\BideryaMvcProject\wwwroot\lib\Json\il-bolge.json";
            var json = JsonConvert.DeserializeObject<List<SehirJson>>(File.ReadAllText(path));

            return json;
        }

        public List<IlIlceJson> jsonIlcegetir()
        {
            var path = @"C:\Users\halic\source\Repos\BideryaMvcProject\BideryaMvcProject\wwwroot\lib\Json\il-ilce.json";
            var json = JsonConvert.DeserializeObject<List<IlIlceJson>>(File.ReadAllText(path));

            return json;
        }
    }
}
