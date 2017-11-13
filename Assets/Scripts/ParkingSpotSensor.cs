using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingSpotSensor : MonoBehaviour
{

	public Light sensorLight;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Car")
		{
			Debug.Log("Car entered the parking spot");
			sensorLight.color = Color.red;
			//string plate = other.GetComponent<Car>().lisencePlate;
			//Search customer DB for this license plate
			// If it exists
				// Do nothing
			// Else
				// Customer newCustomer = new Customer(Time.time, plate);
				// Add newCustomer to customer DB (base.addCustomer(newCustomer))
			
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
