using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f; //public 외부공용, private 비공개
    public GameObject BulletPrefab;
    public float bulletSpeed = 400f;

    //int[] scores = new int[5];

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //bool a = true;
        //bool b = false;
        //gameObject.SetActive(a || b);
        //Vector2 newPos = transform.position;
        //newPos.x = newPos.x + 5;
        //transform.position = newPos;
        //Vector3 newPos;
        //transform.position = Vector3.one; // (1, 1, 1)
        //if (Input.GetKey(KeyCode.UpArrow)){this.transform.Translate(0, speed, 0);}
        //if (Input.GetKey(KeyCode.DownArrow)){this.transform.Translate(0, -speed, 0);}
        //if (Input.GetKey(KeyCode.RightArrow)){this.transform.Translate(speed, 0, 0);}
        //if (Input.GetKey(KeyCode.LeftArrow)){this.transform.Translate(-speed, 0, 0);}

        //for (int i = 0; i < scores.Length; i++)
        //    scores[i] = (i+1)*10;

        //Debug.Log(scores[0]);
        //Debug.Log(scores[1]);
        //Debug.Log(scores[2]);
        //Debug.Log(scores[3]);
        //Debug.Log(scores[4]);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(x, y, 0);
        transform.position += direction.normalized * speed * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Bullet = Instantiate(BulletPrefab);//실체화
            Bullet.transform.position = transform.position; //불릿의 위치 = 플레이어의 현재 위치
            Bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bulletSpeed);
        }

    }
}
