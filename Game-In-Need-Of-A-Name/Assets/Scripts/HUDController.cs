using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUDController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: 42";
        healthText.text = "Health: 3";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
