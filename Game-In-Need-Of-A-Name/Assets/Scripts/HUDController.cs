using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUDController : MonoBehaviour
{
    public string healthLabel = "Health: ";
    public string scoreLabel = "Score: ";
    public int initialHealth;
    public int initialScore;

    public TextMeshProUGUI healthText;
    public TextMeshProUGUI scoreText;

    private int _health;
    private int _score;

    // Start is called before the first frame update
    void Start()
    {
        _health = initialHealth;
        _score = initialScore;
    }

    // Update is called once per frame
    public void UpdateHealth(int h)
    {
        _health += h;
        healthText.text = healthLabel + _health;
    }

    public void UpdateScore(int s)
    {
        _score += s;
        scoreText.text = scoreLabel + _score;
    }
}
