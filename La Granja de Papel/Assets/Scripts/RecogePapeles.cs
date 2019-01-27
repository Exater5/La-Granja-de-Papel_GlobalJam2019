using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogePapeles : MonoBehaviour
{
    public static int numeroFragmentos = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 9;
        layerMask = ~layerMask;
        // Ray rayoAdelante = new Ray(transform.position, Vector3.forward);
        // Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * ray.distance, Color.yellow);
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1f, layerMask))
        {
            if (hit.collider.CompareTag("Carta"))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(hit.collider.gameObject);
                    ++numeroFragmentos;
                }
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.blue);
            }
           
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1f, Color.white);
        }
    }

}
