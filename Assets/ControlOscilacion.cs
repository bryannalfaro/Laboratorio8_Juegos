using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlOscilacion : MonoBehaviour
{
    // Intensity Variables
    public bool changeIntensity = false;
    public float intensitySpeed = 1.0f;
    public float maxIntensity = 10.0f;
    public bool repeatIntensity = false;

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
        
        if (changeIntensity)
        {
            if (repeatIntensity)
            {
                myLight.intensity = Mathf.PingPong(Time.time * intensitySpeed, maxIntensity);
            }
            else
            {
                myLight.intensity = Time.time * intensitySpeed;
                if (myLight.intensity >= maxIntensity)
                {
                    changeIntensity = false;
                }
            }
        }

       
        }
    }
