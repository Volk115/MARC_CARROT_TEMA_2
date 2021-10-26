using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBE : MonoBehaviour
{
    /*
    //PlayerAge guarda edad del jugador
    public int playerAge = 34;
    private float playerSpeed = 5.25f;
    [SerializeField] private bool gameOver;
    

    public int playerAge = 34;

    //Se utiliza para comprobar si el jugador 1 y el 2 se llaman igual o no dentro del juego
    public string playerName = "Marc";
    public string enemyName = "Marc ";

    [SerializeField] private int x = 5;
    [SerializeField] private int y = 3;
    [SerializeField] private int z = 3;
    
    //Si llueve, mandara el mensaje "llevate un paraguaas"
    [SerializeField] private bool isRaining;
    [SerializeField] private bool isCold;

    
    [SerializeField] private int playerHP = 10;
    

    public string playerName = "Volk";
    */
    // Start is called before the first frame update
    void Start()
    {
        //El player aparecera en la pocicion establecida (solo en el modo play)
        //transform.position = new Vector3(x: 0, y: 0, z: 0);
        /*
        transform.position = Vector3.zero;

        HelloWorld();
        HelloName("Marc");
        HelloName(playerName);
        Debug.Log(message: GetHellow());
        Debug.Log(message: $"{x} + {y} = {Suma(x.y)}");

        
        Debug.Log(playerAge);
        Debug.Log(message: $"Hola {playerName}!");
        */
        /*
        //Hay 4 formas de hacer sumas, restas, multiplicaciones y divisiones
        Debug.Log(message: $"Suma: {x} + {y} = {x + y}");
        Debug.Log(message: "Resta: " + (x - y).ToString());
        Debug.Log(message: string.Format("Producto: {0} * {1} = {2}", x, y, x * y));
        Debug.Log(message: string.Format("Division: {0} / {1} = {2}", x, y, x / y));
        Debug.Log(message: string.Format("Producto: {0} + {1} = {2}", x, y, x + y));
        Debug.Log(message: string.Format("Producto: {0} - {1} = {2}", x, y, x - y));
        

        //Se utiliza para comprobar si el jugador 1 y el 2 se llaman igual o no dentro del juego
        if (playerName == enemyName)
        {
            Debug.Log(message: "Player y enemigo se llaman igual");
        }

        if (playerName != enemyName)
        {
            Debug.Log(message: "Player y enemigo tienen distinto nombre");
        }


        if (playerHP > 0)
        {
            Debug.Log(message:"Sigues vivo");
        }
        else
        {
            Debug.Log("Estás muerto");
        }
        

        //Indica la edad en la que se encuentra el jugador segun el numero que indique su edad
        if (playerAge < 13)
        {
            Debug.Log(message: "Eres un niño");
        }
        else if (playerAge < 18)
        {
            Debug.Log(message: "Eres adolescente");
        }
        else
        {
            Debug.Log(message: "Eres adulto");
        }
        */
    }


    // Update is called once per frame
    // Update sirve para ver una actualizacion constante del comando
    void Update()
    {
        /*
        //los Quaterniales sirven para la rotacion
        //Local scale es para escalar al personaje
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localScale += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localScale -= Vector3.right;
        }
        

        //la clase Input, permite captar informacion por el teclado
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right;
            
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left;
            
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Vector3.up;
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += Vector3.down;
            
        }
        

        MoveGameObject(Vector3.right, KeyCode.D);
        MoveGameObject(Vector3.left, KeyCode.A);
        MoveGameObject(Vector3.up, KeyCode.E);
        MoveGameObject(Vector3.down, KeyCode.Q);
        MoveGameObject(Vector3.forward, KeyCode.W);
        MoveGameObject(Vector3.back, KeyCode.S);

        
        //Si llueve, mandara el mensaje "llevate un paraguaas"
        //Depende de si llueve o hace frio o ambas estan activadas, saldra la opcion 1 o la 2
        //HashSet comprueba si llueve, y en caso de llover, tambien se comprueba si hace frio
        if (isRaining == true)
        {
            
            if (isCold == true)
            {
                Debug.Log(message: "Lleva un paraguas y una sudadera");
            }
            else
            {
                Debug.Log(message: "lleva un paraguas");
            }
        }
        else
        {
            Debug.Log(message: "No llueve");
        }
        */

    }
    /*
    public void HelloWorld()
    {
        debug.Log(message: "¡Hola,mundo!");


    }

    public void GetHellow()
    {
        
    }

    public int Suma(int num1, int num2)
    {

    }
    
    public void MoveGameObject(Vector3 direction, KeyCode kCode)
    {
        if (Input.GetKeyDown(kCode))
        {
            transform.position += direction;
        }
    }
    */
}
