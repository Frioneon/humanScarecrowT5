using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnMouseDown() {

        Debug.Log("Clicked on object!");
        Debug.Log("hello:" + player);
        player.transform.position = transform.position;

    }
}
