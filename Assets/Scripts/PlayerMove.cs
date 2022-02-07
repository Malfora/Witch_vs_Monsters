using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMove : MonoBehaviour
{
    public Button LeftButton;
    public Button RightButton;

    public PlayerLeftMove LeftButtonOn;
    public PlayerRightMove RightButtonOn;


    public float ChangePositionX = 3;


    public Rigidbody Player;
    public float PlayerXposition = 0;
    public float PlayerSpeed;

    private void Update()
    {
        Player.velocity = new Vector3(Player.position.x, 0f, PlayerSpeed * Time.deltaTime);

        if (Player.transform.position.x >= 0 && LeftButtonOn == true)
        {
            PlayerXposition = PlayerXposition - ChangePositionX;
        }
        else if (Player.transform.position.x <= 0 && RightButtonOn == true)
        {
            PlayerXposition = PlayerXposition + ChangePositionX;
        }
        
        
    }

}
