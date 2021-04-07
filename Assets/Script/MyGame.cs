using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGame : MonoBehaviour
{
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void AddScore(int s) {
        this.score += s;
        Debug.Log("当前得分：" + score);
    }
}
