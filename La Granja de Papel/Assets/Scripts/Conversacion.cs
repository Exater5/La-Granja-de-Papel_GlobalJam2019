using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversacion : MonoBehaviour
{
    public string texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider col)
    {
        Debug.Log("Hola Mundo");
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Pulsa E para interactuar");
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log(texto);
            }
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hola Mundo");
    }
}
