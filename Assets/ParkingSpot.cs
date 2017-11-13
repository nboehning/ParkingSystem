using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingSpot : MonoBehaviour
{

    public Light sensorLight;

	void OnTriggerEnter(Collider other)
    {
	    if (other.tag == "Car")
	    {
	        Debug.Log("Car entered the parking spot");
	        sensorLight.color = Color.red;
	    }
	    else if(other.tag != "Car")
	    {
	        Debug.Log("Something besides car entered");
	    }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Car")
        {
            Debug.Log("Car exited the parking spot");
            sensorLight.color = Color.green;
        }
        else if(other.tag != "Car")
        {
            Debug.Log("Something besides car exited");
        }
    }
}
