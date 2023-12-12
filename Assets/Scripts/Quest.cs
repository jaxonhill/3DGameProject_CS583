public class Quest
{
    public string questTitle;
    public bool isCompleted;

    public Quest(string questTitle, bool isCompleted = false)
    {
        this.questTitle = questTitle;
        this.isCompleted = isCompleted;
    }
}
