using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumber : MonoBehaviour
{
    private int randNum;
    private int myNum;
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(0, 11);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            myNum = int.Parse(GetComponent<InputField>().text);
            CompareToRandomNumber(myNum);
            counter++;
        }
    }

    public void CompareToRandomNumber(int myNum)
    {
        if (myNum > randNum)
        {
            Debug.Log("El n�mero que yo hab�a pensado es m�s peque�o");
        }

        if (myNum < randNum)
        {
            Debug.Log("El n�mero que yo hab�a pensado es m�s grande");
        }

        if (myNum == randNum)
        {
            Debug.Log($"�HAS ACERTADO! El n�mero que hab�a pensado era el {randNum}");

            Debug.Log($"Has utilizado {counter} intentos");
        }
    }
}
