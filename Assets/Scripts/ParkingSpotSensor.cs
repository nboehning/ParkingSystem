using UnityEngine;

public class ParkingSpotSensor : Sensor
{

    public Light sensorLight;
    public int level;

    private bool isTriggered = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Car" && !isTriggered)
        {
            isTriggered = true;
            sensorLight.color = Color.red;
            string plate = GameObject.FindObjectOfType<Car>().licensePlate;
            Customer customer = new Customer(plate);

            if (!customers.Contains(customer))
            {
                customers.Add(customer);
            }

            ParkingGarage.Park(level);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Car" && isTriggered)
        {
            isTriggered = false;
            sensorLight.color = Color.green;
            ParkingGarage.Exit(level);
        }
    }
}
