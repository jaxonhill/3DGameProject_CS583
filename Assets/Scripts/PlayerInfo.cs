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

        // Always update hearts when new scene
        UpdateHearts();
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

    public void UpdateHearts()
    {
        for (int i = 3; i > 0; i--)
        {
            GameObject heartGO = GameObject.Find($"Heart{i}");
            if (i > StaticStats.Health)
            {
                heartGO.SetActive(false);
            }
            else
            {
                heartGO.SetActive(true);
            }
        }
    }
}
