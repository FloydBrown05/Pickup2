using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearScript : MonoBehaviour
{
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Make the object disappear by deactivating its renderer and collider
            GetComponent<Renderer>().enabled = false;
            GetComponent<Collider>().enabled = false;

            // You can also deactivate the entire GameObject if needed
            //gameObject.SetActive(false);
        }
    }
}
