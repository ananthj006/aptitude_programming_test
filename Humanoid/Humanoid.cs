namespace Humanoid
{
    public class Humanoid
    {
        private readonly ISkill _skill = null;
        public Humanoid(ISkill skill = null)
        {
            _skill = skill;
        }

        public string ShowSkill()
        {
            if (_skill == null)
            {
                return "no skill is defined";
            }

            return _skill.WriteSkill();
        }
    }
}
