using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
   
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
           
            Destroy(gameObject);
        }
        else if (other.CompareTag("Animal"))
        {
            
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

    }
}
