using System.Collections;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text clicksText;
    public static int clicks;

    private void Start()
    {
        load();
        InvokeRepeating("Save", 3f, 3f);
    }

    private void Update()
    {
        clicksText.text = clicks.ToString();

    }

    void save()
    {
        PlayerPrefs.SetInt("clicks", clicks);
    }

    void load()
    {
        clicks = PlayerPrefs.GetInt("clicks");
    }

    private void OnApplicationQuit()
    {
        save();
    }
}
