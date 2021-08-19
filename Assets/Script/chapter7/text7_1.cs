using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class text7_1 : MonoBehaviour
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
        num = 5;

    }
     public static void b활성화(){
        num=35;
    }

    public static void c활성화(){
        num=38;
    }
    public static void d활성화(){
        num=41;
    }
    public static void e활성화(){
        num=47;
    }
    public static void choice활성화(){
        num=3;
    }
    public static void choice1활성화(){
        num=26;
    }

    private static string text_1="아까 구급상자를 찾을 때 \n작업실에서 의수 부품을 본 것 같다.\n우선 정확히 어디에 문제가 \n있는 건지 알려면 의수 손등 \n부분의 덮개를 열어야 한다. \n작업실 어딘가에 \n드라이버가 있을 것이다.";
    private static string text_2="책상 위 연필꽂이에서\n드라이버를 발견했다.\n\n{드라이버를 획득했다.}";
    private static string text_3="드라이버는 여기 없다.";
    private static string text_4="쓰레기통은 그만 뒤지는 \n것이 좋겠어...";
    private static string text_5="스마트 액자엔 동료들과 찍은 \n영상이 5초 간격으로 반복되고 있다. \n사진 속 인물들은 스마트홈 \nAI 본체에 고깔모자를 씌우고 \n생크림 케이크를 먹고 있다.\n모두 즐거워 보여. 심지어 나조차도. \n뭐 때문에 저렇게 즐거웠던 걸까?"; //B선택지연결(변기로간다)
    //C선택지(욕조로 간다)
    private static string text_6="고작 작년 일인 것 같은데 \n기억이 잘 나지 않는다.\n그나저나 아까는 분명 액자 \n전원이 나갔던 것 같은데…."; //C선택지연결
    private static string text_7="의수 부품이 든 상자를 꺼내다 \n그만 떨어뜨리고 말았다.\n\n상자를 열어보니 종류별로 \n정리해둔 의수 부품이 모두 섞였다.\n상자 안에 드라이버도 없는 것 같다.";
    private static string text_8="드라이버를 찾았으니 \n의수 덮개를 열어볼까?";
    private static string text_9="{드라이버와 의수를 조합한다.}";
    private static string text_10="의수 덮개가 열렸다.";
    private static string text_11="{망가진 의수를 획득했다.}\n\n의수 내부를 살펴보니 휘어진 \n내장 칩에서 스파크가 튄다. \n내장 칩은 완전히 갈아야 \n할 것 같다.";
    private static string text_12="손가락 관절 부분도 힘을 너무 \n세게 줘서 접합부가 휘어졌다.\n이럴 땐 접합부를 다시 펴기보단 \n아예 새 관절로 교체하는 편이 낫다.";
    private static string text_13="자체 발전기는 아까 욕조에서 의수 \n덮개가 들리면서 물을 먹은 것 같다.\n발전기는 교체할 예비 부품이 없는데….\n겉에 살짝 물기가 묻은 것 빼곤 \n멀쩡해 보이니 \n일단 물기를 제거해보자.";
    private static string text_15="드라이버를 사용해서 내장 칩과 \n관절, 자체 발전기를 제거했다. \n이제 의수는 완전히 동작을\n멈췄다.\n\n{젖은 자체 발전기를 획득했다.} ";
    private static string text_16="내장 칩이 없으면 뇌에서 나오는 \n전기 신호를 전혀 감지할 수 없어\n아예 의수를 사용할 수 없다. \n어서 내장 칩부터 교체해야 한다.";
    private static string text_17="같은 브랜드의 의수를 계속 \n사용해왔으니 예전에 사용하던 \n의수에서 내장 칩을 얻을 수 \n있을 것이다. ";
   
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
    static IEnumerator coroutine11 = Typing(text_12);
    static IEnumerator coroutine12 = Typing(text_13);       

    static IEnumerator coroutine14 = Typing(text_15);
    static IEnumerator coroutine15 = Typing(text_16);
    static IEnumerator coroutine16 = Typing(text_17);



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

        at.text="(1) 책상";
        bt.text="(2) 반려동물 방석";
        ct.text="(3) Iot 쓰레기통";
        dt.text="(4) 스마트 액자";
        et.text="(5) 책장";
        choicet.text="1. 작업실을 조사한다.";
        choice1t.text="의수를 해체한다.";

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
       스킵.onClick.AddListener(text7_1.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       StartCoroutine(coroutine);
       
       
       
    }

    // Update is called once per frame
    void Update()
    {
        if(num==1){
            choice.SetActive(true);
            스킵.interactable=false;
            활성화();

        
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
            스킵.interactable=true;
            
        }
        
        if(num==8){
            StartCoroutine(coroutine7);
            num++;
        }
       
        if(num==11){
            StartCoroutine(coroutine8);
            num++;     
        }
        if(num==14){
             StartCoroutine(coroutine9);
            num++;            
        }
        if(num==17){
             StartCoroutine(coroutine10);
            num++;            
        }
        if(num==20){
             StartCoroutine(coroutine11);
            num++;            
        }
        if(num==23){
             StartCoroutine(coroutine12);
            num++;  
            스킵.interactable=false;          
        }
        if(num==25){
            choice1.SetActive(true);
        }
        if(num==26){
            choice1.SetActive(false);
            StartCoroutine(coroutine14);
            num++;
        }
        if(num==29){
            StartCoroutine(coroutine15);
            num++;
            스킵.interactable=false;
        }
        if(num==31){
            SceneManager.LoadScene("7-1");
            
        }
        if(num==35){
            StartCoroutine(coroutine2);
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);
            num++;
            스킵.interactable=false;
            
        }
        if(num==37){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            e.SetActive(true);
            활성화();
            typingText.text=" ";
            
            
        }
        if(num==38){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);
            StartCoroutine(coroutine3);
            num++;
            스킵.interactable=false;
        }
        // if(num==41){
        //     StartCoroutine(coroutine4);
        //     num++;
        //     스킵.interactable=false;
        // }
        if(num==40){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            e.SetActive(true);
            활성화();
            typingText.text=" ";
        }
        if(num==41){
            StartCoroutine(coroutine4);
            num++;
            스킵.interactable=true;
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);
        }
        if(num==44){
            StartCoroutine(coroutine5);
            num++;
            스킵.interactable=false;
        }
        if(num==46){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            e.SetActive(true);
            활성화();
            typingText.text=" ";
        }if(num==47){
            StartCoroutine(coroutine6);
            num++;
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);
            스킵.interactable=false;
        }if(num==49){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            e.SetActive(true);
            활성화();
            typingText.text=" ";
            num++;
            스킵.interactable=false;
        }
        
        
        


    }
}
