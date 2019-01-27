using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalera : MonoBehaviour
{
    public Transform trArriba;
    Transform trPlayer;
    GameObject player;
   
   bool subeEscalera = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(subeEscalera == true)
        {
            trPlayer.position = Vector3.MoveTowards(trPlayer.position, trArriba.position, 0.1f);
        }
        
    }
    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Ey");
            trPlayer = col.gameObject.transform;
            player = col.gameObject;
            if (Input.GetKeyDown(KeyCode.E))
            {
                
                subeEscalera = true;
            }
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        subeEscalera = false;
    }
}
