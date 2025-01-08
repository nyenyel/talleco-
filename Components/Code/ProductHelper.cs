using System.Text.Json;

public static class ProductHelper
{
    public static async Task<List<Product>> LoadProductAsync(string filePath)
    {
        string jsonContent = await File.ReadAllTextAsync(filePath);
        var products = JsonSerializer.Deserialize<List<Product>>(jsonContent, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        }) ?? throw new InvalidOperationException("Failed to read the file");
        
        return products;
    }
}