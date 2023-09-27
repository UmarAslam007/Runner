using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public float PointPerSecond;
    public Text ScoreText;
    public Text HiScoreText;

    public float Score;
    private float HiScore;


    public bool IsScroingIncrease;

    // Start is called before the first frame update
    void Start()
    {
        IsScroingIncrease = true;
        if (PlayerPrefs.HasKey("hiScore"))
            HiScore = PlayerPrefs.GetFloat("hiScore");
    }

    // Update is called once per frame
    void Update()
    {
        if(IsScroingIncrease)
             Score += PointPerSecond * Time.deltaTime;

        if(Score>HiScore)
        {
            HiScore = Score;
            PlayerPrefs.SetFloat("hiScore", HiScore);
        }

        ScoreText.text = Mathf.Round(Score).ToString();
        HiScoreText.text = Mathf.Round(HiScore).ToString();
    }
}
