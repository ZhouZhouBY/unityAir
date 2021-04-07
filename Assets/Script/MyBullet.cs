using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBullet : MonoBehaviour
{
    public float speed = 5.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dy = speed * Time.deltaTime;

        transform.Translate(0, dy, 0, Space.Self);

        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
        if (sp.y > Screen.height) {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Monster")) {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);

            GameObject main = GameObject.Find("游戏主控");
            main.SendMessage("AddScore", 1);
            
            // MyGame myGame = main.GetComponent<MyGame>();
            // myGame.AddScore(1);
        }
    }
}
