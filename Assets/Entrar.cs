using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Entrar : MonoBehaviour
{
   public GameObject luz;
    public Camera cam;


    public GameObject cajaObject;
    private Text caja;
    public GameObject pelotaObject;
    private Text pelota;
    // Start is called before the first frame update
    void Start()
    {
        luz.SetActive(false);
        
        

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 10))
        {


            if (hit.transform.CompareTag("ObstaCaja"))
            {
                cajaObject.SetActive(true);
                Debug.Log("Entro a cja");
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

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            luz.SetActive(true);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        luz.SetActive(false);
    }





}
