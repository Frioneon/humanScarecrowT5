using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isa_plant_collider : MonoBehaviour
{
    private Transform player;
    public plant plant_script;
    //public Transform collider;
    // Start is called before the first frame update\

    float horizontalInput;
    float verticalInput;

    
    void Start()
    {
        player = GameObject.FindWithTag("Scarecrow").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // if (Input.GetMouseButtonDown(1)) {
        //     Debug.Log("get here");
        //     // plant_script.clonePlant(horizontalInput, verticalInput);
        // }

    }

    void OnMouseOver() {

        if (Input.GetMouseButtonDown(1)) {
            Debug.Log("get here");
            plant_script.clonePlant(transform);
        }

        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("Clicked on object!");
            Debug.Log("hello:" + player);
            player.position = transform.position;
        }
        
        // if (Input.GetMouseButtonDown(1)) {
        //     Debug.Log("get here");
        //     plant_script.clonePlant(horizontalInput, verticalInput);
        // }

    }
}
