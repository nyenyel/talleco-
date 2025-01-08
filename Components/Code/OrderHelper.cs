using System.Text.Json;

public static class OrderHelper
{
    public static async Task<List<Order>> LoadOrderAsync(string filePath)
    {
        string jsonContent = await File.ReadAllTextAsync(filePath);
        var order = JsonSerializer.Deserialize<List<Order>>(jsonContent, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        }) ?? throw new InvalidOperationException("Failed to read the file");
        return order;
    }
}