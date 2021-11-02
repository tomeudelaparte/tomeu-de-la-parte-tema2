using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bisiesto : MonoBehaviour
{
    public int year = 2016;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            year = int.Parse(GetComponent<InputField>().text);
            isBisiesto(year);
        }
    }

    public void isBisiesto(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Debug.Log($"El a�o {year} es bisiesto");
                }
                else
                {
                    Debug.Log($"El a�o {year} NO es bisiesto");
                }
            }
            else
            {
                Debug.Log($"El a�o {year} es bisiesto");
            }
        }
        else
        {
            Debug.Log($"El a�o {year} NO es bisiesto");
        }
    }
}
