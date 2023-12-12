using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    public string sceneName;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLLISION!");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player.");
            SceneManager.LoadScene(sceneName);
        }
    }
}
