using Unity.Mathematics;
using UnityEngine;

public class Practice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        int[] numbers = { 1, 2, 3, 4, 5 }; //for 문, 자유도 높은 반복
        for (int i =0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }


        int[] numbers2 = { 1, 2, 3, 4, 5 }; //foreach 문, 무조건 순서대로
        foreach (int item in numbers2)
        {
            Debug.Log(item);
        }


        int l = 1; //조건문, 참일때 계속 반복
        while (l < 6)
        {
            Debug.Log(l);
            l++;
        }

        int j = 1; //조건문 (브레이크)
        while (true)
        {
            if (j > 5)
            {
                break;
            }
            Debug.Log(j);
            j++;
        }

        int k = 1; //조건문 2 (컨티뉴)
        while (k <= 10)
        {
            if (k % 2 == 0)
            {
                k++;
                continue;
            }
            Debug.Log(k);
            k++;
        }

    }

    // Update is called once per frame

    class Human
    {
        public string name;
        public float height;
        public int age;

        public void Eat()
        {
            Debug.Log("eat");
        }
        public void Walk()
        {
            Debug.Log("walk");
        }
        public void Sleep()
        {
            Debug.Log("sleep");
        }

        void Start()
        {
            float result = Half(4);
            Debug.Log(result);
        }
        float Half(float num)
        {
            return num / 2;
        }
    }

    //void Start() { }
    //Human john = new Human(); // new = 메모리에 인간 john 객체 을 할당하십시오.
    //Human Alice = new Human("alice", 23, 160);

    void Update()
    {
        
    }
}
