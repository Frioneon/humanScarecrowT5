using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant_collider : MonoBehaviour
{
    public Transform player;
    public int mode;
    SpriteRenderer spriteRenderer;
    public Controller controller;
    public plant plantPrefab;
    private bool planty;
    plant plant;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform plant in controller.plants)
        {
            planty = (plant.position == gameObject.transform.position);
            if (planty) {break;}
        }
        if (( transform.position.x >=  7 ) || ( transform.position.x <= -7 ) || ( transform.position.y >=  4 ) || ( transform.position.y <= -4 ))
        {
            Deactivate();
        } else if (planty){
            Movevate();
        } else {
            Plantate();
        }
    }

    void OnMouseDown() {
        if (mode == 1)
        {
            player.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.5f);
            controller.itsTime = true;
        } else if (mode == 2) {
            plant = Instantiate(plantPrefab);
            controller.plants.Add(plant.gameObject.transform);
            plant.gameObject.transform.position = transform.position;
            controller.itsTime = true;
        }
    }

    void Movevate() {
        mode = 1;
        spriteRenderer.color = new Color(1f,0.64f,0f,0.5f);
    }

    void Plantate() {
        mode = 2;
        spriteRenderer.color = new Color(0f,1f,0f,0.5f);
    }

    void Deactivate() {
        mode = 0;
        spriteRenderer.color = Color.clear;
    }

}
