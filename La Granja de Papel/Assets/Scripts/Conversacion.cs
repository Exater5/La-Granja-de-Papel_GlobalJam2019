using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversacion : MonoBehaviour
{
    public string texto;
    bool enCol = false;
    public Text dialogo;
    public Animator animaCanvas;
    // Start is called before the first frame update
    void Start()
    {
        dialogo.alignment = TextAnchor.MiddleCenter;
        dialogo.text = "Pulsa E para hablar.";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&&enCol)
        {
            dialogo.alignment = TextAnchor.UpperLeft;
            dialogo.text = texto;
        }
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            animaCanvas.SetTrigger("Aparece");
            enCol = true;
        }
    }
    public void OnTriggerExit(Collider col)
    {
        enCol = false;
        animaCanvas.SetTrigger("Desaparece");
        Invoke("RenuevaTexto", 0.5f);
    }
    void RenuevaTexto()
    {
        dialogo.text = "Pulsa E para hablar.";
        dialogo.alignment = TextAnchor.MiddleCenter;
    }
}
