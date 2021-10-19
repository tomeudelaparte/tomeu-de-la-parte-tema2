using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
    
    private float playerSpeed = 5.25f;
    public string playerName = "Tomeu";
    [SerializeField] private bool gameOver;
    

    public float a = 5f;
    public float b = 2f;

    
    */

    public int playerAge = 35;

    public int x = 5;
    public int y = 2;

    public bool isRaining = false;
    public bool isCold;

    // Start is called before the first frame update
    void Start()
    {

        /*
        Debug.Log(x + y);
        Debug.Log(x - y);
        Debug.Log(x * y);
        Debug.Log(x / y);
        Debug.Log(x % y);

        Debug.Log($"Suma: {x} + {y} = {x + y}");
        Debug.Log("Resta: " + x + " - " + y + " = " + (x - y));
        Debug.Log(string.Format("Producto: {0} * {1} = {2}", x , y , x*y));
        Debug.Log(string.Format("Division: {0} / {1} = {2}", x , y , x/y));
        Debug.Log($"Resto: {x} % {y} = {x % y}");
        

        if (isRaining)
        {
            Debug.Log("Lleva paraguas.");
        }
        else
        {
            Debug.Log("No llueve. No lleves paraguas.");
        }

        if(playerAge >= 18)
        {
            Debug.Log("Eres mayor de edad");
        }
        else if(playerAge >= 13)
        {
            Debug.Log("Eres adolescente");
        }
        else
        {
            Debug.Log("Eres un niño");
        }
       

        if (x == 2 && y <= 5)
        {
            Debug.Log("01. Verdadero");
        }
        else
        {
            Debug.Log("01. Falso");
        }


        if (x == 2 || y <= 5)
        {
            Debug.Log("02. Verdadero");
        }
        else
        {
            Debug.Log("02. Falso");
        }

         */

        if (isRaining)
        {
            if (isCold)
            {
                Debug.Log("Lleva paraguas y sudadera");
            }
            else
            {
                Debug.Log("Lleva paraguas");
            }

        }
        else
        {
            if (isCold)
            {
                Debug.Log("Lleva una sudadera");
            }
            else
            {
                Debug.Log("Disfruta del día");
            }
        }



    }

    // Update is called once per frame
    void Update()
    {

    }
}
