using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] float baseLives = 3f;
    [SerializeField] int damage = 1;
    float lives;
    TextMeshProUGUI livesText;

    // Start is called before the first frame update
    void Start()
    {
        lives = baseLives - PlayerPrefsController.GetDifficulty();
        livesText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void TakeLife()
    {
        lives -= damage;
        UpdateDisplay();

        if(lives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
