using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public Vector2 movement;
    private Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = movement;
    }
    // Update is called once per frame
    void Update()
    {
        
        // transform.position = transform.position + (new Vector3(1f,0,0) * Time.deltaTime );
        // transform.Translate(movement* Time.deltaTime);
        
    }
}
