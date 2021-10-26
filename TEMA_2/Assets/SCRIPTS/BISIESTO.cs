using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BISIESTO : MonoBehaviour
{

    public int year = 2020;
    
    

    // Start is called before the first frame update
    void Start()
    {
        //Confirmamos que el a�o sera bisiesto o no
       
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            year = int.Parse(GetComponent<InputField>().text);
            SerBisiesto(year);

        }

    }

    public void SerBisiesto(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Debug.Log(message: $"El a�o {year} es bisiesto");
                }
                else
                {
                    Debug.Log(message: $"El a�o {year} NO es bisiesto");
                }
            }
            else
            {
                Debug.Log(message: $"El a�o {year} es bisiesto");
            }
        }
        else
        {
            Debug.Log(message: $"El a�o {year} NO es bisiesto");
        }
    }



}
