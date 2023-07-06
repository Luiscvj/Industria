namespace Core.Entities;

public class User{
    public int Id {get; set;}
    public string ? Nombre {get;set;}
    public string ? Email {get;set;}
    public DateTime Estado {get;set;}
    public long Created_By {get;set;}
    public long Updated_By {get;set;}
    public string ? Foto {get;set;}
    public string ? Password {get;set;}
    public DateTime Created_At {get;set;}
    public DateTime Updated_At {get;set;}
    public DateTime Deleted_At {get;set;}

    
}