using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollect : MonoBehaviour
{
    public GameObject explodeEff;

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Instantiate(explodeEff, transform.position, transform.rotation);
            GameManager.instance.addscore(10);
            Destroy(gameObject);
        }
    }
}