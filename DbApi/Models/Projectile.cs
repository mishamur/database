using System.ComponentModel.DataAnnotations;

namespace DbApi.Models
{
    public class Projectile
    {
        [Key]
        public string ProjectileName { get; set; }
        public int Level { get; set; }

        public override string ToString()
        {
            return $"projectilename: {ProjectileName};  level: {Level}";
        }
    }
}
