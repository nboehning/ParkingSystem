using System;
using UnityEngine;

public class ExitSensor : Sensor
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Car")
        {
            string plate = GameObject.FindObjectOfType<Car>().licensePlate;
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
