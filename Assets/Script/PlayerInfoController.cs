using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoController : MonoBehaviour
{
    [SerializeField] Button OpenInfoPlayerBtn;
    [SerializeField] Button OffInfoPlayerBtn;
    [SerializeField] Text NamePlayerTxt;
    [SerializeField] Text LevelPlayerTxt;
    [SerializeField] Text ExpPlayerTxt;
    [SerializeField] Text MoneyPlayerTxt;
    [SerializeField] Text HPPlayerTxt;
    [SerializeField] Text MPPlayerTxt;
    [SerializeField] Text ATKPlayerTxt;
    [SerializeField] Text DEFPlayerTxt;
    [SerializeField] GameObject PopupPlayerDie;

    // Info Player When in GamePlay
    [SerializeField] Text LevelTxt;
    [SerializeField] Text HPTxt;
    [SerializeField] Text MPTxt;

    [SerializeField] GameObject InfoTable;

    public static PlayerInfoController instance;
    void Start()
    {
        if (instance == null)
            instance = this;
        OpenInfoPlayerBtn.onClick.AddListener(ShowInfoPlayerPanel);
        OffInfoPlayerBtn.onClick.AddListener(ShowOffInfoPlayerPanel);
        InfoTable.gameObject.SetActive(false);
    }
    void ControllInfoPlayerWhenInGamePlay()
    {
        LevelTxt.text = Player.instance.Level.ToString();
        HPTxt.text =  Player.instance.HPCurrent.ToString() + " / " + Player.instance.HP.ToString();
        MPTxt.text =  Player.instance.MPCurrent.ToString() + " / " + Player.instance.MP.ToString();
    }
    private void Update()
    {
        ControllInfoPlayerWhenInGamePlay();
    }
    public void ShowInfoPlayerPanel()
    {
        InitInfoPlayer();
        InfoTable.gameObject.SetActive(true);
    }
    public void ShowOffInfoPlayerPanel()
    {
        InfoTable.gameObject.SetActive(false);
    }
    public void InitInfoPlayer()
    {
        NamePlayerTxt.text = Player.instance.Name;
        LevelPlayerTxt.text = Player.instance.Level.ToString();
        ExpPlayerTxt.text = Player.instance.Exp.ToString();
        MoneyPlayerTxt.text = Player.instance.Money.ToString();
        HPPlayerTxt.text = Player.instance.HP.ToString();
        MPPlayerTxt.text = Player.instance.MP.ToString();
        ATKPlayerTxt.text = Player.instance.ATK.ToString();
        DEFPlayerTxt.text = Player.instance.DEF.ToString();
    }    
    
}
