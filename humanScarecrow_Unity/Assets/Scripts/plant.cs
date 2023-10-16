using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant : MonoBehaviour
{   
    int plant_stage = 0;
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteList;
    public int healCoolMax = 4;
    int healCool = 4;
    public Transform parent;

    Vector3 mousePos;
    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = spriteList[plant_stage];
        InvokeRepeating("PlantGrow", 2.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {

        DestroySprite();

        // if (Input.GetMouseButtonDown(1)) {

        //     mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //     mousePos.z = 0;

        //     Debug.Log(mousePos);

        //     // We can also limit where the player can plant with this
        //     if (this.name == "plant") {
        //         clonePlant();
        //     }
            
        // }
        
    }

    public void clonePlant(Transform new_t) {
        // Clone a new plant
        plant new_plant = Instantiate(this, parent);

        // Transform plant_pos = new_plant.transform;
        // plant_pos.position = plant_pos.position + mousePos;
        // mousePos.x = horizontalInput;
        // mousePos.y = verticalInput;
        // mousePos.z = 0;
        // Debug.Log(horizontalInput);

        Transform plant_pos = new_plant.transform;
        plant_pos.position = new_t.position;

    }

    void PlantGrow() {
        if (plant_stage < 2) {
            plant_stage++;
            spriteRenderer.sprite = spriteList[plant_stage];
        }
    }

    void DestroySprite()
    {   
        if (plant_stage < 0) {
            Destroy(gameObject);
        } else { 
            spriteRenderer.sprite = spriteList[plant_stage]; 
        }
        
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Bird") {
            plant_stage--;
        }
    }

    /*public void TimeStep() {
        if (healCool > 0) {
            healCool--;
        } else {
            healCool = healCoolMax;
            PlantGrow();
        }
    }*/
}

