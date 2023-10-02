// PlayerMove.cs
    using UnityEngine;
    using System.Collections;
    using System.Collections.Generic; 
    using UnityEngine.UI;


    public class PlayerMove : MonoBehaviour {
        private Camera cam;
        public Sprite[] spriteList;
        SpriteRenderer spriteRenderer; 

        void Start () {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        }

        void Update() {
            if (Input.GetKey("up")||Input.GetKey("w")) {
                spriteRenderer.sprite = spriteList[3];
                GetComponent<BoxCollider2D>().size = new Vector2(1f, 3f);
                GetComponent<BoxCollider2D>().offset = new Vector2(0f, 1f);
            }
            if (Input.GetKey("down")||Input.GetKey("s")) {
                spriteRenderer.sprite = spriteList[0];
                GetComponent<BoxCollider2D>().size = new Vector2(1f, 3f);
                GetComponent<BoxCollider2D>().offset = new Vector2(0f, -1f);
            }
            if (Input.GetKey("right")||Input.GetKey("d")) {
                spriteRenderer.sprite = spriteList[2];
                GetComponent<BoxCollider2D>().size = new Vector2(3f, 1f);
                GetComponent<BoxCollider2D>().offset = new Vector2(1f, 0f);
            }
            if (Input.GetKey("left")||Input.GetKey("a")) {
                spriteRenderer.sprite = spriteList[1];
                GetComponent<BoxCollider2D>().size = new Vector2(3f, 1f);
                GetComponent<BoxCollider2D>().offset = new Vector2(-1f, 0f);
            }
        }

    }