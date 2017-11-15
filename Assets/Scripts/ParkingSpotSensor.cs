using System;
using UnityEngine;

public class ParkingSpotSensor : Sensor
{

	public Light sensorLight;
    public int level;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Car")
		{
			Debug.Log("Car entered the parking spot");
			sensorLight.color = Color.red;
			string plate = other.GetComponent<Car>().licensePlate;
            Customer customer = new Customer(plate);

            if (!customers.Contains(customer))
            {
                customers.Add(customer);
                ParkingGarage.Park(level);
            }
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Car")
		{
			Debug.Log("Car exited the parking spot");
			sensorLight.color = Color.green;
            ParkingGarage.Exit(level);
		}
	}
}
