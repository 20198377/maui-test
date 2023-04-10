using Newtonsoft.Json;
using System.Reflection;

namespace phis_ievents_offline.Data;

public class RegistrantService
{
	public static Task<List<Registrant>> GetRegistrantsAsync()
	{
		var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"RemoteData\users.json");
        var streamReader = new StreamReader(path);
		var json = streamReader.ReadLine();
        return Task.FromResult(JsonConvert.DeserializeObject<List<Registrant>>(json));
	}
}

