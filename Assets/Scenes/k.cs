using System.Collections;
using UnityEngine;

public class k: MonoBehaviour
{
    float time;
    IEnumerator myCoroutine;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start 함수 시작");
        myCoroutine = MyCoroutine(1.0f);
        StartCoroutine(myCoroutine);
        Debug.Log("myCoroutine종료 후 제어권 start함수로 넘어옴");
        time = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        //정해둔 시간이 다 끝나면
        if (time < 0)
        {
            Debug.Log("정해둔 시간 다 됨");
            StopCoroutine(myCoroutine);
            Debug.Log("stopcoroutine 완료");
        }
    }

    IEnumerator MyCoroutine(float t)
    {
        Debug.Log("Coroutine;" + t);
        yield return new WaitForSeconds(0.1f);
        Debug.Log("매개변수만큼 wait");

        while (true)
        {
            Debug.Log("Coroutine//while true");
            yield return new WaitForSeconds(0.2f);
        }
    }
}
 