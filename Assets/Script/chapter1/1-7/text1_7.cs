using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text1_7 : MonoBehaviour
{
    int cnt ;
    int count;
    public Text m_TypingText; 
    public Text generaltext;
    public string m_Message;
    public float m_Speed;
    public Text originalask;
    public GameObject originalask_;
    public GameObject mom;
    public GameObject dad;
    public GameObject bro;
    public Text mom_t;
    public Text dad_t;
    public Text bro_t;


    //타이핑코루틴함수
    IEnumerator Typing(Text typingText, string message, float speed) 
    { 
        for (int i = 0; i < message.Length; i++) 
        { 
            typingText.text = message.Substring(0, i + 1); 
            yield return new WaitForSeconds(speed); 
        } 
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("startasking");
        m_Speed = 0.05f; 
        originalask.text="누구야?";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Debug.Log(cnt);
            cnt++;
            count++;
            if(cnt==1){
                mom.SetActive(true);
                dad.SetActive(true);
                bro.SetActive(true);
                originalask_.SetActive(false);
            }
            if(count==101){
                mom1();
            }
            if(cnt==102){
                mom2();
            }
            if(cnt==103){
                mom3();
            }
            if(cnt==104){
                original();
            }
            if(cnt==1000001){
                dad1();
            }
            if(cnt==1000002){
                dad2();
            }
            if(cnt==1000003){
                original();
            }
        }
    }

    public void mom0(){
        int count=100;
        Debug.Log(count);
        //SetActive
        mom.SetActive(true);
        dad.SetActive(false);
        bro.SetActive(false);
        //narration
        Debug.Log("mom_narration0");
        m_Speed = 0.05f; 
        generaltext.text="“다 너 때문이야. 네가 그러지만 않았어도, \n우리는 모두 살 수 있었어. \n다 네가, 네가 고집을 부려서 우리 현이가…….”";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        if(Input.GetMouseButtonDown(0)){
            mom1();
        }
        
        
        
    }
    
    public void mom1(){
        Debug.Log("mom_narration1");
        Debug.Log(count);
        m_Speed = 0.05f; 
        generaltext.text="엄마는 대답 대신 구겨진 보닛 사이에 낀 왼 다리를 \n피가 나도록 긁기 시작한다.\n나는 도망치고 싶다고 생각하지만, \n절망감이 켜켜이 쌓인 목소리로 나를 비난하는 \n엄마의 눈동자를 벗어날 수가 없다.";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));        
    }
    public void mom2(){
        Debug.Log("mom_narration2");
        m_Speed = 0.05f; 
        generaltext.text="“엄마, 그게 무슨 말이야, 다 내 탓이라니…. \n엄마, 대답 좀 해봐! 엄마!”";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));      
    }
    public void mom3(){
        Debug.Log("mom_narration3");
        m_Speed = 0.05f; 
        generaltext.text="나는 다리를 긁는 엄마를 말리기 위해 손을 뻗는다.\n하지만 엄마를 잡는 것은, \n손이 아닌 뭉툭하게 잘린 손목뿐이다. \n아직 남아있는 손가락의 감각을 되살려보려고 애쓰지만,\n결국 피가 튀는 손목으로 허공을 허우적대는 걸 그만둔다.";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));     
    }
    //원상복구
    public void original(){
        mom.SetActive(true);
        dad.SetActive(true);
        bro.SetActive(true);
        generaltext.text="";
    }

    public void dad0(){
        //SetActive_control
        mom.SetActive(false);
        dad.SetActive(true);
        bro.SetActive(false);
        //narration
        Debug.Log("dad_narration0");
        m_Speed = 0.05f; 
        generaltext.text="“다 너 때문이야. \n어렸을 때부터 내 말을 그렇게도 안 듣더니, \n결국 기어코 일을 저지르는구나. \n네가 다 망친 거야. \n내 꿈도, 직장도, 가정도 네가 다…….”";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        int cnt = 1000000;
    }
    public void dad1(){
        Debug.Log("dad_narration1");
        m_Speed = 0.05f; 
        generaltext.text="“캐니언 오토는 내 꿈을 이룰 수 있는 절호의 기회였어!\n캐니언 오토가 성공했다면,평생 허름한 사무실에 박혀서 \n풋내기들이나 가르치진 않았을 거다!\n\n사소한 실수 하나로 모든 걸 날려버리다니…….\n내가 다 고칠 수 있었는데, \n그 망할 놈의 기자들 때문에, \n다 너 때문에….”";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
    }
    public void dad2(){
        Debug.Log("dad_narration2");
        m_Speed = 0.05f; 
        generaltext.text="빗소리는 점점 더 차가워지고,\n아빠는 초점 잃은 눈으로 \n핸들 없이 평평한 자동차 앞면을 쓰다듬는다.\n세상에 하나밖에 없는 \n소중한 보물을 쓰다듬듯이.";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
    }
}
