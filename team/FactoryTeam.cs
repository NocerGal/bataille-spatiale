public static class FactoryTeam
{
    public static Team Create(int numberOfSoldiers, string teamName, int minAttackPower, int maxAttackPower, int minHp, int maxHp, string battleCry)
    {
        List<ISoldier> soldiers = FactorySoldiers.Create(numberOfSoldiers, minAttackPower, maxAttackPower, minHp, maxHp);
        return new Team(teamName, soldiers, battleCry);
    }
}
