using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puerta : MonoBehaviour
{
    public string texto;
    bool enCol = false;
    public bool decidido = false;
    public Text dialogo;
    public Animator animaCanvas;
    public Animator animaPuerta;
    public Animator animaPuerta2;

    // Start is called before the first frame update
    void Start()
    {
        dialogo.alignment = TextAnchor.MiddleCenter;
        dialogo.text = "Pulsa E para abrir.";
    }

    // Update is called once per frame
    void Update()
    {
        if(RecogePapeles.numeroFragmentos == 4)
        {
            decidido = true;
        }
        if (Input.GetKeyDown(KeyCode.E) && enCol)
        {
            dialogo.alignment = TextAnchor.UpperLeft;
            dialogo.text = texto;
            if (decidido)
            {
                dialogo.text = "Este no es mi hogar, debo marcharme.";
                animaPuerta.SetTrigger("Abre");
                animaPuerta2.SetTrigger("Abre");
            }
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
        dialogo.text = "Pulsa E para abrir.";
        dialogo.alignment = TextAnchor.MiddleCenter;
    }
}
