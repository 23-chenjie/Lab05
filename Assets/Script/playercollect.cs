using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollect : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            GameManager.instance.addscore(10);
            Destroy(gameObject);
        }
    }
}