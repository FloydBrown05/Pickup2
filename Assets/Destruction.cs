using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("DestructCol"))
        {
            Destroy(collision.gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("DestructTrig"))
        {
            Destroy(other.gameObject);
        }
    }
}
