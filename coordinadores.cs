public class Coordinadores : Personas
{
    public list<string> areasAsignadas = new List<string>();
    private List<string> AreasAsignadas {get{return this.areasAsignadas;} set{this.areasAsignadas = value;}}

    public Coordinadores(string nombre, string dni, List<string> areasAsignadas) : base (nombre,dni)
    {
        AreasAsignadas = areasAsignadas;
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