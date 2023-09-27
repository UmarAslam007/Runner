using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public player01 payer;
    public ScoreManager scoreManager;
    public AudioSource BackGroundSound;
    public AudioSource DeathSound;
    public AudioSource ClickSound;


    private Vector3 PlayerStartingPoint;
    private Vector3 GroundGenrationStartPoint;

    public GroundGenerator groundGenerator;


    public GameObject LargeGround;
    public GameObject MedimGround;
    public GameObject SmallGround;

    public GameObject GameOverScreen;


    // Start is called before the first frame update
    void Start()
    {
        PlayerStartingPoint = payer.transform.position;
        GroundGenrationStartPoint = groundGenerator.transform.position;
        GameOverScreen.SetActive(false);
    }

   public void GameOver()
    {
        payer.gameObject.SetActive(false);
        GameOverScreen.SetActive(true);
        scoreManager.IsScroingIncrease = false;
        BackGroundSound.Stop();
        DeathSound.Play();


    }

    public void Quit()
    {
        if (DeathSound.isPlaying)
        {
            DeathSound.Stop();
        }
        ClickSound.Play();
        
        
        GroundDestructor[] groundDestructor = FindObjectsOfType<GroundDestructor>();
        for (int i = 0; i < groundDestructor.Length; i++)
        {
            groundDestructor[i].gameObject.SetActive(false);

        }
        SmallGround.SetActive(true);
        MedimGround.SetActive(true);
        LargeGround.SetActive(true);
        GameOverScreen.SetActive(false);
        payer.gameObject.SetActive(true);
        payer.transform.position = PlayerStartingPoint;
        groundGenerator.transform.position = GroundGenrationStartPoint;

        scoreManager.Score = 0;
        scoreManager.IsScroingIncrease = true;



        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

    public void Restart()
    {
        if (DeathSound.isPlaying)
        {
            DeathSound.Stop();
        }
        ClickSound.Play();

        GroundDestructor[] groundDestructor = FindObjectsOfType<GroundDestructor>();
        for(int i=0;i<groundDestructor.Length;i++)
        {
            groundDestructor[i].gameObject.SetActive(false);

        }
        SmallGround.SetActive(true);
        MedimGround.SetActive(true);
        LargeGround.SetActive(true);
        GameOverScreen.SetActive(false);
        payer.gameObject.SetActive(true);
        payer.transform.position = PlayerStartingPoint;
        groundGenerator.transform.position = GroundGenrationStartPoint;

        scoreManager.Score = 0;
        scoreManager.IsScroingIncrease = true;


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
