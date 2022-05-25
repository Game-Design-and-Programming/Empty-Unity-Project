using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    /*
     * UI Functions:
     * - Display score
     * - Display health
     * - Respond to pause key (display resume button)
     * - Respond to resume button
     * - Maintain gameOver state (or get from GameController)
     * - Display play again button when game ends (gameOver becomes true)
     * - Reset UI when restarting game
     */

    public string healthLabel = "Health: ";
    public string scoreLabel = "Score: ";
    public int initialHealth;
    public int initialScore;
    public bool gameOver;

    public TextMeshProUGUI healthText;
    public TextMeshProUGUI scoreText;

    public KeyCode pauseKey = KeyCode.Pause;

    private int _health;
    private int _score;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        _health = initialHealth;
        _score = initialScore;
    }

    void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            PauseGame();
        }

        if (gameOver)
        {
            OfferNewGame();
        }
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

    private void PauseGame()
    {
        Debug.Log("PauseGame()");
    }

    private void OfferNewGame()
    {
        Debug.Log("OfferNewGame()");
    }
}
