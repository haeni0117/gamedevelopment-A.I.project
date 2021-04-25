using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text1_7 : MonoBehaviour
{
    public GameObject butForFadeout;
    public int cnt;
    public int count;
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
    public Button dad_b;
    public Button mom_b;
    public Button bro_b; 
    public Button btn;
    // float timer;
    // public Image fadeout_;
    // private float fadetime=1;
//=====================================================================================================================================
    //fadeout&fadein function
//=====================================================================================================================================
    // private IEnumerator fadein(float start, float end){
    //     float currentTime = 0.0f;
    //     float percent = 0.0f;
    //     while(percent<1){
    //         currentTime +=Time.deltaTime;
    //         percent = currentTime/fadetime;
    //         Color color = fadeout_.color;
    //         color.a = Mathf.Lerp(start, end, fadeCurve.Evaluate(percent));
    //         fadeout_.color = color;
            
    //         yield return null;

    //     }
    // }

//=====================================================================================================================================
    IEnumerator Typing(Text typingText, string message, float speed) 
    { 
        for (int i = 0; i < message.Length; i++) 
        { 
            typingText.text = message.Substring(0, i + 1); 
            yield return new WaitForSeconds(speed); 
        }
        
    }
    //=====================================================================================================================================
    //==============================count up function ============================================================
    //mom
    void cntup1(){
        cnt =100;
    }
    void cntup2(){
        cnt =200;
    }
    void cntup3(){
        cnt=300;
    }
    void cntup4(){
        cnt=400;
    }
    //dad
    void cntup11(){
        cnt=1000;
    }
    void cntup12(){
        cnt=1100;
    }
    void cntup13(){
        cnt=1200;
    }
    void cntup14(){
        cnt=1300;
    }
    private void cntup21(){
        cnt=2000;
    }
    private void cntup22(){
        cnt=2100;
    }
    private void cntup23(){
        cnt=2200;
    }
    private void cntup24(){
        cnt=2300;
    }
    private void cntup25(){
        cnt=2400;
    }
    private void cntup26(){
        cnt=2500;
    }
    private void cntup27(){
        cnt=2600;
    }
    private void cntup28(){
        cnt=2700;
    }
    private void cntup29(){
        cnt=2800;
    }
    private void cntup30(){
        cnt=2900;
    }
    private void cntup31(){
        cnt=3000;
    }


    //타이핑코루틴함수

    

    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("startasking");
        m_Speed = 0.05f; 
        originalask.text="누구야?";
        mom.SetActive(false);
        dad.SetActive(false);
        bro.SetActive(false);
    
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(cnt);
        if(Input.GetMouseButtonDown(0))
          cnt++;
         // Debug.Log(cnt)

            if(cnt==1){
                mom.SetActive(true);
                dad.SetActive(true);
                bro.SetActive(true);
                originalask_.SetActive(false);
            }
            if(cnt==101){ 
                cnt++;
                mom1();
            }
            if(cnt==201){
                cnt++;
                mom2();
            }
            if(cnt==301){
                cnt++;
                mom3();
                Invoke("original",5f);
            }
             if(cnt==401){
                cnt++;
                mom_b.interactable=false;
                dad_b.interactable=true;
                bro_b.interactable=true;
                dad_t.text = "아빠";
                bro_t.text="오빠";
            }//dad
            if(cnt==1001){
                cnt++;
                dad1();
            }
            if(cnt==1101){
                cnt++;
                dad2();
            }
            if(cnt==1201){
                cnt++;
                cnt++;
                mom_b.interactable=false;
                dad_b.interactable=true;
                bro_b.interactable=true;
                dad_t.text = "아빠";
                bro_t.text="오빠";
                mom_t.text="엄마";
            
            }
            if(cnt==2001){
                cnt++;
                bro1();
            }
            if(cnt==2101){
                cnt++;
                bro2();
            }
            if(cnt==2201){
                cnt++;
                bro3_typingfast();
            }
            if(cnt==2301){
                cnt++;
                bro4();
            }
            if(cnt==2401){
                cnt++;
                bro5();
            }
            if(cnt==2501){
                cnt++;
                bro6();
            }
            if(cnt==2601){
                cnt++;
                bro7();
            }
            if(cnt==2701){
                cnt++;
                bro8();
            }
            if(cnt==2801){
                cnt++;
                bro9();
            }
            if(cnt==2901){
                cnt++;
                bro10();
            }
            if(cnt==3001){
                cnt++;
                butForFadeout.SetActive(true);

                
            }
            // if(cnt==104){
            //     original();
            // }
            // if(cnt==1000001){
            //     dad1();
            // }
            // if(cnt==1000002){
            //     dad2();
            // }
            // if(cnt==1000003){
            //     original();
            // }
    }
    
    //버튼에게 onclick으로 연결할 함수 -> 버튼을 클릭하면 num증가하고 그때 interactable : false 해당 코루틴 함수가 종료되면 다시 interactable을 켜준다.
    public void mom0(){
        //SetActive-> 안먹히면 텍스트 = " " && + interactable = false
        dad_b.interactable=false;
        mom_b.interactable=false;
        bro_b.interactable=false;
        dad_t.text = " ";
        bro_t.text = " ";
        //mom.SetActive(false);//왜 mom오브젝트는 항상 setactive여야 하는거??;;; 일단 답이 없으니 false상태로 두겠음
        //bro.SetActive(false);
        //narration
        Debug.Log("mom_narration0");
        m_Speed = 0.05f; 
        generaltext.text="“다 너 때문이야. 네가 그러지만 않았어도, \n우리는 모두 살 수 있었어. \n다 네가, 네가 고집을 부려서 우리 현이가…….”";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("cntup1",5);//정수값 cnt 바꿔주기
        // if(Input.GetMouseButtonDown(0)){
        //     mom1();
        // }
    
    }
    public void mom1(){
        Debug.Log("mom_narration1");
        m_Speed = 0.05f; 
        generaltext.text="엄마는 대답 대신 구겨진 보닛 사이에 낀 왼 다리를 \n피가 나도록 긁기 시작한다.\n나는 도망치고 싶다고 생각하지만, \n절망감이 켜켜이 쌓인 목소리로 나를 비난하는 \n엄마의 눈동자를 벗어날 수가 없다.";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("cntup2",5);//정수값 cnt 바꿔주기   
        
    }
    public void mom2(){
        Debug.Log("mom_narration2");
        m_Speed = 0.05f; 
        generaltext.text="“엄마, 그게 무슨 말이야, 다 내 탓이라니…. \n엄마, 대답 좀 해봐! 엄마!”";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("cntup3",5);//정수값 cnt 바꿔주기         
    }
    public void mom3(){
        Debug.Log("mom_narration3");
        m_Speed = 0.05f; 
        generaltext.text="나는 다리를 긁는 엄마를 말리기 위해 손을 뻗는다.\n하지만 엄마를 잡는 것은, \n손이 아닌 뭉툭하게 잘린 손목뿐이다. \n아직 남아있는 손가락의 감각을 되살려보려고 애쓰지만,\n결국 피가 튀는 손목으로 허공을 허우적대는 걸 그만둔다.";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));   
        Invoke("cntup4",5);  
    }
    //원상복구
    public void original(){
        mom.SetActive(true);
        dad.SetActive(true);
        bro.SetActive(true);
        generaltext.text=" ";
    }
    //dad function ::::: dad_narration start
    public void dad0(){
        //SetActive_control->interactable=false
        dad_b.interactable=false;
        mom_b.interactable=false;
        bro_b.interactable=false;
        mom_t.text=" ";
        bro_t.text=" ";
        //narration
        Debug.Log("dad_narration0");
        m_Speed = 0.05f; 
        generaltext.text="“다 너 때문이야. \n어렸을 때부터 내 말을 그렇게도 안 듣더니, \n결국 기어코 일을 저지르는구나. \n네가 다 망친 거야. \n내 꿈도, 직장도, 가정도 네가 다…….”";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("cntup11",5);
    }
    public void dad1(){
        Debug.Log("dad_narration1");
        m_Speed = 0.05f; 
        generaltext.text="“캐니언 오토는 내 꿈을 이룰 수 있는 절호의 기회였어!\n캐니언 오토가 성공했다면,평생 허름한 사무실에 박혀서 \n풋내기들이나 가르치진 않았을 거다!\n\n사소한 실수 하나로 모든 걸 날려버리다니…….\n내가 다 고칠 수 있었는데, \n그 망할 놈의 기자들 때문에, \n다 너 때문에….”";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("cntup12",5);
    }
    public void dad2(){
        Debug.Log("dad_narration2");
        m_Speed = 0.05f; 
        generaltext.text="빗소리는 점점 더 차가워지고,\n아빠는 초점 잃은 눈으로 \n핸들 없이 평평한 자동차 앞면을 쓰다듬는다.\n세상에 하나밖에 없는 \n소중한 보물을 쓰다듬듯이.";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("cntup13",5);
    }
    //bro function ::::: bro_narration start
    public void bro0(){
        Debug.Log("bro_narration0");
        m_Speed = 0.05f; 
        generaltext.text="\"다 너 때문이야. \n너 때문에 내가 죽은 거야. \n고작 15살밖에 안 된 내가, \n이렇게 처참한 몰골로 죽은 건 \n다 너 때문이야.\"";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("cntup21",5);
    }
    public void bro1(){
        Debug.Log("bro_narration1");
        m_Speed = 0.05f; 
        generaltext.text="\"내가 그런 게 아니야, \n나는, 나는 그러려고 그런 게….\"";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("cntup22",5);
    }
    public void bro2(){
        Debug.Log("bro_narration2");
        m_Speed = 0.05f; 
        generaltext.text="나는 이 끔찍한 악몽을 \n몇 번의 손사래로 물리칠 수 있다는 듯이 \n유약한 몸뚱이로 세차게 저항하지만, \n오빠의 핏발 선 눈초리는 점점 따가워지고, \n물귀신처럼 끈질기게 나를 뒤쫓는다.";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("cntup23",5);
    }
    public void bro3_typingfast(){
        Debug.Log("bro_typing");
        m_Speed = 0.05f; 
        generaltext.text="\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n\"다 너 때문이야.\"\n";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("cntup24",6);
    }
    public void bro4(){
        Debug.Log("bro_narration3");
        m_Speed = 0.05f; 
        generaltext.text="온몸이 뒤틀린 가족들에게 나도 왼손을 잃었다고, \n운전을 한 사람은 내가 아니라고 외치고 싶지만, \n까맣게 칠해진 유년의 기억 속에서 \n새빨간 의심이 고개를 들고 속삭인다.";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("cntup25",5);
    }
    public void bro5(){
        Debug.Log("bro_narration4");
        m_Speed = 0.05f; 
        generaltext.text="사실 네가 잘못한 게 맞을 거라고.\n이 모든 참상은 다 너 때문이라고. \n그래서 나 같은 건 죽어 마땅할지도 모른다고.\n\n\"그래, 어쩌면 나 같은 건….\"";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("cntup26",5);
    }
    public void bro6(){
        Debug.Log("bro_narration5");
        m_Speed = 0.05f; 
        generaltext.text="손목의 잘린 단면을 타고 \n손바닥 모양의 푸른빛이 잠깐 나타났다 사라지고,\n노이즈 섞인 목소리가 손을 타고 흘러나온다.\n\n\"…을…요.\"";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("cntup27",5);
    }
    public void bro7(){
        Debug.Log("bro_narration6");
        m_Speed = 0.05f; 
        generaltext.text="\"뭐라고?\"\n\n아직도 피가 흐르는 손목에 귀를 갖다 대자 \n카라의 목소리가 들린다.";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("cntup28",5);
    }
    public void bro8(){
        Debug.Log("bro_narration7");
        m_Speed = 0.05f; 
        generaltext.text="\"홀로…을…꺼요!\"\n\n죽은 오빠가 입을 벙긋거리고,\n잘린 손목은 아프지 않고,\n아무리 비가 거세져도 발밑으로 물이 고이지 않아.\n빗소리를 뚫고 오빠가 악에 받쳐 소리친다.";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("cntup29",5);
    }
    public void bro9(){
        Debug.Log("bro_narration8");
        m_Speed = 0.05f; 
        generaltext.text="\"네가 지은 죄는 절대로 용서받을 수 없어!\n왜냐면 이건 다,\"\n\n“환각이니까.”";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("cntup30",5);
    }
    public void bro10(){
        Debug.Log("bro_narration9");
        m_Speed = 0.05f; 
        generaltext.text="나는 번쩍이는 푸른빛을 그러모아 주먹을 쥐고 \n자동차를 힘껏 내리쳤다.";
        StartCoroutine(Typing(m_TypingText, generaltext.text, m_Speed));
        Invoke("cntup31",5);
    }
}

