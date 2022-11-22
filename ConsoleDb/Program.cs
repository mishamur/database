using System;
using DbApi;
public class Program
{
    public static void Main(string[] args)
    {
        
        DbApi.Api.LoadBonus("hui20sm", 10);
        var bonus = Api.GetBonusByName("hui20sm");
        Console.WriteLine(bonus);

        DbApi.Api.LoadProjectile("bombaVsemPizda", 228);
        var projectile = Api.GetProjectileByName("bombaVsemPizda");
        Console.WriteLine(projectile);

        DbApi.Api.LoadStat(228, 1337, 1488);
        var stat = Api.GetStat();
        Console.WriteLine(stat);
    }
}