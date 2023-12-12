using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public int health = 3;
    public Quest[] quests = { new Quest(3, "Collect 3 Melons"), new Quest(1, "Find the Exit"), new Quest(1, "Defeat the Boss") };
    private Quest currQuest;

    private void Awake()
    {
        // Set current quest to the first quest when the game launches
        currQuest = quests[0];
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
