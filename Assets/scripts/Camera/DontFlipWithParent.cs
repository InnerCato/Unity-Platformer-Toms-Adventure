using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontFlipWithParent : MonoBehaviour
{
    PlayerCharacterController2D CC;
    [SerializeField]GameObject Player;

    private void Awake()
    {
        CC = Player.GetComponent<PlayerCharacterController2D>();
    }

    private void Update()
    {
        if (CC.IsFlipped == true)
        {
            Vector3 theScale = transform.localScale;
            theScale.x = -1;
            transform.localScale = theScale;
        }
        else {
            Vector3 theScale = transform.localScale;
            theScale.x = 1;
            transform.localScale = theScale;
        }
    }      
}
