// PlayerMove.cs
    using UnityEngine;
    using System.Collections;
    using System.Collections.Generic; 
    using UnityEngine.UI;


    public class PlayerMove : MonoBehaviour {
        private Camera cam;
        public Transform move;
        public Transform playerPos;
        public Rigidbody2D player;
        public Rigidbody2D plant;
        public Rigidbody2D plant1;
        public Rigidbody2D plant2;
        public Rigidbody2D plant3;
        public Sprite[] spriteList;
        SpriteRenderer spriteRenderer; 

        void Start () {
            playerPos = GameObject.FindWithTag("Scarecrow").GetComponent<Transform>();
            move = GetComponent<Transform>();
            player = GetComponent<Rigidbody2D>();
            plant = GetComponent<Rigidbody2D>();
            plant1 = GetComponent<Rigidbody2D>();
            plant2 = GetComponent<Rigidbody2D>();
            plant3 = GetComponent<Rigidbody2D>();
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            //down.setActive(true);
            // player.Right.setActive(false);
            // player.Left.setActive(false);
            // plaer.Up.setActive(false);
            // Disabling auto-braking allows for continuous movement
            // between points (ie, the agent doesn't slow down as it
            // approaches a destination point).
            //agent.autoBraking = false;

            //GotoNextPoint();
        }

        void OnMouseDown() {
            //Debug.Log("Clicked on object!");
        }

        void Update() {
            if (Input.GetMouseButtonDown(0)) {
                Vector2 mousePos = Input.mousePosition;
                //Vector3 point = new Vector3();
                //Vector3 vector = new Vector3(move.position.x, move.position.y, move.position.z);
                //playerPos.position = vector;
                
                //print("mouse");
                //player.position = plant.position;

                print(mousePos.x);
                print(mousePos.y);
                // print(vector.x + "mouse");
                // print(vector.y + "mouse");

                

            }

            if (Input.GetKey("up")) {
                spriteRenderer.sprite = spriteList[3];
                //print("hello world");
                // Down.setActive(false);
            }
            if (Input.GetKey("down")) {
                spriteRenderer.sprite = spriteList[0];
                //print("hello world");
                // Down.setActive(false);
            }
            if (Input.GetKey("right")) {
                spriteRenderer.sprite = spriteList[2];
                //print("hello world");
                // Down.setActive(false);
            }
            if (Input.GetKey("left")) {
                spriteRenderer.sprite = spriteList[1];
                //print("hello world");
                // Down.setActive(false);
            }





        }

    }