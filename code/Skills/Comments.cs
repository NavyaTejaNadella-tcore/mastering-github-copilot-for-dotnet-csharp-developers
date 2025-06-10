// create a method that generates a comment for a given skill
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Skills
{
    public class Comments
    {
        public static string GenerateComment(string skillName, int skillLevel)
        {
            if (skillLevel < 1 || skillLevel > 5)
            {
                throw new ArgumentOutOfRangeException(nameof(skillLevel), "Skill level must be between 1 and 5.");
            }

            return $"The skill '{skillName}' is rated at level {skillLevel}.";
        }
    }
}