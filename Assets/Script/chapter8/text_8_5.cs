using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class text_8_5 : MonoBehaviour
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
    //     if(e_inspection==false){
    //         eB.interactable=true;
    //     }else eB.interactable=false;
    //     // if(f_inspection==false){
    //     //     fB.interactable=true;
    //     // }else fB.interactable=false;
    // }

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
        num=2;

    }
     public static void b활성화(){
         b_inspection=true;
        num=40;
    }

    public static void c활성화(){
        SceneManager.LoadScene("8-6");
    }
    public static void d활성화(){
        SceneManager.LoadScene("8-7");
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

    private static string text_1="그런데 계단을 통하지 않고 어떻게 1층 베란다로 내려가지?";
    private static string text_2="여기 서 있어 봐야 가스에 \n질식해 죽을 뿐이다.\n고양이처럼 최대한 몸을 \n둥글게 말고 뛰어내리면 \n괜찮을 거야. ";
    private static string text_3="허리를 훌쩍 넘는 난간에 \n발을 올려 난간 위로 올라갔다.\n올라와 보니 생각보다 높은 것 \n같기도 하고....";
    private static string text_4="가스 차단기가 열려 있어.\n이 불쾌한 냄새의 정체가 \n가스 새는 냄새였다니….\n만약 그대로 1층을 내려갔다면\n이산화탄소에 질식하거나 \n그대로 폭발했을 수도 있다.\n2층에 있는데도 냄새가 점점 \n짙어진다.";
    private static string text_5="나는 고개를 세차게 가로저었다.\n일이 아무리 잘못돼도 이곳에서\n질식하는 것보다는 낫다."; //B선택지연결(변기로간다)
    //C선택지(욕조로 간다)
    private static string text_6="괜찮을 거야. "; //C선택지연결
    private static string text_7="이제 최대한 발을 아래로 해서 \n충격을 줄여...";
    private static string text_8="\"앗!\"";
    private static string text_9="잠시 손을 벽에 뗀 사이에 \n발이 미끄러졌다. \n부질없이 난간을 붙잡으려던 몸이 ";
    private static string text_10="아래로,";
    private static string text_11="아래로 떨어진다.";
    private static string text_12="앞이 보이지 않아.\n생각....\n생각을 해야....\n구조....요청을...\n해야 하는데...";
    private static string text_13="배드 엔딩-추락사\n-한순간의 실수로 모든 것을 \n잃을 수 있습니다.- ";
    private static string text_14="2층에서 쓸만한 걸 찾아보자\n어디를 조사하지?";


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

        // choice = GameObject.Find("choice");
        // choiceB =choice.GetComponent<Button>();
        // choicet = GameObject.Find("choiceText").GetComponent<Text>();
        // choiceB.onClick.AddListener(choice활성화);

        // choice1 = GameObject.Find("choice1");
        // choice1B =choice1.GetComponent<Button>();
        // choice1t = GameObject.Find("choice1Text").GetComponent<Text>();
        // choice1B.onClick.AddListener(choice1활성화);

        at.text="A. 시간이 없다.\n겨우 한 층 높이니 \n뛰어내려 보자";
        bt.text="B. 목이 매캐하고 점점 숨쉬기가 힘들다.\n그래도 뛰어내리는 건 너무 위험해.";
        ct.text="A. 안방을 조사한다.";
        dt.text="B. 작업실을 조사한다. ";
        // et.text="E. 1층 베란다를 살펴본다.";
       
        

        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
    


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
       스킵.onClick.AddListener(text_8_5.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       StartCoroutine(coroutine);
       
       
    }

    // Update is called once per frame
    void Update()
    {
        if(num==1){
            스킵.interactable=false;
            a.SetActive(true);
            b.SetActive(true);
            
            typingText.text=" ";
               //StartCoroutine(coroutine1);
        }
     
            
        if(num==2){
            StartCoroutine(coroutine1);
            a.SetActive(false);
            b.SetActive(false);
            num++;
            스킵.interactable=true;
            
        }
        if(num==5){
            StartCoroutine(coroutine2);
            num++;
            스킵.interactable=true;
            
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
            num++;
            스킵.interactable=true;
            
        }
        if(num==17){
            StartCoroutine(coroutine6);
            num++;
            스킵.interactable=true;
            
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
            
            
        }
        if(num==35){
            StartCoroutine(coroutine12);
            스킵.interactable=false;
            num++;
            
        }
        if(num==40){
            StartCoroutine(coroutine13);
            a.SetActive(false);
            b.SetActive(false);
            num++;
            스킵.interactable=true;
            
            

        
            //StartCoroutine(coroutine1);
        }

        if(num==42){
            c.SetActive(true);
            d.SetActive(true); 
        }
        
        
        
        


    }
}
