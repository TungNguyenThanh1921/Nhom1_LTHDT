using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionController : MonoBehaviour
{
    [SerializeField] EnemySelected EnemySelection;
    [SerializeField] NPCSelected NPCSelection;
    [HideInInspector] public GameObject GameObjectWasSelected;
    public static SelectionController instance;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        CheckSelection();
    }
    private void CheckSelection()
    {
        if(GameObjectWasSelected != null && GameObjectWasSelected.CompareTag("NPC"))
        {
            NPCSelection.gameObject.SetActive(true);
            NPC _selected = GameObjectWasSelected.GetComponent<NPC>();
            NPCSelection.InitInfo(_selected.Name, _selected.level.ToString());
        }
        else if (GameObjectWasSelected != null && GameObjectWasSelected.CompareTag("Enemy"))
        {
            EnemySelection.gameObject.SetActive(true);
            Enemy _selected = GameObjectWasSelected.GetComponent<Enemy>();
            EnemySelection.Enemy = _selected;
        }    
    }    
    public void ShowOffSelection()
    {
        GameObjectWasSelected = null;
        SelectedIconController.instance.PositionSelected = null;
        if (EnemySelection.gameObject != null)
        {
            EnemySelection.gameObject.SetActive(false);
        }
    }
}
