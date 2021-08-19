using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class text_8_8 : MonoBehaviour
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
        num=2;
    }
     public static void b활성화(){
         b_inspection=true;
        num=5;
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

    private static string text_1="어디로 갈까?";
    private static string text_2="시간이 없어!\n지금 안방에 가면 쓰러지기 \n전에 창문을 깰 수 없을 것이다.";
    private static string text_3="밧줄을 다시 한번 단단히 베란다 \n창살에 걸었다. \n몇 번 세게 당겼지만 꿈쩍하지 \n않는다";
    private static string text_4="\"매듭이 풀릴 일은 없겠네.\"";
    private static string text_5="\"운동화 매듭이 고민이신가요? \n드라이브에 \n‘절대 풀리지 않는 매듭을 \n묶는 101가지 방법’\n이라는 기사가 저장되어 있습니다. \n읽어드릴까요?\""; //B선택지연결(변기로간다)
    //C선택지(욕조로 간다)
    private static string text_6="\"사라!\""; //C선택지연결
    private static string text_7="\"부르셨나요? IA-0210님\"";
    private static string text_8="횡설수설하는 사라를 보며 \n나는 한숨을 쉬고 대답 대신 \n커튼을 붙잡고 조심히 베란다를 \n내려가기 시작했다.";
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
     static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);       
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5 = Typing(text_6);
    static IEnumerator coroutine6 = Typing(text_7);
    static IEnumerator coroutine7 = Typing(text_8);
    

 


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

        at.text="A.안방으로 간다.";
        bt.text="B. 2층 베란다로 간다.";
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
       스킵.onClick.AddListener(text_8_8.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
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
            스킵.interactable=false;
            
        }
        if(num==4){
            a.SetActive(true);
            aB.interactable=false;
            b.SetActive(true);
            typingText.text=" ";
            스킵.interactable=false;
            
        }if(num==5){
            스킵.interactable=true;
            a.SetActive(false);
            b.SetActive(false);
            StartCoroutine(coroutine2);
            
               //StartCoroutine(coroutine1);
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
            스킵.interactable=true;
            
        }
        
        if(num==20){
            StartCoroutine(coroutine7);
            num++;
            스킵.interactable=false;
            
        }
        if(num==22){
            SceneManager.LoadScene("8-9");
        }
        
        
        


    }
}
