using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //Configuration Parameters
    [SerializeField] float screenWidthInUints = 16f;
    [SerializeField] float minX =1f;
    [SerializeField] float MaxX =15f;
    // cached refrences 
    GameStatus theGameStatus;
    Ball theBall;

    void Start()
    {
        theGameStatus = FindObjectOfType<GameStatus>();
        theBall=FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    { 
       Vector2 paddlePos = new Vector2 (transform.position.x, transform.position.y);
       paddlePos.x = Mathf.Clamp(GetXpos(), minX , MaxX);
       transform.position = paddlePos ;
    }

    private  float GetXpos()
    {
        if(theGameStatus.IsAutoPlayEnabled())
        {
            return theBall.transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * screenWidthInUints;
        }
    }
}
