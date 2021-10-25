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

    public int playerAge = 35;

    public int x = 5;
    public int y = 2;

    public bool isRaining = false;
    public bool isCold;
     */

    public Vector3 myPosition = new Vector3(2, 1, 3);
    public string hello;

    // Start is called before the first frame update
    void Start()
    {

        HelloWorld();
        hello = GetHello();
        Debug.Log(hello);

        //Debug.Log(GetHello());


        // myPosition = new Vector3(2, 1, 3);

        transform.position = myPosition;

        //transform.position = Vector3.zero;

        Debug.Log(transform.position);


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

        */



    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(transform.position);


        // Mueve la posición con las teclas WASD 
        if (Input.GetKeyDown(KeyCode.D))

        {
            transform.position += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.A))

        {
            transform.position += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.W))

        {
            transform.position += Vector3.forward;
        }

        if (Input.GetKeyDown(KeyCode.S))

        {
            transform.position += Vector3.back;
        }

        // Cambia la rotación
        if (Input.GetKeyDown(KeyCode.RightArrow))

        {
            transform.rotation *= Quaternion.Euler(0, 10, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))

        {
            transform.rotation *= Quaternion.Euler(0, -10, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))

        {
            transform.rotation *= Quaternion.Euler(10, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))

        {
            transform.rotation *= Quaternion.Euler(-10, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.localScale += Vector3.right;
        }



    }


    public void HelloWorld()
    {
        Debug.Log("¡Hola, Mundo!");
    }

    public string GetHello()
    {
        return "¡Hola!";
    }

    public void moveObject(KeyCode a, Vector3 b)
    {

        if (Input.GetKeyDown(a))

        {
            transform.position += b;
        }

    }

}
