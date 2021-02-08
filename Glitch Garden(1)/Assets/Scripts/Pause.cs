using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private void OnMouseDown()
    {
        Time.timeScale = 0;
    }
}
