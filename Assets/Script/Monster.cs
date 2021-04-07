using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dy = speed * Time.deltaTime;
        transform.Translate(0, -dy, 0);

        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
        if (sp.y < 0) {
            Destroy(this.gameObject);
        }
    }
}
