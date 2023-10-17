// PlayerMove.cs
    using UnityEngine;
    using System.Collections;
    using System.Collections.Generic; 
    using UnityEngine.UI;


    public class PlayerMove : MonoBehaviour {
        Camera cam;
        public Sprite[] spriteList;
        public Sprite[] attackList;
        SpriteRenderer spriteRenderer; 
        public int coolMax = 50;
        int cool = 0;
        int spriteDex;
        public int score = 0;
        public GameObject t;

        void Start () {
            spriteRenderer = gameObject.GetComponentInChildren<SpriteRenderer>();
        }

        void Update() {
            if (Input.GetKey("up")||Input.GetKey("w")) {
                spriteDex = 3;
                GetComponent<BoxCollider2D>().size = new Vector2(0.01f, 14f);
                GetComponent<BoxCollider2D>().offset = new Vector2(0f, 7f);
            }
            if (Input.GetKey("down")||Input.GetKey("s")) {
                spriteDex = 0;
                GetComponent<BoxCollider2D>().size = new Vector2(0.01f, 14f);
                GetComponent<BoxCollider2D>().offset = new Vector2(0f, -7f);
            }
            if (Input.GetKey("right")||Input.GetKey("d")) {
                spriteDex = 2;
                GetComponent<BoxCollider2D>().size = new Vector2(14f, 0.01f);
                GetComponent<BoxCollider2D>().offset = new Vector2(7f, 0f);
            }
            if (Input.GetKey("left")||Input.GetKey("a")) {
                spriteDex = 1;
                GetComponent<BoxCollider2D>().size = new Vector2(14f, 0.01f);
                GetComponent<BoxCollider2D>().offset = new Vector2(-7f, 0f);
            }
            if (cool == 0) {
                spriteRenderer.sprite = spriteList[spriteDex];
            } else {
                spriteRenderer.sprite = attackList[spriteDex];
                cool--;
            }
            t.GetComponent<Text>().text = score.ToString();
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "Bird") {
                cool = coolMax;
            }
        }

    }