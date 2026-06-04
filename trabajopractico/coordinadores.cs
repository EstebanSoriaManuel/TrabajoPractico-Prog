public class Coordinadores : Personas
{
    private List<string> areasAsignadas = new List<string>();
    public List<string> AreasAsignadas {get{return this.areasAsignadas;} set{this.areasAsignadas = value;}}

    private int voluntariosACargo;
    public int VoluntariosACargo {get{return this.voluntariosACargo;} set { this.voluntariosACargo = value;}}


    public Coordinadores(string nombre, string dni, List<string> areasAsignadas, int voluntariosACargo) : base(nombre, dni)
    {
        AreasAsignadas = areasAsignadas;
        VoluntariosACargo = voluntariosACargo;
    }


    public override void MostrarInformacion()
    {
        Console.WriteLine($"Coordinador: {Nombre}, DNI: {Dni}");
        Console.WriteLine("El coordinador tiene asignadas las siguientes áreas:");
        for (int i = 0; i < AreasAsignadas.Count; i++)
        {
            Console.WriteLine(AreasAsignadas[i]);
        }

        Console.WriteLine($"El coordinador tiene {VoluntariosACargo} voluntarios a cargo.");
    }

}