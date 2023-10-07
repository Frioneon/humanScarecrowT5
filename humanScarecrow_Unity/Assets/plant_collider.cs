using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant_collider : MonoBehaviour
{
    private Transform player;
    //public Transform collider;
    // Start is called before the first frame update
    
    void Start()
    {
        player = GameObject.FindWithTag("Scarecrow").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
    }

     void OnMouseDown() {

        Debug.Log("Clicked on object!");
        Debug.Log("hello:" + player);
        player.position = transform.position;

    }
}
