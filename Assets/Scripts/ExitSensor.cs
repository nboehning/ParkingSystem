using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitSensor : Sensor {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Car")
        {
            Debug.Log("Car entered the parking spot");
            string plate = other.GetComponent<Car>().licensePlate;
            Customer customer = new Customer(plate);

            foreach (Customer cust in customers)
            {
                if (cust.Equals(customer))
                {
                    cust.TimeOut = DateTime.Now;
                    customers.Remove(cust);
                }
            }
        }
    }
}
