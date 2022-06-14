using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 movement;
    public Vector2 reset;
    private Rigidbody2D rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = movement;
    }
    void Update()
    {
    }
    public void ResetBall() 
    {
        transform.position = new Vector3(reset.x, reset.y, 2);
    }
    public void ActivatePUSpeedUp(float magnitude){
        rigid.velocity *= magnitude;
    }
}
