public static class FactorySoldiers
{
    public static List<ISoldier> Create<T>(int numberOfSoldiers, int minAttackPower, int maxAttackPower, int minHp, int maxHp) where T : ISoldier
    {
        List<ISoldier> soldiers = new List<ISoldier>();
        Random random = new();

        for (int i = 0; i < numberOfSoldiers; i++)
        {
            int attackPower = random.Next(minAttackPower, maxAttackPower);
            int hp = random.Next(minHp, maxHp);
            soldiers.Add(new Soldier(attackPower, hp));
        }

        return soldiers;
    }
}
