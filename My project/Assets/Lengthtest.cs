using UnityEngine;

public class Lengthtest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] vector = new int[100];
        for (int i=0; i<vector.Length; i++) vector[i] = i;//벡터칸 100 (벡터칸 길이) 보다 더 작으면 계속 1 더해서 등록해
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
