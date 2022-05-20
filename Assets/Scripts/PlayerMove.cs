using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController characterController;
    public float Speed = 2;
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      Vector3 move=new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
       characterController.SimpleMove(move * Speed);
       move = transform.TransformDirection(move);
       characterController.SimpleMove(move*Speed);

    }

     void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawLine(ray.origin, hit.point);
            Vector3 dir = hit.point - transform.position;
            dir = new Vector3(dir.x, 0, dir.z);
            transform.forward = dir;
        }
    }
}
