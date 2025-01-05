using System.Diagnostics;
using System.Text.Json;

public class JsonFileService
{
    private readonly string _basePath;

    public JsonFileService()
    {
        _basePath = @"D:\Application Development\Trackify\Data\";// Or specify another directory
        Debug.WriteLine(_basePath);
    }

    public async Task<List<T>> ReadAsync<T>(string fileName)
    {
        string path = Path.Combine(_basePath, fileName);

        if (!File.Exists(path))
        {
            return new List<T>();
        }

        string json = await File.ReadAllTextAsync(path);
        return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
    }

    public async Task WriteAsync<T>(string fileName, List<T> data)
    {
        string path = Path.Combine(_basePath, fileName);

        string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        await File.WriteAllTextAsync(path, json);
    }
}