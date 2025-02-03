namespace UtasszallitokCLI;

class Utassallito
{
    public string Tipus { get; set; }
    public int Ev { get; set; }
    private string UtasStr { get; set; }
    public (int? Min, int Max) Utas { get; set; }
    private string SzemelyzetStr { get; set; }
    public (int? Min, int Max) Szemelyet { get; set; }
    public int Utazosebesseg { get; set; }
    public int Felszallotomeg { get; set; }
    public float Fesztav { get; set; }
    public Sebessegkategoria Sebessegkategoria { get; set; }

    public override string ToString() =>
        $"\tTípus: {Tipus}\n" +
        $"\tElső felszállás: {Ev}\n" +
        $"\tUtasok száma: {UtasStr}\n" +
        $"\tSzemélyzet: {SzemelyzetStr}\n" +
        $"\tUtazósebesség: {Utazosebesseg} km/h";


    public Utassallito(string sor)
    {
        var tmp = sor.Split(';');
        Tipus = tmp[0];
        Ev = int.Parse(tmp[1]);
        UtasStr = tmp[2];
        Utas = TplConv(tmp[2]);
        SzemelyzetStr = tmp[3];
        Szemelyet = TplConv(tmp[3]);
        Utazosebesseg = int.Parse(tmp[4]);
        Felszallotomeg = int.Parse(tmp[5]);
        Fesztav = float.Parse(tmp[6]);
        Sebessegkategoria = new(Utazosebesseg);
    }

    private static (int?, int) TplConv(string str)
    {
        if (str.Contains('-'))
        {
            var tmp = str.Split('-');
            return (int.Parse(tmp[0]), int.Parse(tmp[1]));
        }
        else return (null, int.Parse(str));
    }
}
