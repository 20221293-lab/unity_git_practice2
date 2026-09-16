using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int a; //초기화 문장 int a = 1;
    void Start()
    {
    
        {
         a = 1; //최초 한 번 Start() 메소드 실행 = 초기화
        Debug.Log(a);
        //Debug.Log("Hello Wolrd");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
