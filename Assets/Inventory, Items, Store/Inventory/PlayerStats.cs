using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats Instance;

    public int Health;
    public int Gold; 

    public TMP_Text HealthText;
    public TMP_Text GoldText;

    private void Awake()
    {
        Instance = this;
    }

    public void IncreaseHealth(int value)
    {
        Health += value;
        HealthText.text = $"HP: {Health}";
    }

    public void ChangeGold(int value)
    {
        Gold += value;
        GoldText.text = $"Gold:{Gold}";
    }

}
