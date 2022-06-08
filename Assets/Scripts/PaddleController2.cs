using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController2 : MonoBehaviour
{
    public int speed = 4;
    private Rigidbody2D rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // input 
        // Vector2 movement = getInput();
        // movement
        // moveObject(movement);
        moveObject(getInput());
          
    }
    public Vector2 getInput(){
         
        if(Input.GetKey(KeyCode.UpArrow)){
            // movement = new Vector2(0,1);
            return Vector2.up * speed;
        }
        else if(Input.GetKey(KeyCode.DownArrow)){
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }
    public void moveObject(Vector2 movement){
        rigid.velocity = movement;
    }
}
