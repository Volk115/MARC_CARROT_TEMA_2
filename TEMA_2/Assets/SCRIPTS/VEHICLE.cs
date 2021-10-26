using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VEHICLE : MonoBehaviour
{
    //La variable sound, guarda el sonido que hace el vihiculo
    [SerializeField] private string sound = "¡Brum, brum!";

    //Las variables guardan el name y numberWheels 
    [SerializeField] private string name = "name";
    [SerializeField] private int numberWheels = 4;

    //Esta variable guarda la nueva varieble hasSiren y comprueba el operador de decisiones
    public bool hasSiren;

    [SerializeField] private bool isOn = true;

    [SerializeField] private float gasoline;

    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log(message: $"{name} tiene {numberWheels} ruedas y hace {sound}");
        if (hasSiren == true)
        {
            Debug.Log(message: $"{name} tiene sirena");
        }
        else
        {
            Debug.Log(message: $"{name} no tiee sirena");
        }
        */

        //Dependiedo de si se detecta que los vehiculos estan encendidos, se avisara de su accion.
        //En caso de tener sirena, se avisara de que debe estar encendido para que funcione
        //El esle if es la comprobacion 1. El else es la segunda comprobacion

        if (isOn == true)
        {

            
            if (gasoline < 10)
            {
                Debug.Log(message: $"¡A {name} le queda poca gasolina!");
            }
            if (hasSiren == true)
            {
                Debug.Log(sound);
                
            }
            else
            {
                Debug.Log(message: $"{name} no tiene sirena");
            }

        }
        else
        {
            Debug.Log(message: $"{name} no está en marcha.");
        }

        /*
        else if (hasSiren == true)
        {
            Debug.Log(message: $"{name} hará {sound} cuando se ponga en marcha");
        }
        else
        {
            Debug.Log(message: $"{name} no está en marcha");
        }
        
        if (gasoline < 10 && isOn == true)
        {
            Debug.Log(message: $"¡A {name} le queda poca gasolina!");
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        


        if (isOn == true)
        { 
           if (Input.GetKeyDown(KeyCode.D))
           {
            transform.position += Vector3.right;

           }
           if (Input.GetKeyDown(KeyCode.A))
           {
            transform.position += Vector3.left;

           }
            if (Input.GetKeyDown(KeyCode.E))
            {
                transform.position += Vector3.up;

            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                transform.position += Vector3.down;

            }
            if (Input.GetKeyDown(KeyCode.W))
           {
            transform.position += Vector3.forward;

           }
           if (Input.GetKeyDown(KeyCode.S))
           {
            transform.position += Vector3.back;

           }
        }

    }
}
