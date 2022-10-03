try
{
    throw new Exception("Random exception");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}