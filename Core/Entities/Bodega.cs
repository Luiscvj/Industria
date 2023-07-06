namespace Core.Entities;
public class Bodega{

    public int Id{get;set;}
    public string ? Nombre {get;set;}
    public long Id_responsable {get;set;}
    public User ? UserResponsable {get; set;}
    public short Estado {get; set;}
    public long Created_by {get;set;}
    public User ? UserCreated {get;set;}
    public long Updated_By {get;set;}
    public User ? UserUpdate {get;set;}
    public DateTime Created_at {get;set;}
    public DateTime  Updated_at {get;set;}
    public DateTime Deleted_at {get; set;}






}