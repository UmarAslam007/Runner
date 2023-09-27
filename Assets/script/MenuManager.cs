using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuManager : MonoBehaviour
{
    public AudioSource ClickSound;
    public AudioSource BackGroundSound;
    public Slider slider;


    private GameObject ManegerScriptVoume;

    private void Start()
    {
        if(PlayerPrefs.HasKey("Vol"))
        {
            BackGroundSound.volume = ClickSound.volume = slider.value=PlayerPrefs.GetFloat("Vol");
        }
    }
    public void PlayGame()
    {
        ClickSound.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit()
    {
        ClickSound.Play();
        Application.Quit();
    }
    public void PlaySound()
    {
        ClickSound.Play();
    }
    public void Volume()
    {
        BackGroundSound.volume = slider.value;
        ClickSound.volume = slider.value;
        PlayerPrefs.SetFloat("Vol", slider.value);
    }

}
