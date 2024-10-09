using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Cube adında bir GameObject referansı
    public GameObject Cube;
    public float speed = 1f;


    // Start is called before the first frame update
    void Start()
    {

            Cube.transform.position = new Vector3(6, 1, 0);  // Konumu değişti
      
    }

    // Update is called once per frame
    void Update()
    {
                float moveVertical = Input.GetAxis("Vertical");
                float moveHorizontal = Input.GetAxis("Horizontal");
        
                transform.position += new Vector3(moveHorizontal, moveVertical, 0 ) * speed * Time.deltaTime;


    }
}
