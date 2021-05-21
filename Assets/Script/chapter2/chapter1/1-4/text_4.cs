using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text_4 : MonoBehaviour
{
    //public GameObject SplashObj;   
    //public Image image; 
    //private bool checkbool = false;
    //====================================
    public GameObject fadeoutbutton; //SetActive로 마지막에 켜서 버튼클릭->페이드아웃으로 넘어가기 위함 fade in 스크립트활용
    public Text generaltext;
    int count ;
    public Image image;                            //판넬 이미지
    private bool checkbool = false;
   //coroutine function
    public Text m_TypingText; 
    public string m_Message;
    public float m_Speed;
    //==================
    public GameObject choice1;
    public GameObject choice2;
    public GameObject choice1_;
    public GameObject choice2_;
    public Text choice1t;
    public Text choice2t;

    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(count);
        Debug.Log("start");
        choice1t.text = "카라에게 무슨 일인지 믈어본다.";
        choice2t.text="비데에 가까이 가서 확인해본다";
        
    }
    IEnumerator MainSplash(){
        Color color = image.color;                            //color 에 판넬 이미지 참조
        for (int i = 100; i >= 0; i--)                            //for문 100번 반복 0보다 작을 때 까지
        {
            color.a -= Time.deltaTime * 0.005f;               //이미지 알파 값을 타임 델타 값 * 0.01
            image.color = color;                                //판넬 이미지 컬러에 바뀐 알파값 참조
            if (image.color.a <= 0)                        //만약 판넬 이미지 알파 값이 0보다 작으면
            {
               checkbool = true;                              //checkbool 참 
            }
        }
        yield return null;                                        //코루틴 종료
    }



    IEnumerator Typing(Text typingText, string message, float speed) 
    { 
        for (int i = 0; i < message.Length; i++) 
        { 
            typingText.text = message.Substring(0, i + 1); 
            yield return new WaitForSeconds(speed); 
        } 
    }
    //fadein_coroutine
    

    //fadeout_coroutine


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            count++;
            Debug.Log(count);
            if(count==101){
                text1_1();
            }
            if(count==102){
                text1_2();
            }
            if(count==103){
                text1_3();
            }
            if(count==104){
                text1_4();
            }
            if(count==105){
                text1_5();
            }
            if(count==106){
                text1_6();
            }
            if(count==107){
                text1_7();
            }
            if(count==108){
                text1_8();
            }
            if(count==109){
                text1_9();
            }
            if(count==110){
                text1_10();
            }
            if(count==111){
                text1_11();
            }
            if(count==112){
                SceneManager.LoadScene("1-5");
            }
            }      
            
    }

    
    
    public void choice1to(){
        count=100;
        Debug.Log(count);
        m_Speed = 0.05f; 
        generaltext.text="“카라, \n무슨 일이야 이게?”";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        choice1t.text="";
        choice2t.text="";


    }

    public void text1_1(){
        
        generaltext.text="작업실 쪽에서 \n누전이 일어난 것 같습니다.\n금방 복구할 수 있도록 \n조치해두었으니,\n너무 걱정하지 않으셔도 \n될 것 같습니다.”";
        Debug.Log(count);
        m_Speed = 0.05f; 
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        
    }
    public void text1_2(){
        generaltext.text="인공지능이 관리하는 \n스마트홈에서 정전이라니….\n듣기 싫은 경고음이 \n불규칙적으로 울리고 \n다시 머리가 욱신거린다.";
        Debug.Log("text1_2");
        m_Speed = 0.05f; 
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        
    }
    public void text1_3(){
        generaltext.text="“저 경고음은 끌 수 없어?”";
        Debug.Log("text1_3");
        m_Speed = 0.05f; 
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
    }
        
        
    public void text1_4(){
        generaltext.text="........................";
        Debug.Log("text1_4");
        m_Speed = 0.05f; 
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        
    }
    public void text1_5(){
        generaltext.text="\"카라?\"";
    
        Debug.Log("text1_5");
        m_Speed = 0.05f; 
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
    }
    public void text1_6(){
        generaltext.text = "소음이 점점 커진다. \n이제는 소음이 귓가에서 \n울리는 게 아니라 \n머릿속을 파고드는 것만 같다.";
        Debug.Log("text1_6");
        m_Speed = 0.05f; 
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        
    }
    public void text1_7(){
        generaltext.text = "비상 전력으로 돌아가는 \n벽면의 햇살이 거울에 반사되어 \n매섭게 눈을 부라리고,\n섬광을 피하려고 내려다본 \n바닥엔 오직, \n심해의 캄캄한 어둠뿐이다.";
        Debug.Log("text1_7");
        m_Speed = 0.05f; 
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        
    }
    public void text1_8(){
        generaltext.text="‘너는 늘 그 고집이 문제야.’\n‘그러니까 왜 말을 안 들어서 \n이 사단을….’";
        Debug.Log("text1_8");
        m_Speed = 0.05f; 
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
    }
    public void text1_9(){
        generaltext.text="\"고개를 드세요.\"";
        Debug.Log("text1_9");
        m_Speed = 0.05f; 
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
    }
    public void text1_10(){
        generaltext.text="“카라…?”";
        Debug.Log("text1_10");
        m_Speed = 0.05f; 
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
    }
    public void text1_11(){
        generaltext.text="“고개를 드세요. 주인님. \n본인이 무슨 짓을 했는지 \n마주할 용기는 있어야죠.”";
        Debug.Log("text1_11");
        m_Speed = 0.05f; 
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
    }
    public void fo(){
        StartCoroutine("MainSplash");
        Debug.Log("fo");                       //코루틴    //판넬 투명도 조절

        if (checkbool)                                            //만약 checkbool 이 참이면
        {
            Destroy(this.gameObject);                        //판넬 파괴, 삭제

        }
    }
}


