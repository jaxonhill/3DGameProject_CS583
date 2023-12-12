using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerInfo : MonoBehaviour
{
    public TextMeshProUGUI gt;

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
        gt.text = StaticStats.Quests[StaticStats.currentQuestIndex].questTitle;
    }

    void DecrementHealth()
    {
        // Game over is health == 1 because we are going to decrement to 0 anyway
        if (StaticStats.Health == 1)
        {
            // Do Game Over
            SceneManager.LoadScene("_StartMenu");
        }

        GameObject heartImage = GameObject.Find($"Heart{StaticStats.Health}");
        heartImage.SetActive(false);
        StaticStats.Health--;
    }
}
