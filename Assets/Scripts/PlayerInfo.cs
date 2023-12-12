using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerInfo : MonoBehaviour
{
    public int health;
    public Quest[] quests = { new Quest("Defeat the Enemies and Escape the Room"), new Quest("Defeat the Boss") };
    public TextMeshProUGUI gt;
    private int currQuestIndex;

    private void Awake()
    {
        // Set current quest to the first quest when the game launches
        currQuestIndex = 0;
        health = 3;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Get the text object
        GameObject questGO = GameObject.Find("CurrQuest");
        // Get a reference to the actual textmesh
        gt = questGO.GetComponent<TextMeshProUGUI>();
        SetQuestText();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SetQuestText()
    {
        // Set the text to the quest title
        gt.text = quests[currQuestIndex].questTitle;
    }

    void DecrementHealth()
    {
        // Game over is health == 1 because we are going to decrement to 0 anyway
        if (health == 1)
        {
            // Do Game Over
            SceneManager.LoadScene("_StartMenu");
        }

        GameObject heartImage = GameObject.Find($"Heart{health}");
        Image img = heartImage.GetComponent<Image>();
        img.enabled = false;
        health--;
    }
}
