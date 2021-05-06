using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text2_1 : MonoBehaviour
{
    public GameObject button_;
    public static int cnt = 0; //static 변수로 수정 
    public Text m_TypingText; 
    public string m_Message;
    public float m_Speed;
    public Text generaltext;
    IEnumerator Typing(Text typingText, string message, float speed) 
    { 
        for (int i = 0; i < message.Length; i++) 
        { 
            typingText.text = message.Substring(0, i + 1); 
            yield return new WaitForSeconds(speed); 
        } 
    }

    // cnt funtion set==========================================================
    //cnt앞에 자료형 int를 써주니까 아예 새로운 변수로 인식하는 것 같음 왜??
    public void cntup1(){
        cnt=100;   
    }
    private void cntup2(){
        cnt=200;
    }
    private void cntup3(){
        cnt = 300;
    }
    private void cntup4(){
        cnt = 400;
    }
    private void cntup5(){
        cnt=500;
    }
    private void cntup6(){
        cnt=600;
    }
    //========================================================
    public void narr(){
        m_Speed = 0.05f; 
        m_Message="온기가 전혀 돌지 않는 \n안방이 서늘하다.\n반쯤 열린 창문 틈으로 \n무채색의 눈보라가 휘날린다.\n안방은 늘 그렇듯 \n기계적으로 정돈되어 있고, \n흐트러진 이부자리만이 \n사람의 흔적을 알린다."; 
        generaltext.text=m_Message;
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
        Debug.Log("이제 cntup1 실행");
        Invoke("cntup1",6);
        
    }
    public void narr_0(){
        m_Speed = 0.05f; 
        m_Message="나는 안방에서 다시 한번 \n카라를 소리쳐 불렀지만,\n여전히 카라는 아무런 답이 없다."; 
        generaltext.text=m_Message;
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
        Invoke("cntup2",4);
    }
    private void narr_1(){
        m_Speed = 0.05f; 
        m_Message="카라를 이식한 첫날 받은 \n사용 설명서에 적혀 있을 텐데.\n한참을 고민했지만, \n중앙 통제 시스템의 위치도, \n사용 설명서의 위치도\n생각나지 않는다.\n누군가 기억을 \n깨끗하게 지워버린 것 같다.\n10년이 넘도록 \n스마트홈 인공지능에 \n익숙해진 탓이겠지.";
        generaltext.text=m_Message;
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
        Invoke("cntup3",5);
        
    }
    private void narr_2(){
        m_Speed = 0.05f; 
        m_Message="카라를 복구하려면 \n일단은 이 우중충한 안방을 \n어서 벗어나야 한다."; 
        generaltext.text=m_Message;
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
        Invoke("cntup4",4);
    }
    private void narr_3(){
        m_Speed = 0.05f; 
        m_Message="\'철컥, 철컥\'\n\n\n예상과는 달리,\n 거실로 나가는 문은 잠겨 있다."; 
        generaltext.text=m_Message;
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
        Invoke("cntup5",5);
    }
    private void narr_4(){
        m_Speed = 0.05f; 
        m_Message="안방은 가장 보안이 \n삼엄한 공간이기 때문에 \n전자동 문이 고장 났을 경우 \n수동으로 빠져나갈 수 있도록 \n스페어 키를 서랍장에 넣어 놨다.\n\n번호 패드를 쓰는 방법도 있지만…. \n그러려면 나사를 먼저 풀어야 한다. \n\n우선 서랍장을 조사해 봐야겠다."; 
        generaltext.text=m_Message;
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
        Invoke("cntup6",6);
    }
    
    // Start is called before the first frame update
    

    void Start()
    {
        narr();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(cnt);
        if(Input.GetMouseButtonDown(0))
            cnt++;
        
        if(cnt==101){
            cnt++;
            narr_0();
        }
        if(cnt==201){
            cnt++;
            narr_1();
        }
        if(cnt==301){
            cnt++;
            narr_2();
        }
        if(cnt==401){
            cnt++;
            narr_3();
        }
        if(cnt==501){
            cnt++;
            narr_4();
        }
        if(cnt==601){
            cnt++;
            button_.SetActive(true);
        }
        
    }   
}
