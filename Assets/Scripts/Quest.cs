public class Quest
{
    public int currentAmountCollected;
    public int totalAmountNeeded;
    public string questTitle;

    public Quest(int totalAmountNeeded, string questTitle, int currentAmountCollected = 0)
    {
        this.currentAmountCollected = currentAmountCollected;
        this.totalAmountNeeded = totalAmountNeeded;
        this.questTitle = questTitle;
    }
}
