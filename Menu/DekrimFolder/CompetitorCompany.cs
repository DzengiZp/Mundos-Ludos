public class CompetitorCompany
{
    public string Name { get; set; }

    private static readonly string[] CompetitorNames = { "MickeyD", "VolvOh", "CluckinBell", "Maderna", "Farhoumands mäklarfirma" };

    public CompetitorCompany(string name)
    {
        Name = name;
    }

    public static string GetRandomCompetitorName()
    {
        Random rand = new Random();
        int index = rand.Next(CompetitorNames.Length);
        return CompetitorNames[index];
    }
}
