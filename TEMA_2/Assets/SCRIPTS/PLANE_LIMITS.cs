using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLANE_LIMITS : MonoBehaviour
{
    private float limXPos = 50.0f;
    private float limXNeg = -50.0f;
    private float limZPos = 25.0f;
    private float limZNeg = -25.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(x: 0, y: 0.5, z: 0);

    }

    // Update is called once per frame
    void Update()
    {
    MoveGameObject(Vector3.right, KeyCode.RightArrow);
    MoveGameObject(Vector3.left, KeyCode.LeftArrow);
    MoveGameObject(Vector3.forward, KeyCode.UpArrow);
    MoveGameObject(Vector3.back, KeyCode.DownArrow);

        if (transform.position.x >= limXPos)
        {
            transform.position = new Vector3(limXPos, transform.position.x, transform.position.x);
        }

        if (transform.position.x <= -limXNeg)
        {
            transform.position = new Vector3(-limXNeg, transform.position.x, transform.position.x);
        }

        if (transform.position.y >= limZPos)
        {
            transform.position = new Vector3(-limZPos, transform.position.z, transform.position.z);
        }

        if (transform.position.y <= limZNeg)
        {
            transform.position = new Vector3(-limZNeg, transform.position.z, transform.position.z);
        }
    }
}
