using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{

    public void OnPointerClick(PointerEventData eventData)
    {
        SelectionController.instance.GameObjectWasSelected = this.gameObject;
        SelectedIconController.instance.PositionSelected = this.gameObject;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("click");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("click");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //Debug.Log("click");
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("click");
    }
   
}
