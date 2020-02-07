using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //[SerializeField]
    //public TextMeshProUGUI textWarning;

    [SerializeField]
    private TextMeshProUGUI textEnergy;

    [SerializeField]
    private TextMeshProUGUI textTimer;

    private int currentEnergy;
    private DateTime nextEnergyTime;
    private float minLeft;
    private float secLeft;
    private float secTotal;
    private bool check;

    private void Awake()
    {
        instance = this;
        //SaveManager.data.currentEnergy = 0;
        SaveManager.SaveProgress();
        SaveManager.LoadPlayer();
    }

    private void Start()
    {
       
        //SaveManager.LoadPlayer();
        //print(SaveManager.data.currentEnergy.ToString());
        //SaveManager.data.currentEnergy = 5;
        //SaveManager.SaveProgress();
    }
}
