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
        Debug.Log("����� ������ ������");
        LeftButtonOn = true;
    }

    public void LeftButtonOff ()
    {
        Debug.Log("����� ������ ��������");
        LeftButtonOn = false;
    }


   /* public void LeftButtonClick()
    {
        if (Player.transform.position.x >= 0 && LeftButton.isActiveAndEnabled)
        {
            //Player.transform.position = new Vector3(transform.position.x + ChangePositionX, 0f, Player.position.z);
            Debug.Log("������ ����� ������");

            LeftButtonOn = true;
            

        }
        else
        {
            LeftButtonOn = false;
        }
        



    }*/
}
