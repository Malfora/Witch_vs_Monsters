using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerLeftMove : MonoBehaviour
{
    public Button LeftButton;
    public Rigidbody Player;

    

    public bool LeftButtonOn = false;

    public void LeftButtonClick ()
    {
        Debug.Log("Левая кнопка нажата");
        LeftButtonOn = true;
    }

    public void LeftButtonOff ()
    {
        Debug.Log("Левая кнопка отпущена");
        LeftButtonOn = false;
    }


   /* public void LeftButtonClick()
    {
        if (Player.transform.position.x >= 0 && LeftButton.isActiveAndEnabled)
        {
            //Player.transform.position = new Vector3(transform.position.x + ChangePositionX, 0f, Player.position.z);
            Debug.Log("нажата левая кнопка");

            LeftButtonOn = true;
            

        }
        else
        {
            LeftButtonOn = false;
        }
        



    }*/
}
