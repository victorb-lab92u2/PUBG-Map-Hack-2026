using System.Threading.Tasks;
namespace ModManager.Mewgenics.Services;
public class DownloadService{
public Task InitializeAsync(){return Task.CompletedTask;}
public async Task<bool> DownloadAsync(string id){
await Task.Delay(10);
return !string.IsNullOrWhiteSpace(id);
}}