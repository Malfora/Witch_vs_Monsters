using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class PlayerRightMove : MonoBehaviour
{
    public Button RightButton;
    public Rigidbody Player;

    public bool RightButtonOn = false;

    public void RightButtonClick(PointerEventData eventData)
    {
        Debug.Log("Правая кнопка нажата");
        RightButtonOn = true;
    }

    public void RightButtonOff(PointerEventData eventData)
    {
        Debug.Log("Правая кнопка отпущена");
        RightButtonOn = false;
    }


    /*public void OnRightClick()
    {
        if (Player.transform.position.x <= 0)
        {
            Player.transform.position = new Vector3(transform.position.x + ChangePositionRightX, 0f, Player.position.z);
        }
    }*/

}
