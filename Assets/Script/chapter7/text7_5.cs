using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class text7_5 : MonoBehaviour
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
     public static GameObject f;
    public static Button fB;
    public static Text ft;
    public static bool a_inspection=false;
    public static bool b_inspection= false;
    public static bool c_inspection= false;
    public static bool d_inspection= false;
    public static bool e_inspection= false;
    public static bool f_inspection= false;

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
        // if(e_inspection==false){
        //     eB.interactable=true;
        // }else eB.interactable=false;
        
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
        num=14;
    }
    public static void e활성화(){
        e_inspection=true;
        num=26;
    }
   
    public static void choice활성화(){
        num=1;
    }
    public static void choice1활성화(){
        num=17;
    }

    private static string text_1="의수 하드웨어 부품은 모두 \n작업실 상자에 들어있다.";
    private static string text_2="책상 위에는 특별한 것이 없다.";
    private static string text_3="쓰레기통은 그만 \n뒤지는 것이 좋겠어....";
    private static string text_4="스마트 액자엔 동료들과 찍은 \n영상이 5초 간격으로 반복되고 \n있다. ";
    private static string text_5="의수 부품 상자가 여기 있다!\n\n{의수 부품 상자를 획득했다.}\n\n부품 상자를 열어보자.";
    private static string text_6="아까 의자에서 넘어질 때\n상자를 떨어뜨려서 \n안의 부품들이 전부 뒤섞였다. \n상자를 이리저리 뒤져서 \n알맞은 부품을 꺼냈다.\n\n{의수 손가락 관절 부품을 획득했다.}"; //B선택지연결(변기로간다)
    //C선택지(욕조로 간다)
    private static string text_7="오래되어 녹이 슨 부품이지만, \n의수를 움직이는 데는 문제가 \n없을 것이다."; //C선택지연결

    
    
    //coroutine function
    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);       
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5 = Typing(text_6);
    static IEnumerator coroutine6 = Typing(text_7);
    // static IEnumerator coroutine6 = Typing(text_7);
    // static IEnumerator coroutine7 = Typing(text_8);
   


    // Start is called before the first frame update
    void Awake(){
        typingText = GameObject.Find("general text").GetComponent<Text>();
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

        // e = GameObject.Find("e");
        // eB =e.GetComponent<Button>();
        // et = GameObject.Find("eText").GetComponent<Text>();
        // eB.onClick.AddListener(e활성화);

        // f = GameObject.Find("f");
        // fB =f.GetComponent<Button>();
        // ft = GameObject.Find("fText").GetComponent<Text>();
        // fB.onClick.AddListener(f활성화);

        choice = GameObject.Find("choice");
        choiceB =choice.GetComponent<Button>();
        choicet = GameObject.Find("choiceText").GetComponent<Text>();
        choiceB.onClick.AddListener(choice활성화);

        choice1 = GameObject.Find("choice1");
        choice1B =choice1.GetComponent<Button>();
        choice1t = GameObject.Find("choice1Text").GetComponent<Text>();
        choice1B.onClick.AddListener(choice1활성화);

        at.text="(1) 책상";
        bt.text="(2) IoT 쓰레기통";
        ct.text="(3) 양탄자";
        dt.text="(4) 책장";
        // et.text="(5) 수건 받침대";
        // ft.text="F. 게스트룸 화장실로 간다.";
        choicet.text="1. 작업실을 조사한다.";
        choice1t.text="{의수 부품 상자를 분해한다}\n{의수 부품 상자 삭제}";
        

        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
      
       


        choice.SetActive(false);
        choice1.SetActive(false);
        // choice1.SetActive(false);

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
       스킵.onClick.AddListener(text7_5.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       
       StartCoroutine(coroutine);
      
       
       
    }

    // Update is called once per frame
    void Update()
    {
        if(num==1){
            choice.SetActive(false);
            스킵.interactable=false;
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            활성화();
            typingText.text=" ";
            

        
            //StartCoroutine(coroutine1);
        }
     
            
        if(num==5){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            StartCoroutine(coroutine1);
            num++;
            스킵.interactable=false;
            
        }
        if(num==7){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            
            활성화();
            typingText.text=" ";
               //StartCoroutine(coroutine1);
        }

    
        if(num==8){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            StartCoroutine(coroutine2);
            num++;
            스킵.interactable=false;
        }
      
       
        if(num==10){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
           
            // f.SetActive(true);
            활성화();
            typingText.text=" ";    
        }
        if(num==11){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            StartCoroutine(coroutine3);
            num++;
            스킵.interactable=false;   //StartCoroutine(coroutine1);
        }
        if(num==13){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            // f.SetActive(true);
            활성화();
            typingText.text=" ";  
        }
        
        if(num==14){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
             StartCoroutine(coroutine4);
            num++;            
        }
        if(num==16){
            choice1.SetActive(true);
            스킵.interactable=false;
            // f.SetActive(true);
            typingText.text=" "; //StartCoroutine(coroutine1);
        }
        if(num==17){
            StartCoroutine(coroutine5);
            choice1.SetActive(false);
            스킵.interactable=true;
            num++;        
        }
        if(num==20){
            StartCoroutine(coroutine6);
            num++;   //StartCoroutine(coroutine1);
        }
        if(num==22){
            SceneManager.LoadScene("7-6");
        }
        
        


    }
}
