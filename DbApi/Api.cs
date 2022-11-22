using System;
using DbApi.Models;

namespace DbApi
{
    public class Api
    {
        public static void LoadBonus(string bonusName, int level)
        {
            Bonus bonus = new Bonus { BonusName = bonusName, Level = level };
            using(ApplicationContext db = new ApplicationContext())
            {
                if(db.Bonuses.Find(bonusName) != null)
                {
                    db.Bonuses.Update(bonus);
                }
                else
                {
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
            Projectile projectile = new Projectile { ProjectileName = projectileName, Level = level};
            using (ApplicationContext db = new ApplicationContext())
            {
                if (db.Projectiles.Find(projectileName) != null)
                {
                    db.Projectiles.Update(projectile);
                }
                else
                {
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
            Stat stat = new Stat { Id = id, DefenceLevel = defenceLevel, Hp = hp, MovespeedLevel = movespeedLevel };

            using(ApplicationContext db = new ApplicationContext())
            {
                if (db.Stats.Find(id) != null)
                {
                    db.Stats.Update(stat);
                }
                else
                {
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
