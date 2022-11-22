using System.ComponentModel.DataAnnotations;

namespace DbApi.Models
{
    public class Bonus
    {
        [Key]
        public string BonusName { get; set; }
        public int Level { get; set; }
        public override string ToString()
        {
            return $"bonusName: {BonusName};  level: {Level}";
        }
    }
}
