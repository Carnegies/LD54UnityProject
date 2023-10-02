using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class progression : MonoBehaviour
{
    //直接在编辑器里赋值
    public GameObject Player;
    public GameObject Exit;

    float levelLength;
    float levelProgress;
    float playerInitialPositionY;
    Vector3 vFullProgress;

    void Awake()
    {
        playerInitialPositionY = Player.transform.position.y;
    }

    void Start()
    {
        levelLength = Exit.transform.position.y - playerInitialPositionY;
        vFullProgress = gameObject.transform.localScale;
    }

    void Update()
    {
        levelProgress = (Player.transform.position.y - playerInitialPositionY) / levelLength;
        gameObject.transform.localScale = new Vector3(vFullProgress.x * levelProgress, vFullProgress.y, vFullProgress.z);
    }
}
