using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarsDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    TextMeshProUGUI starText;

    // Start is called before the first frame update
    void Start()
    {
        starText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public bool HaveEnoughStars(int amount)
    {
        return stars >= amount;
    }

    public void AddStarts(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }

    public void SpendStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
    }
}
