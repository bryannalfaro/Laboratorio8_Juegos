using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Referencia: Clase en linea
 * Autor: Bryann Alfaro
 */
public class Entrar : MonoBehaviour
{
   public GameObject luz;
    public Camera camaraJuego;


    public GameObject cajaObject;
    
    public GameObject pelotaObject;
    
    // Start is called before the first frame update
    void Start()
    {
        luz.SetActive(false);
            

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
     * Compara en cada momento si hizo contacto con una caja o una pelota
     */
    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(camaraJuego.transform.position, camaraJuego.transform.forward, out hit, 10))
        {


            if (hit.transform.CompareTag("ObstaCaja"))
            {
                cajaObject.SetActive(true);
                Debug.Log("Entro a caja");
            }
            else if (hit.transform.CompareTag("ObstaPelota"))
            {
                cajaObject.SetActive(false);
                pelotaObject.SetActive(true);
            }
            else
            {
                cajaObject.SetActive(false);
                pelotaObject.SetActive(false);
            }


        };
    }

    /*
     * Cuando el player entra al espacio elegido
     */
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            luz.SetActive(true);
        }
        
    }
    /*
     * Cuando el jugador sale del espacio elegido
     */
    private void OnTriggerExit(Collider other)
    {
        luz.SetActive(false);
    }





}
