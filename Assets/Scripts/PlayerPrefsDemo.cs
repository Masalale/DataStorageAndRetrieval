using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsDemo : MonoBehaviour
{
    public Text infoText;

    string playerName = "Chomba";
    int age = 25;
    float height = 170.18f;
    DateTime birthDate = new DateTime(2001, 10, 4);

    void Start()
    {
        playerName = PlayerPrefs.GetString("PlayerName", playerName);
        age = PlayerPrefs.GetInt("Age", age);
        height = PlayerPrefs.GetFloat("Height", height);
        
        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.SetInt("Age", age);
        PlayerPrefs.SetFloat("Height", height);
        PlayerPrefs.Save();
    }

    void Update()
    {
        ShowValues();
    }

    void ShowValues()
    {
        DateTime now = DateTime.Now;

        int years = now.Year - birthDate.Year;
        DateTime lastBirthday = new DateTime(now.Year, birthDate.Month, birthDate.Day);

        if (now < lastBirthday)
        {
            years = years - 1;
            lastBirthday = lastBirthday.AddYears(-1);
        }

        TimeSpan timeSince = now - lastBirthday;

        if (years != age)
        {
            age = years;
            PlayerPrefs.SetInt("Age", age);
            PlayerPrefs.Save();
        }

        infoText.text = "Name: " + playerName;
        infoText.text = infoText.text + "\nHeight: " + height;
        infoText.text = infoText.text + "\nAge: " + age + " years, " + timeSince.Days + " days, " + timeSince.Hours + " hours, " + timeSince.Minutes + " minutes, " + timeSince.Seconds + " seconds";
    }
}
