using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class text6_5 : MonoBehaviour
{
    public void FadeIn(float fadeOutTime, System.Action nextEvent = null){
		StartCoroutine(CoFadeIn(fadeOutTime,nextEvent));
	}

	public void FadeOut(float fadeOutTime, System.Action nextEvent = null){
		StartCoroutine(CoFadeOut(fadeOutTime, nextEvent));
	}
    public static void scenechange(){
        SceneManager.LoadScene("7-0");
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
    public static bool a_inspection=false;
    public static bool b_inspection= false;
    public static bool c_inspection= false;


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
        num = 2;

    }
     public static void b활성화(){
        num=14;
    }

    public static void c활성화(){
        num=44;
    }
    public static void d활성화(){
        num=62;
    }

    private static string text_1="침착하게 생각한다. \n\"침착해야 해. \n생각..... 생각을 해보자. \n분명 여기를 탈출할 \n방법이 있을 거야.\"";
    private static string text_2="다행히 반신욕용 덮개라 \n팔만 겨우 빠져나갈 정도의 \n틈이 있었다.\n의수를 쓴다면 덮개를 \n뜯어낼 수 있을지도 모른다.  ";
    private static string text_3="하지만 정말 \n그 방법밖에 없는 걸까…?";
    private static string text_4="심호흡하면서 \n마음을 가다듬었다. \n분명 지금 상황을 해결할\n방법이 있을 것이다.";
    private static string text_5="물이 빠르게 차오른다. \n여기서 더 시간을 끌었다가는 \n살아남기 힘들 것이다. \n물이 코끝을 간지럽히고 \n숨을 들이마실 때마다 \n물이 들어와서 코가 찡했다. \n더는 시간을 지체할 수 없었다. \n나는 욕조 덮개 틈 사이로 \n의수를 밀어 넣고 힘을 줬다. \n처음에는 꼼짝하지 않던 \n덮개 끝부분이 조금씩 들썩이다가 \n완전히 벌어졌다. "; //B선택지연결(변기로간다)
    //C선택지(욕조로 간다)
    private static string text_6="덮개가 들리자마자 \n틈 사이로 몸을 빼냈다. \n머리카락까지 적신 물이 \n욕조 덮개 틈 사이로 넘쳐흘렀다. \n힘을 너무 세게 준 탓인지 \n손바닥과 손가락이 이어지는 \n부분이 약간 휘었다.\n감각이 둔해지고 손목이 저릿했다."; //C선택지연결
    private static string text_7="의수를 사용했다. 의수-1 ";
    private static string text_8="의수를 쥐었다 펴니\n오랫동안 기름칠을 하지 않은 \n기계처럼 손가락 마디마디가 \n부자연스러웠다. \n제대로 움직이지 않는 의수의 \n손가락 관절 부분을 매만지는데 \n다시 의수에서 소리가 들렸다. ";
    private static string text_9="\"괜찮...? 제 목소리... 들...요?\"";
    private static string text_10="이건 분명 카라의 목소리인데....\n카라가 갑자기 이렇게 친절하게\n말을 걸 리가 없다.\n그것도 의수를 통해서. \n도대체 누구지?";
    private static string text_11="의수에 문제가 생긴 걸까? \n대화가 원활하지 않다. ";
    private static string text_12="하지만 사라와 \n대화가 가능하다면....,\n그러면 인터넷에 연결해서 \n구조 신호를 보낼 수 있다.\n어쩌면 사라를\n복구하는 것이\n여길 탈출할 수 있는\n유일한 방법일지도 모른다.";
    private static string text_13="어서 의수를 고쳐야 해.\n아까 의수 부품을 어디서 발견했더라? ";
    private static string text_15="화장실에 누군가 갇혔을 \n때를 고려해 일정 시간 이상 \n인간의 생체 반응이 \n확인되지 않으면 \n화장실 문과 욕조 덮개가 \n열리게 되어있다.";
    private static string text_16="물이 코끝을 간지럽히고 \n숨을 들이마실 때마다 \n물이 들어와서 코가 찡했다. \n이대로 죽을지도 모른다는 \n공포가 온몸을 휩쓸었다.\n하지만 이제는 운명의 신에 \n목숨을 맡기는 수밖에. \n나는 물이 얼굴을 완전히 \n덮어버리기 전에 마지막으로 \n숨을 크게 들이쉬었다.";
    private static string text_17="얼마만큼의 시간이 지났을까? \n이제는 정말 버티기 어렵다고 \n생각할 즈음 욕조 덮개가 \n저절로 열렸다.";
    private static string text_18="나는 물속에서 빠져나와 \n차가운 타일 바닥 위에 엎어져서 \n숨을 골랐다.\n욕조에서 빠져나오니 또다시\n의수에서 파란 불빛이 번쩍였다.\"";
    private static string text_19="괜찮...? 제 목소리...들...요?";
    private static string text_20="설마 이건...\n사라의 목소리인가?";
    private static string text_21="좁은 욕조에 갇혀 죽기만을 \n기다릴 수는 없다. \n가능성이 적다는 건 알고 있지만, \n카라를 부르는 것 말고는 \n방법이 없어.";
    private static string text_22="\"카라! 꺼내줘! \n물이 차오르고 있어! \n카라! 제발.....\"";
    private static string text_23="물이 점점 더 차오른다. \n이제 정말 숨을 쉬기가 버거웠다.\n카라를 부를수록 더 많은 양의 \n물이 목과 코를 침범했다. \n나는 마지막 숨을 토해내면서 \n카라의 이름을 불렀지만, \n카라는 역시 대답이 없다.";
    private static string text_24="\"카라...!\"";
    private static string text_25="배드 엔딩 – 맹목적 신뢰 \n\"과도한 믿음은 \n죽음을 초래하기도 하죠.\"";
    
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
    static IEnumerator coroutine17 = Typing(text_18);
    static IEnumerator coroutine18 = Typing(text_19);
    static IEnumerator coroutine19 = Typing(text_20);
    static IEnumerator coroutine20 = Typing(text_21);
    static IEnumerator coroutine21 = Typing(text_22);
    static IEnumerator coroutine22 = Typing(text_23);
    static IEnumerator coroutine23 = Typing(text_24);
    static IEnumerator coroutine24 = Typing(text_25);


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

        at.text="A.침착하게 생각한다.";
        ct.text="A.의수를 사용한다.";
        dt.text="B.숨을 참고 버틴다.";
        bt.text="B.카라를 부른다.";

        a.SetActive(true);
        b.SetActive(true);
        c.SetActive(false);
        d.SetActive(false);

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
        Debug.Log("Scene 6-3 is started");
        //오피스텔 화장실 .img
   
       스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text6_5.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       
       
    }

    // Update is called once per frame
    void Update()
    {
        if(num==2){
            StartCoroutine(coroutine);
            a.SetActive(false);
            b.SetActive(false);
            num++;
            스킵.interactable=true;
            //StartCoroutine(coroutine1);
        }
        // if(num==4){
        //     a.SetActive(true);
        //     b.SetActive(true);
        //     c.SetActive(true);
        //     선택지활성화();
            
        // }
        if(num==5){
            StartCoroutine(coroutine1);
            num++;
            
        }
        
        if(num==8){
            
            StartCoroutine(coroutine2);
            num++;
        }
       
        if(num==11){
            StartCoroutine(coroutine3);
            num++;
            스킵.interactable=false;
            
            
        }
        if(num==13){
            c.SetActive(true);
            d.SetActive(true);
            typingText.text="";
            스킵.interactable=false;
        }
        if(num==14){
            c.SetActive(false);
            d.SetActive(false);
            StartCoroutine(coroutine4);
            스킵.interactable=true;
            num++;
        }
        if(num==20){
            StartCoroutine(coroutine5);
            num++;
        }
        if(num==23){
            StartCoroutine(coroutine6);
            num++;
        }
        if(num==26){
            StartCoroutine(coroutine7);
            num++;
        }
        if(num==29){
            StartCoroutine(coroutine8);
            num++;
        }
        if(num==32){
            StartCoroutine(coroutine9);
            num++;
        }
        if(num==35){
            StartCoroutine(coroutine10);
            num++;
        }
        if(num==38){
            StartCoroutine(coroutine11);
            num++;
            
        }
        if(num==41){
            StartCoroutine(coroutine12);
            num++;
            스킵.interactable=false;
        }
        if(num==43){
            SceneManager.LoadScene("7-0");
        }
        if(num==44){
            StartCoroutine(coroutine14);
            c.SetActive(false);
            d.SetActive(false);
            num++;
            스킵.interactable=true;
        }
        if(num==47){
            StartCoroutine(coroutine15);
            num++;
            스킵.interactable=true;
        }
        if(num==50){
            StartCoroutine(coroutine16);
            num++;
        }
        if(num==53){
            StartCoroutine(coroutine17);
            num++;
        }
        if(num==56){
            StartCoroutine(coroutine18);
            num++;
        }
        if(num==59){
            StartCoroutine(coroutine19);
            num++;
            스킵.interactable=false;
        }
        if(num==61){
           SceneManager.LoadScene("7-0");
        }
        if(num==62){
            StartCoroutine(coroutine20);
            num++;
            a.SetActive(false);
            b.SetActive(false);
            스킵.interactable=true;
        }
        if(num==65){
            StartCoroutine(coroutine21);
            num++;
        }
        if(num==68){
            StartCoroutine(coroutine22);
            num++;
            
        }
        if(num==71){
            StartCoroutine(coroutine23);
            num++;
            스킵.interactable=true;
            
        }
        if(num==74){
            StartCoroutine(coroutine24);
            num++;
            스킵.interactable=true;
        }
        if(num==76){
            SceneManager.LoadScene("7-0");
            
        }
        
        


    }
}
