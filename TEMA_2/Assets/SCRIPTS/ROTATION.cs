using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTATION : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        //Se rotara el objeto el las cordenadas indicadas, tocando la tecla asignada
        RotateGameObject(KeyCode.RightArrow, rotation: new Vector3(x: 0, y: -10, z: 0));
        RotateGameObject(KeyCode.LeftArrow, rotation: new Vector3(x: 0, y: 10, z: 0));
        RotateGameObject(KeyCode.UpArrow, rotation: new Vector3(x: 10, y: 0, z: 0));
        RotateGameObject(KeyCode.DownArrow, rotation: new Vector3(x: -10, y: 0, z: 0));

    }

    public void RotateGameObject(KeyCode kcode, Vector3 rotation)
    {
        if (Input.GetKeyDown(kcode))
        {
            transform.rotation *= Quaternion.Euler(rotation);
        }


    }

}
