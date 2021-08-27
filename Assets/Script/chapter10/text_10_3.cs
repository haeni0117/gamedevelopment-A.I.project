using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class text_10_3 : MonoBehaviour
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
        num = 2;

    }
     public static void b활성화(){
        num=5;
        b_inspection=true;
    }

    public static void c활성화(){
        num=8;
        c_inspection=true;

    }
    public static void d활성화(){
        num=11;
        d_inspection=true;
    }
    // public static void d1활성화(){
    //     num=11;
    // }
    // public static void d2활성화(){
    //     num=11;
    // }
    // public static void d3활성화(){
    //     num=11;
    // }
    // public static void e활성화(){
    //     num=47;
    // }
    // public static void choice활성화(){
    //     num=3;
    // }
    // public static void choice1활성화(){
    //     num=26;
    // }

    private static string text_1="완전히 부서져서 조각난 \n부품들이 바닥에 나뒹굴었다.\n밟지 않도록 조심해야지. ";
    private static string text_2="시루가 자고 있다. \n빨리 탈출해야 하는데...\n손바닥이 축축해지고 \n가슴이 답답하다.";
    private static string text_3="해가 옅어지고 있다. \n밤이 오기 전에 이곳을 \n빠져나가야 한다.";
    private static string text_4="작업실 컴퓨터 바탕화면에 \n자이나 사의 로고가 깜빡거린다.\n아빠는 캐니언 오토사가 \n파산한 후 캐니언 V6에 사용되던 \n판단 및 의사결정 프로그램은 \n전량 폐기되어 다시는 사회에\n사용될 일이 없다고 말씀하셨다.";
    private static string text_5="하지만 사라의 말대로 \nV6의 알고리즘이 \n자이나 사의 스마트홈이라면, \n캐니언 오토사는 왜 그 사실을 \n언론에 발표하지 않은 걸까? \n그랬다면 파산만은 \n면할 수 있었을 텐데….\n머릿속이 혼란스럽다."; //B선택지연결(변기로간다)
    //C선택지(욕조로 간다)
    private static string text_6="사라를 카라에게 보내기 위해서는\n이 컴퓨터에 인공지능 코어를 \n연결하면 된다. "; //C선택지연결
    private static string text_7="{AI코어를 작업실 컴퓨터에 사용했다.}";
    private static string text_8="컴퓨터 OS를 인공지능 자가\n진단 모드로 변경하고 \n창고에서 가져온 코어를  \n컴퓨터에 연결했다.\n코어가 너무 예전 모델이라 \n컴퓨터가 인식하지 \n못하는 것 같다.\n다른 방법이 없을까?";
    private static string text_9="{변환 젠더와 AI코어를 조합했다}";
    private static string text_10="화장실에서 발견한 \n연결 젠더를 챙겨두길 잘했다. \n버전 별 호환이 가능한 \n젠더에 연결하니 \n모니터에‘RC-492’라는 \n코드명이 깜빡거린다. ";
    private static string text_11="{구버전 사라를 획득했다!}\n이제 구버전 사라를 컴퓨터에\n연결하자.";
    private static string text_12="{구버전 사라를 작업실 컴퓨터에 사용했다}";
    private static string text_13="현관문 잠금부터 \n전자기기 통신 제어권까지 \n전기가 연결된 모든 것들을 \n조절하는 권한이 \nKM-468에 묶여 있다. ";
    private static string text_14="권한을 한꺼번에 되찾아오는 \n마스터 키를 입력했지만 \n역시나 듣지 않는다. \n각 권한에 알맞은 코드를 입력해 \n하나씩 권한을 \n되찾아와야 할 것 같다. ";
    
   
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

    static IEnumerator coroutine13 = Typing(text_14);
    


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

        // d1 = GameObject.Find("d1");
        // d1B =d1.GetComponent<Button>();
        // d1t = GameObject.Find("d1Text").GetComponent<Text>();
        // d1B.onClick.AddListener(d1활성화);

        // d2 = GameObject.Find("d2");
        // d2B =d2.GetComponent<Button>();
        // d2t = GameObject.Find("d2Text").GetComponent<Text>();
        // d2B.onClick.AddListener(d2활성화);

        // d3 = GameObject.Find("d3");
        // d3B =d3.GetComponent<Button>();
        // d3t = GameObject.Find("d3Text").GetComponent<Text>();
        // d3B.onClick.AddListener(d3활성화);

        // e = GameObject.Find("e");
        // eB =e.GetComponent<Button>();
        // et = GameObject.Find("eText").GetComponent<Text>();
        // eB.onClick.AddListener(e활성화);

        // choice = GameObject.Find("choice");
        // choiceB =choice.GetComponent<Button>();
        // choicet = GameObject.Find("choiceText").GetComponent<Text>();
        // choiceB.onClick.AddListener(choice활성화);

        // choice1 = GameObject.Find("choice1");
        // choice1B =choice1.GetComponent<Button>();
        // choice1t = GameObject.Find("choice1Text").GetComponent<Text>();
        // choice1B.onClick.AddListener(choice1활성화);

        at.text="(1) 의자 조사";
        bt.text="(2) 반려동물 방석 조사";
        ct.text="(3) 2층 베란다 창문 조사";
        dt.text="(4) 작업실 컴퓨터조사";
        // d1t.text="{‘AI코어’ 작업실 컴퓨터에 사용}";
        // d2t.text="[연결 젠더+AI코어 조합]\n구버전 사라 획득";
        // d3t.text="[‘구버전 사라’ 사용]";
        // // et.text="(5) 책장";
        // choicet.text="1. 작업실을 조사한다.";
        // choice1t.text="의수를 해체한다.";

        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
        // d1.SetActive(false);
        // d2.SetActive(false);


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
       스킵.onClick.AddListener(text_10_3.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       a.SetActive(true);
       b.SetActive(true);
       c.SetActive(true);
       d.SetActive(true);
       
       
       
    }

    // Update is called once per frame
    void Update()
    {
        if(num==2){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            StartCoroutine(coroutine);
            num++;
            스킵.interactable=false;
            활성화();

        
            //StartCoroutine(coroutine1);
        }
        if(num==4){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            활성화();
            typingText.text=" ";
            스킵.interactable=false;
            

        
            //StartCoroutine(coroutine1);
        }
        if(num==5){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            StartCoroutine(coroutine1);
            num++;
            choice.SetActive(false);
            스킵.interactable=false;
            
        }
        if(num==7){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            활성화();
            typingText.text=" ";
            스킵.interactable=false;
            

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
            활성화();
            typingText.text=" ";
            스킵.interactable=false;    
        }
        if(num==11){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            StartCoroutine(coroutine3);
            num++;
            스킵.interactable=true;         
        }
        if(num==14){
           StartCoroutine(coroutine4);
            num++;
            스킵.interactable=true;           
        }
        if(num==17){
             StartCoroutine(coroutine5);
             스킵.interactable=true;
            num++;            
        }
        if(num==20){
             StartCoroutine(coroutine6);
             스킵.interactable=true;
            num++;            
        }
        if(num==23){
             StartCoroutine(coroutine7);
             스킵.interactable=true;
            num++;            
        }if(num==26){
             StartCoroutine(coroutine8);
             스킵.interactable=true;
            num++;            
        }
        if(num==29){
             StartCoroutine(coroutine9);
             스킵.interactable=true;
            num++;            
        }
        if(num==32){
             StartCoroutine(coroutine10);
             스킵.interactable=true;
            num++;            
        }
        if(num==35){
             StartCoroutine(coroutine11);
             스킵.interactable=true;
            num++;            
        }
        if(num==38){
             StartCoroutine(coroutine12);
             스킵.interactable=true;
            num++;            
        }
        if(num==41){
             StartCoroutine(coroutine13);
             스킵.interactable=false;
            num++;            
        }
        if(num==43){
             SceneManager.LoadScene("10-4");          
        }
        // if(num==19){
        //      d1.SetActive(true);
        //      d2.SetActive(true);   
        //      d3.SetActive(true);
        //      스킵.interactable=false;        
        // }
        // if(num==20){
        //     d1.SetActive(false);
        //     d2.SetActive(false);   
        //     d3.SetActive(false);
        //     StartCoroutine(coroutine6);
        //     스킵.interactable=true;
        //     num++;  
        // }
        // if(num==23){ 
        //     StartCoroutine(coroutine7);
        //     스킵.interactable=false;
        //     num++;
        // }
        // if(num==25){
        //     d1.SetActive(true);
        //     d2.SetActive(true);   
        //     d3.SetActive(true);
        //     활성화2();
        //     스킵.interactable=false;  
        //     typingText.text=" "; 
        // }
        // if(num==26){
        //     d1.SetActive(false);
        //     d2.SetActive(false);   
        //     d3.SetActive(false);
        //     StartCoroutine(coroutine8);
        //     스킵.interactable=true;
        //     num++;  
            
        // }
        // if(num==29){
        //     StartCoroutine(coroutine9);
        //     num++;
        //     스킵.interactable=true;
            
        // }
        // if(num==32){
        //     StartCoroutine(coroutine10);
        //     num++;
        //     스킵.interactable=false;
            
        // }
        // if(num==34){
        //     d1.SetActive(true);
        //     d2.SetActive(true);   
        //     d3.SetActive(true);
        //     활성화2();
        //     스킵.interactable=false;   
        //     typingText.text=" ";
            
            
        // }
        // if(num==35){
        //     d1.SetActive(false);
        //     d2.SetActive(false);   
        //     d3.SetActive(false);
        //     StartCoroutine(coroutine11);
        //     스킵.interactable=true;
        //     num++;  
    
        // }
        // if(num==38){
        //     StartCoroutine(coroutine12);
        //     num++;
        //     스킵.interactable=true;
            
        // }
        // if(num==41){
        //     StartCoroutine(coroutine13);
        //     num++;
        //     스킵.interactable=false;
            
        // }
        // if(num==43){
        //     SceneManager.LoadScene("10-4");
        // }
        


    }
}
