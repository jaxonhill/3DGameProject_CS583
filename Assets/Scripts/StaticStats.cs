public static class StaticStats
{
    public static int Health = 15;
    public static Quest[] Quests = {
        new Quest("Go Through The First Rune"),
        new Quest("Parkour Out of the Room"),
        new Quest("Go Through The Second Rune"),
        new Quest("Defeat the Enemies and Escape the Room"),
        new Quest("Go Through the Final Rune"),
        new Quest("Defeat the Final Swarm"),
    };
    public static int currentQuestIndex = 0;
}
