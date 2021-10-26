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



    public bool isRaining = false;
    public bool isCold;
     */

    public int x = 5;
    public int y = 2;

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

        ReturnProducto(x,y);


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
        MovementToDirection(KeyCode.D, Vector3.right);
        MovementToDirection(KeyCode.A, Vector3.left);
        MovementToDirection(KeyCode.W, Vector3.forward);
        MovementToDirection(KeyCode.S, Vector3.back);
        MovementToDirection(KeyCode.E, Vector3.up);
        MovementToDirection(KeyCode.Q, Vector3.down);

        // Cambia la rotación
        RotationToDirection(KeyCode.RightArrow, new Vector3(0, 10, 0));
        RotationToDirection(KeyCode.LeftArrow, new Vector3(0, -10, 0));
        RotationToDirection(KeyCode.UpArrow, new Vector3(10, 0, 0));
        RotationToDirection(KeyCode.DownArrow, new Vector3(-10, 0, 0));

        // Cambia la escala
        ScaleToDirection(KeyCode.X, Vector3.right);
        ScaleToDirection(KeyCode.Y, Vector3.up);
        ScaleToDirection(KeyCode.Z, Vector3.forward);

    }


    public void HelloWorld()
    {
        Debug.Log("¡Hola, Mundo!");
    }

    public string GetHello()
    {
        return "¡Hola!";
    }

    public void MovementToDirection(KeyCode key, Vector3 direction)
    {
        if (Input.GetKeyDown(key))
        {
            transform.position += direction;
        }
    }

    public void ScaleToDirection(KeyCode key, Vector3 axis)
    {
        if (Input.GetKeyDown(key))
        {
            transform.localScale += axis;
        }
    }

    public void RotationToDirection(KeyCode key, Vector3 axis)
    {
        if (Input.GetKeyDown(key))
        {
            transform.rotation *= Quaternion.Euler(axis);
        }
    }


    public int ReturnProducto(int x, int y)
    {
        int result = x * y;
        Debug.Log($"{x} * {y} = {result}");

        return result;
    }

}
