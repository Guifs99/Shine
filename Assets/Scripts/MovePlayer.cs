using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float velocidade;
    public float jumpforce;
    public Rigidbody2D rdb;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 newvel = new Vector2(Input.GetAxis("Horizontal") * velocidade, rdb.velocity.y);
        rdb.velocity= newvel;

        if (Input.GetButton("Jump"))
        {
            jumpforce = Mathf.Clamp(jumpforce, 0, 3);
            rdb.velocity = rdb.velocity + new Vector2(0, jumpforce);
            jumpforce = jumpforce - 0.1f;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpforce = 1;
    }
}
