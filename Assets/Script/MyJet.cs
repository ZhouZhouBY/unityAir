using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyJet : MonoBehaviour
{
    public GameObject myPrefab;

    public AudioSource shootMusic;

    private float interval = 0.4f;
    private float count = 0;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (count >= interval) {
            count = 0;
            Fire();
        }

        float step = 2.5f * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(-step, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(step, 0, 0);
        }
    }

    void Fire() {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        GameObject bullet = Instantiate(myPrefab);
        bullet.transform.position = transform.position + new Vector3(0, 1f, 0);
        bullet.name = "my bullet";
    }
}
