using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Floor : MonoBehaviour
{
    [SerializeField] public string FloorName;
    private string TypeFloor;
    [SerializeField] public Text TextNameFloor;
    [SerializeField] public Button NormalMode;
    [SerializeField] public Button HardMode;
    [SerializeField] GameObject ChooseGameMode;

    public void Start()
    {
        NormalMode.onClick.AddListener(NormalModeGame);
        HardMode.onClick.AddListener(HardModeGame);
    }
    public void SelectFloor()
    {
        ChooseGameMode.SetActive(true);
        TextNameFloor.gameObject.SetActive(false);
    }
    public void MainMap()
    {
        SceneManager.LoadScene(FloorName);
        ShowOff();
    }
    public void NormalModeGame()
    {
        TypeFloor = "NORMAL";
        InitFloor();
    }

    public void HardModeGame()
    {
        TypeFloor = "HARD";
        InitFloor();
    }
    public void InitFloor()
    {
        SceneManager.LoadScene(FloorName);
        ShowOff();
        Invoke("InItLater", 2f);
    }

    void InItLater()
    {
        EnemyController en_ctrl = GameObject.FindGameObjectWithTag("EnemyController").GetComponent<EnemyController>();
        if (TypeFloor.Equals("HARD"))
        {

            en_ctrl.InitEnemy(true);
        }
        else
        {
            en_ctrl.InitEnemy(false);
        }
        
    }

    void ShowOff()
    {
        ChooseGameMode.SetActive(false);
        TextNameFloor.gameObject.SetActive(true);
        PopupController.instance.ShowOffSelectedFloor();
    }
}
