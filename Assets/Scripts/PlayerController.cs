using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //�ڱ༭���︳ֵ
    public GameObject looseUI;
    public GameObject winUI;
    public GameObject Bullet;
    public GameObject CDmask;
    public GameObject breakerReady;

    Rigidbody2D rBody;
    float runSpeed;
    float controlSpeed;
    float shootingCD;
    bool previousShooterInput;
    bool beginningShootingSetting;
    Animator anim;
    Timer spawnTimer;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        runSpeed = 5.5f;
        controlSpeed = 5f;
        shootingCD = 3;
        previousShooterInput = false;
        beginningShootingSetting = true;
        anim = GetComponent<Animator>();
        spawnTimer = gameObject.AddComponent<Timer>(); 
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        if (ScreenUtils.isLevelFinished == false)//�ؿ��ڽ�����
        {
            float moveX = Input.GetAxisRaw("Horizontal");
            Vector2 position = transform.position;
            position.x += moveX * controlSpeed * Time.fixedDeltaTime;
            position.y += runSpeed * Time.fixedDeltaTime;
            rBody.MovePosition(position);
        }
        else//�ؿ�����
        {
            anim.SetBool("isIdle", true);
        }
    }

    void Update()
    {
        //���
        if (beginningShootingSetting)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                beginningShootingSetting = false;
                previousShooterInput = true;
                ScreenUtils.CDcountDownStart = true;
                CDmask.GetComponent<Image>().fillAmount = 1;
                breakerReady.SetActive(false);
                GameObject bullet = GameObject.Instantiate(Bullet);
                bullet.transform.position = transform.position;
                spawnTimer.Duration = shootingCD;
                spawnTimer.Run();
            }    
        }
        else if (spawnTimer.Finished)//CD����
        {
            breakerReady.SetActive(true);
            Shooting();
        }
    }
    void Shooting()//��space�����
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            previousShooterInput = true;
            ScreenUtils.CDcountDownStart = true;
            CDmask.GetComponent<Image>().fillAmount = 1;
            breakerReady.SetActive(false);
            GameObject bullet = GameObject.Instantiate(Bullet);
            bullet.transform.position = transform.position;
            spawnTimer.Duration = shootingCD;
            spawnTimer.Run();
            //if (!previousShooterInput)
            //{

            //}
            //else
            //{
            //    previousShooterInput = false;
            //}
        }
    }

    public void OnTriggerEnter2D(Collider2D other)//�������������
    {
        if (other.tag == "Wall")
        {
            GetComponent<AudioSource>().Play();//����ײ����Ч
            ScreenUtils.isPlayerCatched = true;
            ScreenUtils.isLevelFinished = true;
            StartCoroutine(waitDie(1.5f));//Э�̣���ʱ��
        }
        else if (other.tag == "Coin")
        {
            ScreenUtils.Score += 1;
            Destroy(other.gameObject);
        }
        else if (other.tag == "Exit")
        {
            ScreenUtils.isExitReached = true;
            ScreenUtils.isLevelFinished = true;
            StartCoroutine(waitWin(1));//Э�̣���ʱ��
        }
    }
    IEnumerator waitDie(float x)
    {
        yield return waitForSeconds(x);
        looseUI.SetActive(true);
    }
    IEnumerator waitWin(float x)
    {
        yield return waitForSeconds(x);
        winUI.SetActive(true);
    }
    IEnumerator waitForSeconds(float time)
    {
        for (float t = 0.0f; t < time; t += Time.deltaTime)
        {
            yield return 0;
        }
    }
}
