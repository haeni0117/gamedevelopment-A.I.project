using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class text_9_2 : MonoBehaviour
{
    public void FadeIn(float fadeOutTime, System.Action nextEvent = null){
		StartCoroutine(CoFadeIn(fadeOutTime,nextEvent));
	}

	public void FadeOut(float fadeOutTime, System.Action nextEvent = null){
		StartCoroutine(CoFadeOut(fadeOutTime, nextEvent));
	}
    public static int answer_cnt=0;

    public static Text typingText;
    public static GameObject a;
    public static Button aB;
    public static Button 스킵;
    public static Text at;
//(2)반려동물 방석
    public static GameObject b;
    public static Button bB;
    public static Text bt;

    public static GameObject a1;
    public static Button a1B;
    public static Text a1t;
//(2)반려동물 방석
    public static GameObject b1;
    public static Button b1B;
    public static Text b1t;

    public static GameObject a2;
    public static Button a2B;
    public static Text a2t;
//(2)반려동물 방석
    public static GameObject b2;
    public static Button b2B;
    public static Text b2t;
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

    // public static void 활성화(){
    //     if(a_inspection==false){
    //         aB.interactable=true;
    //     }else aB.interactable=false;
    //     if(b_inspection==false){
    //         bB.interactable=true;
    //     }else bB.interactable=false;
    //     if(c_inspection==false){
    //         cB.interactable=true;
    //     }else cB.interactable=false;
    //     if(d_inspection==false){
    //         dB.interactable=true;
    //     }else dB.interactable=false;
        // if(e_inspection==false){
        //     eB.interactable=true;
        // }else eB.interactable=false;
        // if(f_inspection==false){
        //     fB.interactable=true;
        // }else fB.interactable=false;
    //}

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
    public static bool livingroom= false;
    
    public static GameObject fadeout;

     public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
    }
    // public static void 선택지활성화(){
    //     if(a_inspection==false){
    //         aB.interactable=true;
    //     }else aB.interactable=false;
    //     if(b_inspection==false){
    //         bB.interactable=true;
    //     }else bB.interactable=false;
    //     if(c_inspection==false){
    //         cB.interactable=true;
    //     }else cB.interactable=false;
    // }

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
        answer_cnt++;
        num=56;
    }
     public static void b활성화(){
         num=56;
    }
    public static void a1활성화(){
        num=59;
    }
     public static void b1활성화(){
        answer_cnt++;
        num=59;
    }
    public static void a2활성화(){
        answer_cnt++;
        num=62;
    }
     public static void b2활성화(){
         num=62;
         
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

    private static string text_1="거실에 돌아오니 아까와 달리 \n조명이 침침하게 느껴진다.\n햇볕에 따라 조도를 자동으로 \n조절해주는 기능마저 \n먹통이 된 것 같다.\n창밖엔 먹구름이 잔뜩 껴서 \n해가 거의 저물었다.\n벌써 시간이 이렇게 된 건가….\n폭우가 쏟아질 것만 같다. ";
    private static string text_2="갑자기 빗소리가 \n들리기 시작했다.";
    private static string text_3="사고가 일어나기 전에는 \n폭풍우가 치는 밤마다 \n곧잘 망망대해 한가운데를 \n표류하는 커다란 여객선 객실에\n누워있다고 상상하곤 했다.\n태어나서 단 한 번도 \n바다를 직접 본 적은 없지만,\n웅장한 뱃고동 소리와 \n흐드러진 파도 소리를 상상하면\n이유를 알 수 없는 \n편안함이 느껴졌다.";
    private static string text_4="하지만 사고 이후로 \n모든 빗소리는....,\n그저 인생을 뒤튼 \n재앙의 상징이 되었을 뿐이다.";
    private static string text_5="서늘한 공기가 느껴지자\n자연스럽게 몸이 움츠러들었다. \n가을의 끝자락에서 쏟아지는 비는 \n온기가 없던 거실에 \n한기를 몰고 왔다. "; //B선택지연결(변기로간다)
    //C선택지(욕조로 간다)
    private static string text_6="서늘한 공기와 빗소리 사이로\n정체를 알 수 없는 \n불쾌한 소리들이 \n머릿속을 헤집고, \n매캐한 기름 냄새가 \n코를 찌른다. "; //C선택지연결
    private static string text_7="\"사라....\"";
    private static string text_8="\"네, IA-0210님. 부르셨습니까?\"";
    private static string text_9="\"집에서.... \n집에서 또 기름 냄새가 나.\"";
    private static string text_10="\"도시복합체 52동-(나)길 \n563호에서 화재 신호를 \n감지하지 못했습니다. \n기름 냄새가 나는 \n다른 원인으로는...\"";
    private static string text_11="\"기름 타는 냄새가 난다니까, \n사라! 지금 이 소리가 안 들려? \n구급차 소리, 빗소리, \n그리고 경적...\"";
    private static string text_12="손발이 오그라들고 \n식은땀이 난다.";
    private static string text_13="\"숨을 쉴 수 없어...\"";
    private static string text_14="\"사라 RC-492, \n불안 발작 완화 프로세스를 \n시작합니다\'";
    private static string text_15="\"무슨 소리야, 사라. \n지금 자동차에 불이 났다니까! \n피가, 피가 보여...\n안돼, 제발...\"";
    private static string text_16="\"심호흡 하시고 \n제 질문에 집중하세요. \n현재 시각은 오후 3시 반, \n오늘 날씨는 맑고 화창합니다\"";
    private static string text_17="\"안전벨트가, 안전벨트 때문에 \n이렇게 될 줄 몰랐어요. \n제발, 잘못했어요. \n앞으로 안 그럴게요\"";
    private static string text_18="\"...당신은 안전합니다. \n흉곽이 부풀어 오르도록 \n숨을 들이마시고, \n제 질문에 집중하세요\"";
    private static string text_19="[ 질문 1 : IA-0210님은 지금 어디에 계십니까? ]";
    private static string text_20="[ 질문 2 : 지금 날씨는 어떻습니까? ]";    
    private static string text_21="[ 질문 3 : 마지막 질문입니다. \n저는 누구인가요? ]";
    private static string text_22="사라의 목소리가 \n귓바퀴를 맴돌다 흩어진다.\n눈보라 속에 \n파묻힌 것만 같다.";
    private static string text_23="폭우, 한기, 비릿한 피 냄새, \n그리고 매지 않은 안전벨트...\n어쩌면 이 모든 건 \n내가 만들어 낸 \n환상일지도 몰라.\n하지만 그렇다고 해서\n뭐가 달라지지?";
    private static string text_24="오빠는 죽었고, 부모님은 \n하나 남은 딸을 원망하고, \n나는 이곳에 갇혔다.\n이제 와서 돌이킬 수 있는 건 \n아무것도 없어.";
    private static string text_25="...죄송합니다. \n하지만 저는 제 행동을 \n후회하지 않습니다. \n화이님 잘못이 아닙니다.\n이 모든 것은 다...";
    private static string text_26="나는 진실을 분간할 수 없는 \n고통 속에 몸을 맡기고 \n조용히 눈을 감았다.";
    private static string text_27="-후회로 뒤엉킨 과거 대신 \n현재에 집중해야 할 때입니다.-";
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
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
    static IEnumerator coroutine18 = Typing(text_19);
    static IEnumerator coroutine19 = Typing(text_20);       
    static IEnumerator coroutine20 = Typing(text_21);
    static IEnumerator coroutine21 = Typing(text_22);
    static IEnumerator coroutine22 = Typing(text_23);
    static IEnumerator coroutine23 = Typing(text_24);
    static IEnumerator coroutine24 = Typing(text_25);
    static IEnumerator coroutine25 = Typing(text_26);
    static IEnumerator coroutine26 = Typing(text_27);
    // static IEnumerator coroutine27 = Typing(text_28);
    
    

 


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

        a1 = GameObject.Find("a1");
        a1B =a1.GetComponent<Button>();
        a1t = GameObject.Find("a1Text").GetComponent<Text>();
        a1B.onClick.AddListener(a1활성화);

        b1 = GameObject.Find("b1");
        b1B =b1.GetComponent<Button>();
        b1t = GameObject.Find("b1Text").GetComponent<Text>();
        b1B.onClick.AddListener(b1활성화);

        a2 = GameObject.Find("a2");
        a2B =a2.GetComponent<Button>();
        a2t = GameObject.Find("a2Text").GetComponent<Text>();
        a2B.onClick.AddListener(a2활성화);

        b2 = GameObject.Find("b2");
        b2B =b2.GetComponent<Button>();
        b2t = GameObject.Find("b2Text").GetComponent<Text>();
        b2B.onClick.AddListener(b2활성화);

        // c = GameObject.Find("c");
        // cB =c.GetComponent<Button>();
        // ct = GameObject.Find("cText").GetComponent<Text>();
        // cB.onClick.AddListener(c활성화);

        // d = GameObject.Find("d");
        // dB =d.GetComponent<Button>();
        // dt = GameObject.Find("dText").GetComponent<Text>();
        // dB.onClick.AddListener(d활성화);

        // e = GameObject.Find("e");
        // eB =e.GetComponent<Button>();
        // et = GameObject.Find("eText").GetComponent<Text>();
        // eB.onClick.AddListener(e활성화);

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

        at.text="내 집. \n도시복합체 52동 563호.";
        bt.text="어딘지 모르겠어.\n여기는 비가 오고....,\n너무 추워.";
        
        a1t.text="폭우가 내리고 있어. \n바람도 많이 불고...천둥도 쳐.";
        b1t.text="기온은 낮지만...,\n청명하게 맑은 날씨야.";

        a2t.text="모델명 RC-492";
        b2t.text="모델명 KM-468";


        // ct.text="(3) IoT 쓰레기통";
        // dt.text="(4) 탁자";
        // et.text="E. 1층 베란다를 살펴본다.";
       
        

        a.SetActive(false);
        b.SetActive(false);
        a1.SetActive(false);
        b1.SetActive(false);
        a2.SetActive(false);
        b2.SetActive(false);
        // c.SetActive(false);
        // d.SetActive(false);
    


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
        Debug.Log("Scene #8-8 is started");
        //오피스텔 화장실 .img
   
       스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text_9_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       StartCoroutine(coroutine);
       스킵.interactable=true;
       
    }

    // Update is called once per frame
    void Update()
    {
        if(num==2){
            스킵.interactable=true;
            StartCoroutine(coroutine1);
            num++;
               //StartCoroutine(coroutine1);
        }   
        if(num==5){
            스킵.interactable=true;
            num++;
            StartCoroutine(coroutine2);  //StartCoroutine(coroutine1);
        }

        if(num==8){
            StartCoroutine(coroutine3);
            num++;
            스킵.interactable=true;
            
        }
        if(num==11){
            StartCoroutine(coroutine4);
            num++;
            스킵.interactable=true;
            
        }
        if(num==14){
            StartCoroutine(coroutine5);
            스킵.interactable=true;
            num++;
            
        }
        if(num==17){
            StartCoroutine(coroutine6);
            스킵.interactable=true;
            num++;
            
        }
        if(num==20){
            StartCoroutine(coroutine7);
            num++;
            스킵.interactable=true;
            
        }
        if(num==23){
            StartCoroutine(coroutine8);
            num++;
            스킵.interactable=true;
            
        }
        if(num==26){
            StartCoroutine(coroutine9);
            num++;
            스킵.interactable=true;
            
        }
        if(num==29){
            StartCoroutine(coroutine10);
            num++;
            스킵.interactable=true;
            
        }
        if(num==32){
            StartCoroutine(coroutine11);
            num++;
            스킵.interactable=true;
        }
        if(num==35){
            StartCoroutine(coroutine12);
            num++;
            스킵.interactable=true;
        }
        if(num==38){
            StartCoroutine(coroutine13);
            num++;
            스킵.interactable=true;
        }
        if(num==41){
            StartCoroutine(coroutine14);
            num++;
            스킵.interactable=true;
        }
        if(num==44){
            StartCoroutine(coroutine15);
            num++;
            스킵.interactable=true;
        }
        if(num==47){
            StartCoroutine(coroutine16);
            num++;
            스킵.interactable=true;
        }
        if(num==50){
            StartCoroutine(coroutine17);
            num++;
            스킵.interactable=true;
        }
        if(num==53){
            StartCoroutine(coroutine18);
            스킵.interactable=false;
            num++;
        }
        if(num==55){
            a.SetActive(true);
            b.SetActive(true);
            스킵.interactable=false;

        }
        if(num==56){
             StartCoroutine(coroutine19);
             a.SetActive(false);
            b.SetActive(false);
             num++;
        }
        if(num==58){
            a1.SetActive(true);
            b1.SetActive(true);
            스킵.interactable=false;
        }
        if(num==59){
             StartCoroutine(coroutine20);
             a1.SetActive(false);
            b1.SetActive(false);
             num++;
        }
        if(num==61){
            a2.SetActive(true);
            b2.SetActive(true);
            스킵.interactable=false;
        }
        if(num==62){
            if(answer_cnt>=2){
                SceneManager.LoadScene("9-3");
            }else{StartCoroutine(coroutine21);
            a2.SetActive(false);
            b2.SetActive(false);
            스킵.interactable=true;
             num++;}
        }
        if(num==65){
             StartCoroutine(coroutine22);
             num++;
        }
        if(num==68){
             StartCoroutine(coroutine23);
             num++;
        }
        if(num==71){
             StartCoroutine(coroutine24);
             num++;
        }
        if(num==74){
             StartCoroutine(coroutine25);
             num++;
        }
        if(num==77){
             StartCoroutine(coroutine26);
             num++;
        }
        if(num==79){
            //게임종료화면
        }
        
        
        


    }
}
