using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text1_6 : MonoBehaviour
{
    public Text m_TypingText; 
    public string m_Message;
    public float m_Speed;
    //타이핑코루틴함수
    IEnumerator Typing(Text typingText, string message, float speed) 
    { 
        for (int i = 0; i < message.Length; i++) 
        { 
            typingText.text = message.Substring(0, i + 1); 
            yield return new WaitForSeconds(speed); 
        } 
    }
    public Text generaltext;
    // Start is called before the first frame update
    void Start()
    {
        //count=100;
        Debug.Log("startnarration");
        m_Speed = 0.05f; 
        generaltext.text="노란색 스쿨버스의 구겨진 운전석엔 \n절망스러운 표정의 운전사가 머리에 피를 흘리며 앉아 있다.\n아이들은 다행히 안전벨트를 매고 있지만,\n비틀거리며 일어난 선생님은 사고의 충격으로 잠든 아이들을 꼭 껴안는다.";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("next1",9f);
    }
    private void next1(){
        generaltext.text="그러나 차가운 빗소리 사이로 흐르는 절규는 \n두 번 다시 회복되지 않는다.\n아빠의 오랜 꿈이었던 검은 캐니언 오토 T-85 모델이\n순식간에 오빠의 목을 꺾고, 엄마의 다리를 뒤틀고, \n아빠의 팔을 부러뜨린다.";
        m_Speed = 0.05f; 
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("next2",9f);
    }
    private void next2(){
        generaltext.text="그리고 나는 놀란 눈으로 날카롭게 부러진 손목뼈가 \n피부를 뚫고 나온 왼손을 바라본다.\n\n그리고 그건 다….\n“너 때문이야!”";
        m_Speed = 0.05f; 
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("next2",9f);
    }
    //private void next2(){
    //    SceneManager.LoadScene("1-7");
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene("1-7");
        }
    }
}
