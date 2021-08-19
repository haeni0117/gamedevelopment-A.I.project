using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class text7_3 : MonoBehaviour
{
    public void FadeIn(float fadeOutTime, System.Action nextEvent = null){
		StartCoroutine(CoFadeIn(fadeOutTime,nextEvent));
	}

	public void FadeOut(float fadeOutTime, System.Action nextEvent = null){
		StartCoroutine(CoFadeOut(fadeOutTime, nextEvent));
	}

    public static Text typingText;
    public static GameObject a;
    public static Button aB;
    public static Button 스킵;
    public static Text at;
//(2)반려동물 방석
    public static GameObject b;
    public static Button bB;
    public static Text bt;
//(3)의지
    public static GameObject c;
    public static Button cB;
    public static Text ct;
//(4)iot쓰레기통
    public static GameObject d;
    public static Button dB;
    public static Text dt;
    public static GameObject choice;
    public static Button choiceB;
    public static Text choicet;

    public static GameObject choice1;
    public static Button choice1B;
    public static Text choice1t;

     public static GameObject e;
    public static Button eB;
    public static Text et;
    public static bool a_inspection=false;
    public static bool b_inspection= false;
    public static bool c_inspection= false;
    public static bool d_inspection= false;
    public static bool e_inspection= false;
    public static void 활성화(){
        if(a_inspection==false){
            aB.interactable=true;
        }else aB.interactable=false;
        if(b_inspection==false){
            bB.interactable=true;
        }else bB.interactable=false;
        if(c_inspection==false){
            cB.interactable=true;
        }else cB.interactable=false;
        if(d_inspection==false){
            dB.interactable=true;
        }else dB.interactable=false;
        if(e_inspection==false){
            eB.interactable=true;
        }else eB.interactable=false;
    }

	// 투명 -> 불투명
	IEnumerator CoFadeIn(float fadeOutTime, System.Action nextEvent = null){
        GameObject srr = GameObject.Find("fadeout");
		Image sr = srr.GetComponent<Image>();
		Color tempColor = sr.color;
		while(tempColor.a < 1f){
			tempColor.a += Time.deltaTime / fadeOutTime;
			sr.color = tempColor;

			if(tempColor.a >= 1f) tempColor.a = 1f;

			yield return null;
		}

		sr.color = tempColor;
		if(nextEvent != null) nextEvent();
	}

	// 불투명 -> 투명
	IEnumerator CoFadeOut(float fadeOutTime, System.Action nextEvent = null){
		GameObject srr = GameObject.Find("fadeout");
		Image sr = srr.GetComponent<Image>();
		Color tempColor = sr.color;
		while(tempColor.a > 0f){
			tempColor.a -= Time.deltaTime / fadeOutTime;
			sr.color = tempColor;

			if(tempColor.a <= 0f) tempColor.a = 0f;

			yield return null;
		}
		sr.color = tempColor;
		if(nextEvent != null) nextEvent();
	}


    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정 
    
    public static GameObject fadeout;

     public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
    }
    public static void 선택지활성화(){
        if(a_inspection==false){
            aB.interactable=true;
        }else aB.interactable=false;
        if(b_inspection==false){
            bB.interactable=true;
        }else bB.interactable=false;
        if(c_inspection==false){
            cB.interactable=true;
        }else cB.interactable=false;
    }

    static IEnumerator Typing(string message)
    { 
        typingText = GameObject.Find("general text").GetComponent<Text>();
        Debug.Log("typingtext"+typingText);
        Debug.Log("message"+message);
        
        //message=text_1;
        for (int i = 0; i < message.Length; i++) 
        { 
            typingText.text = message.Substring(0, i + 1); 
            yield return new WaitForSeconds(0.05f);

            if(num%3==1){
                num++;
                Debug.Log("coroutine is stopped+num"+num);
                yield break; //코루틴종료
                //여기서 그냥 끊고, update에서 다음 시나리오 출력해주기
            }//코루틴이 중간에 끝나는 것이 아니라 그냥 나가면? ㅇㅋㅇㅋ
           
            }
            num++;
            Debug.Log("user didn't skip the text+num"+num);
        
    

    }
    public static void a활성화(){
        a_inspection=true;
        num = 5;

    }
     public static void b활성화(){
         b_inspection=true;
        num=8;
    }

    public static void c활성화(){
        c_inspection=true;
        num=11;
    }
    public static void d활성화(){
        d_inspection=true;
        num=17;
    }
    public static void e활성화(){
        e_inspection=true;
        num=20;
    }
    public static void choice활성화(){
        num=3;
    }
    public static void choice1활성화(){
        num=26;
    }

    private static string text_1="2층 창고에는 오랫동안 사람의 \n발길이 닿지 않아 서늘한 \n냉기가 감돈다.";
    private static string text_2="안에 의수 사용 설명서가\n들어있다.\n의수를 고칠 때는 내장된　\n부품을 먼저 손본 뒤 \n의수 본체를 고치라는데...";
    private static string text_3="빛을 받은 조명이 창백하게 \n장식장을 비춘다. \n자라면서 크기별로 보관해둔 \n손들이 덩그러니 놓여있다. \n괜히 소름이 돋아 어깨를 \n문질렀다. ";
    private static string text_4="장식장을 열어 손에 잡히는 \n아무 의수나 집어 들었다. \n{12세 때 의수를 획득했다.}";
    private static string text_5="열리지 않는다. \n전용 스마트 키 없이는 \n열 수 없다."; //B선택지연결(변기로간다)
    //C선택지(욕조로 간다)
    private static string text_6="계절에 맞지 않는 옷을 \n넣은 상자들 뿐이다."; //C선택지연결
    private static string text_7="유리창 안으로 스마트 lot 금고용 \n스마트 키가 보인다. \n지문 인식으로 락박스를 열 수 \n있으려나…?\n역시 락박스는 열리지 않는다. \n카라가 막아놓은 것 같다. ";
    private static string text_8="12살 때 쓰던 의수를 얻었다.\n내장 칩은 간단하게 \n전원 버튼 쪽 커버를 열어서\n얻을 수 있다.\n\n{12세 때 의수를 분해한다}";
    private static string text_9="{내장 칩을 획득했다.}";
    private static string text_10="내장 칩을 꺼내고 12살 때 \n쓰던 의수는 다시 장식장에\n넣어두었다.";
    private static string text_11="이거라면 사라와 다시 대화할 \n수 있을 거야.\n17년 전 내장 칩이긴 하지만 \n다행히 잘 작동하겠지.";
    
    //coroutine function
    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);       
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5 = Typing(text_6);
    static IEnumerator coroutine6 = Typing(text_7);
    static IEnumerator coroutine7 = Typing(text_8);
    static IEnumerator coroutine8 = Typing(text_9);
    static IEnumerator coroutine9 = Typing(text_10);
    static IEnumerator coroutine10 = Typing(text_11);
   


    // Start is called before the first frame update
    void Awake(){
        // FadeOut(1.0f);
        // Debug.Log("fadein : awake function");
        a = GameObject.Find("a");
        aB =a.GetComponent<Button>();
        at = GameObject.Find("aText").GetComponent<Text>();
        aB.onClick.AddListener(a활성화);

        b = GameObject.Find("b");
        bB =b.GetComponent<Button>();
        bt = GameObject.Find("bText").GetComponent<Text>();
        bB.onClick.AddListener(b활성화);

        c = GameObject.Find("c");
        cB =c.GetComponent<Button>();
        ct = GameObject.Find("cText").GetComponent<Text>();
        cB.onClick.AddListener(c활성화);

        d = GameObject.Find("d");
        dB =d.GetComponent<Button>();
        dt = GameObject.Find("dText").GetComponent<Text>();
        dB.onClick.AddListener(d활성화);

        e = GameObject.Find("e");
        eB =e.GetComponent<Button>();
        et = GameObject.Find("eText").GetComponent<Text>();
        eB.onClick.AddListener(e활성화);

        choice = GameObject.Find("choice");
        choiceB =choice.GetComponent<Button>();
        choicet = GameObject.Find("choiceText").GetComponent<Text>();
        choiceB.onClick.AddListener(choice활성화);

        choice1 = GameObject.Find("choice1");
        choice1B =choice1.GetComponent<Button>();
        choice1t = GameObject.Find("choice1Text").GetComponent<Text>();
        choice1B.onClick.AddListener(choice1활성화);

        at.text="(1) 철제 서랍장";
        bt.text="(2) 의수 보관 장식장";
        ct.text="(3) 스마트 Iot 금고";
        dt.text="(4) 서랍장";
        et.text="(5) 열쇠 보관용 스마트 락박스";
        choicet.text="1. 어디부터 조사하지?";
        

        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
        e.SetActive(false);


        choice.SetActive(false);
        choice1.SetActive(false);

        // c = GameObject.Find("c");
        // cB =c.GetComponent<Button>();
        // ct = GameObject.Find("cText").GetComponent<Text>();
        // cB.onClick.AddListener(c활성화);

        // d = GameObject.Find("d");
        // dB =d.GetComponent<Button>();
        // dt = GameObject.Find("dText").GetComponent<Text>();
        // dB.onClick.AddListener(d활성화);
        //fadein
    }
    void Start()
    {
        Debug.Log("Scene 7-1 is started");
        //오피스텔 화장실 .img
   
       스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text7_3.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       StartCoroutine(coroutine);
       
       
       
    }

    // Update is called once per frame
    void Update()
    {
        if(num==1){
            choice.SetActive(true);
            스킵.interactable=false;
            

        
            //StartCoroutine(coroutine1);
        }
        if(num==3){
            choice.SetActive(false);
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            e.SetActive(true);
            활성화();
            typingText.text=" ";
            

        
            //StartCoroutine(coroutine1);
        }
        if(num==5){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);
            StartCoroutine(coroutine1);
            num++;
            choice.SetActive(false);
            스킵.interactable=false;
            
        }
        if(num==7){
            choice.SetActive(false);
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            e.SetActive(true);
            활성화();
            typingText.text=" ";
            

        
            //StartCoroutine(coroutine1);
        }

        
        if(num==8){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);
            StartCoroutine(coroutine2);
            스킵.interactable=true;
            num++;
        }
      
       
        if(num==11){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);
            StartCoroutine(coroutine3);
            스킵.interactable=false;
            num++;     
        }
        if(num==13){
            
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            e.SetActive(true);
            활성화();
            typingText.text=" ";
            

        
            //StartCoroutine(coroutine1);
        }
        
        if(num==14){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);
             StartCoroutine(coroutine4);
            num++;            
        }
        if(num==16){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            e.SetActive(true);
            활성화();
            typingText.text=" "; //StartCoroutine(coroutine1);
        }
        if(num==17){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);
             StartCoroutine(coroutine5);
            num++;            
        }
        if(num==19){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            e.SetActive(true);
            활성화();
            typingText.text=" "; //StartCoroutine(coroutine1);
        }
        if(num==20){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);

             StartCoroutine(coroutine6);
             스킵.interactable=true;
            num++;            
        }
        if(num==23){
            StartCoroutine(coroutine7);
            num++;  
                   
        }
        if(num==26){
           
            StartCoroutine(coroutine8);
            num++;
        }
        if(num==29){
            StartCoroutine(coroutine9);
            num++;}
            
        if(num==32){
            StartCoroutine(coroutine10);
            num++;
            
        }
        if(num==34){
            SceneManager.LoadScene("7-3");
            
        }
        


    }
}
