using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Referencia: Clase en linea y videos de youtube
Autor: Bryann Alfaro
 */
public class ControlOscilacion : MonoBehaviour
{
    // Variables
    public bool cambioIntensidad = false;
    public float velocidadOscilacion = 4.0f;
    public float intensidad = 10.0f;
    public bool repetir = false;

    public Light myLight;
    float startTime;

    // Use this for initialization
    void Start()
    {
        myLight = GetComponent<Light>();
        startTime = Time.time;
    }

    void Update()
    {
        
        if (cambioIntensidad)
        {
            if (repetir)
            {
                myLight.intensity = Mathf.PingPong(Time.time * velocidadOscilacion, intensidad);
            }
            else
            {
                myLight.intensity = Time.time * velocidadOscilacion;
                if (myLight.intensity >= intensidad)
                {
                    cambioIntensidad = false;
                }
            }
        }

       
        }
    }
