using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public GameObject interactionMessage;
    public ReiniciarJuego objeto;
    // Start is called before the first frame update
    void Start()
    {
        interactionMessage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        Debug.Log(other.gameObject.name);
        objeto = other.GetComponent<ReiniciarJuego>(); //obtengo el script q esta en ese objeto q estoy colisionando, 
        if(objeto){
            interactionMessage.SetActive(true);

        }
    }
    private void OnTriggerExit(Collider other){
        interactionMessage.SetActive(false);
    }
}
