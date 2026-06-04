public abstract class Personas
{
    private string nombre;
    private string dni;

    public string Nombre {get{return this.nombre;} set { this.nombre = value;}}
    public string Dni {get{return this.dni;} set { this.dni = value;}}

    public Personas(string nombre, string dni)
    {
        Nombre = nombre;
        Dni = dni;
    }

    public abstract void MostrarInformacion();
}