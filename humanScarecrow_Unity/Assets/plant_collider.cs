using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quitter : MonoBehaviour
{
<<<<<<<< HEAD:humanScarecrow_Unity/Assets/Quitter.cs
========
    public Transform player;
    public Transform collider;
>>>>>>>> Scarecrow:humanScarecrow_Unity/Assets/plant_collider.cs
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
    }

<<<<<<<< HEAD:humanScarecrow_Unity/Assets/Quitter.cs
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Untagged") {
            Application.Quit();
        }
========
     void OnMouseDown() {

        Debug.Log("Clicked on object!");
        Debug.Log("hello:" + player);
        player.position = transform.position;

>>>>>>>> Scarecrow:humanScarecrow_Unity/Assets/plant_collider.cs
    }
}
