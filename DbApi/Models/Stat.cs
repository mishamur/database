using System.ComponentModel.DataAnnotations;

namespace DbApi.Models
{
    public class Stat
    {
        [Key]
        public int Id { get; set; }
        public int Hp { get; set; }
        public int MovespeedLevel { get; set; }
        public int DefenceLevel { get; set; }

        public override string ToString()
        {
            return $"id: {Id}; hp: {Hp}; movespeedLevel: {MovespeedLevel}; defenceLevel: {DefenceLevel}";
        }
    }
}
