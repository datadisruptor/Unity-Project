using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rigid;
    private float hastighet;
    private float moveHorizontal;
    private float moveVertical;

    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        hastighet= 3f;
    }


    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if(moveHorizontal > 0.1f || moveHorizontal < -0.1f)
        {
            rigid.AddForce(new Vector2(moveHorizontal*hastighet, 0f), ForceMode2D.Impulse);
        }
    }


    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }
}