namespace ApiColaborativa.Entities;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = String.Empty;
    public decimal Precio { get; set; }
}