public class Coordinadores : Personas
{
    private List<string> areasAsignadas = new List<string>();
    public List<string> AreasAsignadas {get{return this.areasAsignadas;} set{this.areasAsignadas = value;}}

    private string voluntariosACargo;
    public string VoluntariosACargo {get{return this.voluntariosACargo;} set { this.voluntariosACargo = value;}}


    public Coordinadores(string nombre, string dni, List<string> areasAsignadas, int voluntariosACargo) : base (nombre,dni)
    {
        AreasAsignadas = areasAsignadas;
        VoluntariosACargo = voluntariosACargo;
    }
^

    public override void MostrarInformacion(List<string> areasAsignadas, int voluntariosACargo)
    {
        Console.WriteLine("El coordinador tiene asignadas las siguientes áreas:");
        for (int i = 0 ; i < areasAsignadas.Count ; i++)
        {
            Console.WriteLine(areasAsignadas[i]);
        }

        Console.WriteLine($"El coordinador tiene {voluntariosACargo} voluntarios a cargo.");

    }

}