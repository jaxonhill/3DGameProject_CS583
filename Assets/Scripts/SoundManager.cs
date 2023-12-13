using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource effectSource;

    public AudioClip theme1;
    public AudioClip dash;
    public AudioClip sword;
    public AudioClip damage;
    public AudioClip ui;
    public AudioClip[] footsteps;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = theme1;
        musicSource.Play();
        musicSource.volume = 0.50f;
    }

    public void PlayDashSound()
    {
        effectSource.PlayOneShot(dash);
    }

    public void PlaySwordSound()
    {
        effectSource.PlayOneShot(sword);
    }

    public void PlayDamageSound()
    {
        effectSource.PlayOneShot(damage);
    }

    public void PlayUISound()
    {
        effectSource.PlayOneShot(ui);
    }
}
