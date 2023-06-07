using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public float Life = 100;
    public Image LifeBar;

    void Update()
    {
        Life = Mathf.Clamp(Life, 0, 100);

        LifeBar.fillAmount = Life / 100;
    }
}
