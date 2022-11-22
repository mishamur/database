using System;
using DbApi.Models;

namespace DbApi
{
    public class Api
    {
        public static void LoadBonus(string bonusName, int level)
        {
            Bonus bonus = null;
            using (ApplicationContext db = new ApplicationContext())
            {
                if((bonus = db.Bonuses.Find(bonusName)) != null)
                {
                    bonus.Level = level;
                    db.Bonuses.Update(bonus);
                }
                else
                {
                    bonus = new Bonus { BonusName = bonusName, Level = level };
                    db.Bonuses.Add(bonus);
                }
                db.SaveChanges();
            }
        }

        public static Bonus GetBonusByName(string bonusName)
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                return db.Bonuses.Find(bonusName);
            }
        }

        public static void LoadProjectile(string projectileName, int level)
        {
            Projectile projectile = null;
            using (ApplicationContext db = new ApplicationContext())
            {
                if ((projectile = db.Projectiles.Find(projectileName)) != null)
                {
                    projectile.Level = level;
                    db.Projectiles.Update(projectile);
                }
                else
                {
                    projectile = new Projectile { ProjectileName = projectileName, Level = level };
                    db.Projectiles.Add(projectile);
                }
                db.SaveChanges();
            }
        }
        public static Projectile GetProjectileByName(string projectileName)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Projectiles.Find(projectileName);
            }
        }

        public static void LoadStat(int hp, int movespeedLevel, int defenceLevel)
        {
            int id = 1;
            Stat stat = null;
            using (ApplicationContext db = new ApplicationContext())
            {

                if ((stat = db.Stats.Find(id)) != null)
                {
                    stat.Hp = hp;
                    stat.MovespeedLevel = movespeedLevel;
                    stat.DefenceLevel = defenceLevel;

                    db.Stats.Update(stat);
                }
                else
                {
                    stat = new Stat { Id = id, DefenceLevel = defenceLevel, Hp = hp, MovespeedLevel = movespeedLevel };

                    db.Stats.Add(stat);
                }
                db.SaveChanges();
            }
        }

        public static Stat GetStat()
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                int id = 1;
                return db.Stats.Find(id);
            }
        }
    }
}
