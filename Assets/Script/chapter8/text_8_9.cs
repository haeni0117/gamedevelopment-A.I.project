using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class text_8_9 : MonoBehaviour
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
        a_inspection=true;
        num=11;
    }
     public static void b활성화(){
         b_inspection=true;
        num=32;
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

    private static string text_1="손에 힘이 풀려 중간에 한 번 \n커튼을 놓칠 뻔했지만 \n의수 덕분에 다행히 큰 사고 \n없이 1층 베란다로 내려왔다.";
    private static string text_2="불쾌한 기름 냄새가 코를 찌른다.";
    private static string text_3="주변을 둘러봤다. ";
    private static string text_4="이제 창문을 어떻게 깰까?";
    private static string text_5="의수 쪽 손을 쥐었다 폈다."; //B선택지연결(변기로간다)
    //C선택지(욕조로 간다)
    private static string text_6="창문 정도면 깰 수 있을 것 \n같은데?"; //C선택지연결
    private static string text_7="주먹을 꾹 쥐고 의수를 \n내질렀다.";
    private static string text_8="\"생각보다 잘 안 깨지네!\"";
    private static string text_9="몇 번 더 내리치자 창문에 금이 \n갔고 나는 발로 차서 그 틈을 \n넓혔다.";
    private static string text_10="\"후...\"";
    private static string text_11="의수를 불안하게 쳐다봤다. \n망가지진 않았겠지?";
    private static string text_12="나는 생각할 겨를도 없이 \n화분에서 애지중지 키운 \n나무를 뽑고 \n족히 20킬로그램은 나가는 \n철제 화분을 들어 올렸다.";
    private static string text_13="\"의수를 고치길 잘했네.\"";
    private static string text_14="잠시 화분이 깨져서 다치진 \n않을까 걱정이 됐지만,\n이산화탄소에 질식해 \n죽는 것보단 나을 것이다.\n아니, 그래야만 한다.";
    private static string text_15="정확히 15번을 두드린 후에야\n창문에 주먹만 한 구멍이 났다.";
    private static string text_16="깨진 창문 틈 사이로 차가운 \n바람이 들어온다. \n여기가 25층만 아니었다면 \n지나가는 사람을 붙잡고 \n도와달라고 했을 텐데.";
    private static string text_17="하지만 사람이 면봉 크기로 \n보이는 곳에서는 아무리 소리쳐 \n봐야 들리지 않을 것이 분명하다.";
    private static string text_18="아쉬운 마음을 뒤로 하고 \n1층 베란다 문을 열었다";

    
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

        at.text="A. 의수를 써서 깬다.";
        bt.text="B. 화분을 써서 깬다.";
        // ct.text="(3) IoT 쓰레기통";
        // dt.text="(4) 탁자";
        // et.text="E. 1층 베란다를 살펴본다.";
       
        

        a.SetActive(false);
        b.SetActive(false);
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
       스킵.onClick.AddListener(text_8_9.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
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
            스킵.interactable=false;
            
        }
        if(num==10){
            a.SetActive(true);
            b.SetActive(true);
            
        }
        if(num==11){
            a.SetActive(false);
            b.SetActive(false);
            StartCoroutine(coroutine4);
            num++;
            스킵.interactable=true;
            
        }
        if(num==14){
            StartCoroutine(coroutine5);
            스킵.interactable=true;
            
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
            스킵.interactable=false;
            
        }
        if(num==31){
            SceneManager.LoadScene("9-1");
        }
        if(num==32){
            a.SetActive(false);
            b.SetActive(false);
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
            StartCoroutine(coroutine16);
            num++;
            스킵.interactable=true;
        }
        if(num==47){
            StartCoroutine(coroutine17);
            num++;
            스킵.interactable=false;
        }
        if(num==49){
            SceneManager.LoadScene("9-1");
        }
        
        
        


    }
}
