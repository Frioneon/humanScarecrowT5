using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isa_plant_collider : MonoBehaviour
{
    private Transform player;
    public plant plant_script;
    //public Transform collider;
    // Start is called before the first frame update\
    public bool full = false;
    public Transform plant;
    public PauseMenu pauseMenuUI;
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
        if (full) {
            GetComponentInChildren<SpriteRenderer>().color = new Color(0.1f,0.8f,0.2f,0.3f);
        } else {
            GetComponentInChildren<SpriteRenderer>().color = new Color(0.3f,0.2f,0f,0.3f);
        }

        // if (Input.GetMouseButtonDown(1)) {
        //     Debug.Log("get here");
        //     // plant_script.clonePlant(horizontalInput, verticalInput);
        // }

    }

    void OnMouseOver() {

        if (Input.GetMouseButtonDown(1) && !pauseMenuUI.GameIsPaused) {
            Debug.Log("get here");
            if (plant == null) {
                plant_script.clonePlant(transform);
            }
            else if (full) {
                plant.gameObject.GetComponent<plant>().plant_stage = -1;
                player.gameObject.GetComponent<PlayerMove>().score += 1;
                GetComponentInChildren<SpriteRenderer>().color = new Color(0.3f,0.2f,0f,0.3f);
                full = false;
            }
        }

        
        if (Input.GetMouseButtonDown(0) && !pauseMenuUI.GameIsPaused) {
            Debug.Log("Clicked on object!");
            Debug.Log("hello:" + player);
            player.position = new Vector3(transform.position.x, transform.position.y+0.5f);
        }
        
        // if (Input.GetMouseButtonDown(1)) {
        //     Debug.Log("get here");
        //     plant_script.clonePlant(horizontalInput, verticalInput);
        // }

    }
}
