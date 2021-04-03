namespace API.Entities
{
    public class AppUser
    {
        //Se reconoce Id porque la base de datos lo reconocera como la llave primaria
        public int Id {get; set;}
    
    //Public es que cada entitie puede ser accedida de cualquier otra clase
        public string UserName {get; set;}
        
    }
}