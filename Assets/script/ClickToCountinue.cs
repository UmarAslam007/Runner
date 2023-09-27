using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToCountinue : MonoBehaviour
{
    public AudioSource ClickSound;
    public void ClickTocontinue()
    {
        ClickSound.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
  
}
