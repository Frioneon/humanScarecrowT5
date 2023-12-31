using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant : MonoBehaviour
{   
    int plant_stage = 0;
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteList;
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
        // if(Input.GetMouseButtonDown(0))
        // {
        //     ChangeSprite();
        // }

        DestroySprite();
        
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
