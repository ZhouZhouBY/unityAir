using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCtrl : MonoBehaviour
{
    public GameObject monsterPrefab;

    public Sprite[] images;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateMonster", 0.1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateMonster() {
        float x = Random.Range(-2, 2);
        float y = 5;
        GameObject monster = Instantiate(monsterPrefab);
        monster.transform.position = new Vector3(x, y, 0);

        // 随机选择怪物头像
        int index = Random.Range(0, images.Length);
        

        // 设置头像大小
        Sprite sprite = this.images[index];
        
        float imgWigth = sprite.rect.width;
        Debug.Log(imgWigth);
        float scale = 100 / imgWigth;
        monster.transform.localScale = new Vector3(scale, scale, scale);
        Debug.Log(monster.transform.localScale);

        SpriteRenderer renderer = monster.GetComponent<SpriteRenderer>();
        renderer.sprite = this.images[index];
    }
}
