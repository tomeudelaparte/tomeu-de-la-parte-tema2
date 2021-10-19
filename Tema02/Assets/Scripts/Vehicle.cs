using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    // Variable que guarda el sonido del vehiculo
    [SerializeField] private string sound = "¡Brum, brum!";

    // Guarda el nombre del vehículo
    [SerializeField] private string name;

    // Guarda el número de ruedas que tiene
    [SerializeField] private int numberWheels = 4;

    // Guarda el valor de si tiene sirena
    [SerializeField] private bool hasSiren;

    [SerializeField] private bool isOn = true;

    [SerializeField] private float gasoline;



    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log($"{name} tiene {numberWheels} ruedas y hace {sound}.");

        // Comprueba si el vehiculo tiene sirena
        if (hasSiren)
        {
            Debug.Log($"{name} tiene sirena.");
        }
        else
        {
            Debug.Log($"{name} NO tiene sirena.");
        }
        

        if (isOn)
        {
            Debug.Log(sound);
        }
        else if (hasSiren)
        {
            Debug.Log($"{name} hará {sound} cuando se ponga en marcha");
        }
        else
        {
            Debug.Log($"{name} no está en marcha");
        }
        */


        if (isOn)
        {
            if (gasoline < 10)
            {
                Debug.Log($"¡A {name} le queda poca gasolina!");
            }

            if (hasSiren)
            {
                Debug.Log(sound);
            }
            else
            {
                Debug.Log($"{name} no tiene sirena");
            }
        }
        else
        {
            Debug.Log($"{name} no está en marcha");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
