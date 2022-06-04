using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morte : MonoBehaviour
{

    public GameObject implosion;
    public int life = 1;
    public GameObject SpawnPoint;
    private void OnParticleCollision(GameObject other)
    {
        life--;

        if (life < 0)
        {
            Instantiate(implosion, transform.position, Quaternion.identity);
            //Destroy(gameObject);//
            if(SpawnPoint){
                transform.position=SpawnPoint.transform.position;
            }else{
                Destroy(gameObject);
            }
        }
    }
}
