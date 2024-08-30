namespace pruebaBackend.WebApi.Command
{
    public record CreateCarCommand(int id, string description, int km, string model, int price, int brandId);
}
