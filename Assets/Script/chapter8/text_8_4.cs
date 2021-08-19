using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class text_8_4 : MonoBehaviour
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
        if(e_inspection==false){
            eB.interactable=true;
        }else eB.interactable=false;
        // if(f_inspection==false){
        //     fB.interactable=true;
        // }else fB.interactable=false;
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
        Debug.Log("dfd");
        num=2;

    }
     public static void b활성화(){
         b_inspection=true;
        num=5;
    }

    public static void c활성화(){
        c_inspection=true;
        num=44;
    }
    public static void d활성화(){
        d_inspection=true;
        num=47;
    }
    public static void e활성화(){
        e_inspection=true;
        num=50;
    }
    // public static void f활성화(){
    //     f_inspection=true;
    //     num=23;
    // }
    // public static void choice활성화(){
    //     num=1;
    // }
    // public static void choice1활성화(){
    //     num=26;
    // }

    private static string text_1="어디를 살펴볼까?";
    private static string text_2="거실 탁자 위에 휴대전화가 \n아직도 울리고 있다.\n화면에 흐릿하게 \n‘발신자 표시 제한’\n이라는 문구가 보인다. ";
    private static string text_3="레트로 테마로 꾸민 부엌은 \n여느 때처럼 물기 하나 없이 말끔했다. \n어렵게 구한 스마트 가스레인지와 \n철제 싱크대, 아일랜드 식탁과 \n일반형 냉장고까지….\n그런데…. 가스레인지가 어딘가 이상하다. ";
    private static string text_4="가스 차단기가 열려 있어.\n이 불쾌한 냄새의 정체가 \n가스 새는 냄새였다니….\n만약 그대로 1층을 내려갔다면\n이산화탄소에 질식하거나 \n그대로 폭발했을 수도 있다.\n2층에 있는데도 냄새가 점점 \n짙어진다.";
    private static string text_5="나는 급하게 조종간을 내려놓고 \n사라를 불렀다."; //B선택지연결(변기로간다)
    //C선택지(욕조로 간다)
    private static string text_6="\"사라, 지금 가스가 새는 것 같아. \n이산화탄소 중독으로 쓰러지기까지 \n얼마나 남았지?\""; //C선택지연결
    private static string text_7="\"대기 성분 분석 중\"";
    private static string text_8="의수가 빨간빛으로 깜박였다.";
    private static string text_9="사라 RC-492의 소유주, \nIA-0210님이 쓰러지기까지 \n20분 34초 남았습니다.\"";
    private static string text_10="젠장, \n어서 창문을 열어야 한다.";
    private static string text_11="나는 급한 대로 1층으로 \n내려가는 문을 닫았다.\n시루도 이상한 기운을 느꼈는지 \n날카로운 울음소리를 냈다.";
    private static string text_12="생각을 하자.... 생각을.";
    private static string text_13="1층은 내려갈 수 없고 \n2층 창문은 모두 \n스마트 락이 걸려 있다.";
    private static string text_14="게다가 이곳은 고층이라 \n단열 및 안전을 위해 모든 \n창문이 3중 유리거나 2중창이다.\n하나를 깨는 데 성공한다고 해도 \n가스를 제거할 수 없다.";

    private static string text_15="그때 2층 베란다 밑으로 \n1층 베란다가 보였다. \n유일하게 1층 베란다 창문은 \n바로 외부와 연결되어있다.\n그래도 두꺼운 \n유리 방벽이기는 하지만.....\n한 장이라면 시도해볼 만하다.\n1층 베란다 창문을 깰 수만 \n있다면 가스를 모두 뺄 수 \n있을 것이다.";
    private static string text_16="여전히 텅 비어있다.";
    private static string text_17="...괜히 기분만 나빠졌다.";
    private static string text_18="시루가 흘린 핏자국이 굳어 있다.";


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
    static IEnumerator coroutine13 = Typing(text_14);
    static IEnumerator coroutine14 = Typing(text_15);
    static IEnumerator coroutine15 = Typing(text_16);
    static IEnumerator coroutine16 = Typing(text_17);
    static IEnumerator coroutine17 = Typing(text_18);


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

        e = GameObject.Find("e");
        eB =e.GetComponent<Button>();
        et = GameObject.Find("eText").GetComponent<Text>();
        eB.onClick.AddListener(e활성화);

        // f = GameObject.Find("f");
        // fB =f.GetComponent<Button>();
        // ft = GameObject.Find("fText").GetComponent<Text>();
        // fB.onClick.AddListener(f활성화);

        // choice = GameObject.Find("choice");
        // choiceB =choice.GetComponent<Button>();
        // choicet = GameObject.Find("choiceText").GetComponent<Text>();
        // choiceB.onClick.AddListener(choice활성화);

        // choice1 = GameObject.Find("choice1");
        // choice1B =choice1.GetComponent<Button>();
        // choice1t = GameObject.Find("choice1Text").GetComponent<Text>();
        // choice1B.onClick.AddListener(choice1활성화);

        at.text="A. 거실을 살펴본다.";
        bt.text="B. 부엌을 살펴본다.";
        ct.text="C. 게스트룸을 살펴본다.";
        dt.text="D. 게스트룸 화장실을 살펴본다.";
        et.text="E. 1층 베란다를 살펴본다.";
       
        

        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
        e.SetActive(false);
    


        // choice.SetActive(false);
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
        Debug.Log("Scene #8-4 is started");
        //오피스텔 화장실 .img
   
       스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text_8_4.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       StartCoroutine(coroutine);
       
       
    }

    // Update is called once per frame
    void Update()
    {
        if(num==1){
            스킵.interactable=false;
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            e.SetActive(true);
            활성화();
            typingText.text=" ";
               //StartCoroutine(coroutine1);
        }
     
            
        if(num==2){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);
            StartCoroutine(coroutine1);
            num++;
            스킵.interactable=false;
            
        }
        if(num==4){
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
            StartCoroutine(coroutine2);
            스킵.interactable=true;
            num++;
        }
        if(num==8){
            StartCoroutine(coroutine3);
            스킵.interactable=true;
            num++;
        }
      
       
        if(num==11){
            StartCoroutine(coroutine4);
            num++;     
        }
        if(num==14){
            StartCoroutine(coroutine5);
            num++;     
        }
        if(num==17){
            StartCoroutine(coroutine6);
            num++;     
        }
        if(num==20){
            StartCoroutine(coroutine7);
            num++;     
        }
        if(num==23){
            StartCoroutine(coroutine8);
            num++;     
        }
        if(num==26){
            StartCoroutine(coroutine9);
            num++;     
        }
        if(num==29){
            StartCoroutine(coroutine10);
            num++;     
        }

        if(num==32){
            StartCoroutine(coroutine11);
            num++;     
        }
        if(num==35){
            StartCoroutine(coroutine12);
            num++;     
        }
        if(num==38){
            StartCoroutine(coroutine13);
            num++;     
        }
        if(num==41){
            StartCoroutine(coroutine14);
            스킵.interactable=false;
            num++;     
        }
        if(num==43){
           SceneManager.LoadScene("8-5");     
        }
        if(num==44){
            StartCoroutine(coroutine15);
            스킵.interactable=false;
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);
            num++; 
             
        }
        if(num==46){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            e.SetActive(true);
            활성화();
            typingText.text=" ";

        }
        if(num==47){
            StartCoroutine(coroutine16);
            스킵.interactable=false;
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);
            num++;   //StartCoroutine(coroutine1);
        }
        if(num==49){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            e.SetActive(true);
            활성화();
            typingText.text=" ";

        }
        if(num==50){
            StartCoroutine(coroutine17);
            스킵.interactable=false;
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);
            num++;   //StartCoroutine(coroutine1);
        }
        if(num==52){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            e.SetActive(true);
            활성화();
            typingText.text=" ";

        }
        
        
        


    }
}
