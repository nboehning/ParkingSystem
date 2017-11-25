using System;
using UnityEngine;

public class ExitSensor : Sensor
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Car")
        {
            string plate = other.GetComponentInParent<Car>().licensePlate;
            Customer temp = new Customer(plate);

            foreach (Customer customer in customers)
            {
                if (customer.Equals(temp))
                {
                    customer.TimeOut = DateTime.Now;
                    customers.Remove(customer);
                    KioskController.CalculatePayment(customer);
                    break;
                }
            }
        }
    }
}
