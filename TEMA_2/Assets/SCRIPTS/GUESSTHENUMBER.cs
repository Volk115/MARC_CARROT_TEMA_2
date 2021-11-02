using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUESSTHENUMBER : MonoBehaviour
{
    private int randNum;
    private int playerNum;
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(1, 11);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            playerNum = int.Parse(GetComponent<InputField>().text);

            if (playerNum == randNum)
            {
                Debug.Log(message: "¡HAS ACERTADO!");
                Debug.Log(message: $"Intentos: {counter}");
                Destroy(gameObject);
                    
            }else if (playerNum > randNum)
            {
                Debug.Log(message: "Te has pasado.");
            }
            else
            {
                Debug.Log(message: "Te has quedado corto");
            }
            

            counter += 1;

        }
    }
}
