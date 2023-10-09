using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant : MonoBehaviour
{   
    int plant_stage = 0;
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteList;

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

        if (Input.GetMouseButtonDown(1)) {

            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            Debug.Log(mousePos);

            // We can also limit where the player can plant with this
            if (this.name == "plant") {
                clonePlant();
            }
            
        }
        
    }

    void clonePlant() {
        // Clone a new plant
        plant new_plant = Instantiate(this);

        Transform plant_pos = new_plant.transform;
        plant_pos.position = plant_pos.position + mousePos;

    }

    void PlantGrow() {
        Debug.Log("I'm growingg~");
        if (plant_stage < 3) {
            plant_stage++;
            spriteRenderer.sprite = spriteList[plant_stage];
        }
    }

    void DestroySprite()
    {   
        if (plant_stage < 0) {
            Debug.Log("Destroyyy muahhahah");
            DestroyGameObject();
        } else { 
            Debug.Log("plant stage .-." + plant_stage);
            spriteRenderer.sprite = spriteList[plant_stage]; 
        }
        
    }

    void DestroyGameObject()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("something hitting plant (help me :vvv)");
        
        // Check for a match with the specific tag on any GameObject that 
        // collides with your GameObject
        if (collision.tag == "fish_col_tester") {
            Debug.Log("DESTROYED YOUR PLANT!!");
            plant_stage--;
        }
    }
}
