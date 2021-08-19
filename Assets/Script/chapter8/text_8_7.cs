using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class text_8_7 : MonoBehaviour
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
    public static bool livingroom= false;
    
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
        num=8;
    }

    public static void c활성화(){
        c_inspection=true;
        num=20;
    }
    public static void d활성화(){
        d_inspection=true;
        num=23;
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

    private static string text_1="작업실로 이동했다.\n\"분명 쓸만한 게 있을 거야.\"";
    private static string text_2="책상 위 연필꽂이엔 아까 \n사용한 드라이버와 연필, 그리고 \n가위가 꽂혀 있다. \n언젠가 쓸일이 있지 않을까?";
    private static string text_3="그렇게 생각하며 \n가위를 집어들었다.\n{가위를 획득했다.}";
    private static string text_4="시루가 방석에서 쉬고 있다.";
    private static string text_5="{고양이 장난감을 반려동물 방석에 사용했다}"; //B선택지연결(변기로간다)
    //C선택지(욕조로 간다)
    private static string text_6="장난감을 시루의 눈 앞에서 \n휘둘러 보았다. \n반응을 보이긴 하지만 힘없이 \n고개만 왔다갔다 할 뿐이다."; //C선택지연결
    private static string text_7="혹시 몰라 고양이 장난감을 \n시루 앞에 두었다.\n{고양이 장남감 삭제}";
    private static string text_8="아무것도 없는 걸 알면서 왜 \n자꾸 쓰레기통을 열어보는 건지.\n너무 바보 같잖아. ";
    private static string text_9="탁자위에 있는 다이어리를 \n펼쳐보았다. ";
    private static string text_10="메모란에 적어둔 \n인공지능 계급론의 \n한 구절이 눈에 띈다.\n‘이건 어디까지나 가정보다는 \n상상에 가까운 일이지만, \n인공지능이 만약 감정을 갖게 \n된다면 인간처럼 그들도 \n계급 사회를 구성할 것이라는 \n사실을 부정할 수는 없다.’";
    private static string text_11="더 이상은 쓸만한 것이 \n없어 보인다. \n지금 쓰러지기 까지 몇분이 \n남았지? ";
    private static string text_12="\"사라?\"";
    private static string text_13="\"8분 7초 남았습니다.”\"";
    private static string text_14="입안에서 욕설이 맴돌았다. \n정말 뛰어내리는 수밖에 없는 건가. ";
    private static string text_15=".....!";
    private static string text_16="허둥지둥 이방 저방 돌아다니다가 \n망연히 작업실을 돌아보는데 \n암막 커튼이 눈에 띄었다. ";
    private static string text_17="적당히 두껍고 손이 미끄러지지 \n않을 정도로 표면이 거치며 내가 \n매달려도 끊어지지 않을 \n튼튼한 천. ";
    private static string text_18="나는 책상 위 가위를 들고 \n암막 커튼을 자르기 시작했다. \n천이 두꺼워 잘 잘리지 않았지만, \n지금은 이 방법뿐이다.\n\n{암막 커튼을 획득했다.}";
    private static string text_19="암막 커튼으로 밧줄을 \n만들어야 한다. \n튼튼하게 묶기 위해서는 \n의수의 힘을 조금 \n빌려야 할 것 같다. ";
    private static string text_20="\"사라!\"";
    private static string text_21="\"6분 32초 남았습니다.\"";
    private static string text_22="{암막커튼과 의수를 조합한다.}";
    private static string text_23="의수의 힘을 빌려\n초등학교 때부터 소방 훈련 \n시간에 지겹도록 배운 두 겹 \n팔자 매듭을 단단히 묶었다.";
    private static string text_24="{밧줄을 획득했다.}";
    private static string text_25="\"살면서 이런 지식을 써먹을 \n일이 생기길 바라진 않았는데.\"";
    private static string text_26="\"이론을 경험에 적용할 때, \n그때서야 비로소 배웠다고 \n할 수 있다. \n철학자 에이바 마틴의 명언입니다. \n지금 바로 사라 버전 26.6이 \n무료로 제공하는 3500개의 \n학습 프로그램을 즐겨보는 건 \n어떠신가요?\"";
    private static string text_27="\"사라. 지금은 그럴 때가 아니야.\"\n\"다행히 사라는 짜증이 가득 담긴 \n목소리를 인식했는지 더는 나를 \n귀찮게 하지 않았다.";
    private static string text_28="나는 황급히 엮은 3미터 길이의 \n암막 커튼을 난간에 묶었다.\n셔츠가 땀으로 흠뻑 젖어 움직일 \n때마다 불쾌하게 끈적거렸다. ";
    private static string text_29="가스 냄새가 독해지면서 머리가 \n멍해지는 것이 느껴진다.";
    private static string text_30="커튼 사이를 돌아다니던 시루의 \n움직임도 둔해졌다.";
    private static string text_31="정신 차리자.";
    private static string text_32="이제 끈을 잡고 내려가기만\n하면 된다.";

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
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
    static IEnumerator coroutine27 = Typing(text_28);
    static IEnumerator coroutine28 = Typing(text_29);
    static IEnumerator coroutine29 = Typing(text_30);
    static IEnumerator coroutine30 = Typing(text_31);       
    static IEnumerator coroutine31 = Typing(text_32);

 


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

        at.text="(1) 책상";
        bt.text="(2) 반려동물 방석";
        ct.text="(3) IoT 쓰레기통";
        dt.text="(4) 탁자";
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
       스킵.onClick.AddListener(text_8_7.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
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
            활성화();
            typingText.text=" ";
               //StartCoroutine(coroutine1);
        }
     
            
        if(num==2){
            StartCoroutine(coroutine1);
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            num++;
            스킵.interactable=true;
            
        }
        if(num==5){
             StartCoroutine(coroutine2);
             num++;
             스킵.interactable=false;
            
        }if(num==7){
            스킵.interactable=false;
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            활성화();
            typingText.text=" ";
               //StartCoroutine(coroutine1);
        }

        if(num==8){
            StartCoroutine(coroutine3);
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            num++;
            스킵.interactable=true;
            
        }
        if(num==10){
            StartCoroutine(coroutine4);
            num++;
            스킵.interactable=true;
            
        }
        if(num==13){
            StartCoroutine(coroutine5);
            num++;
            스킵.interactable=true;
            
        }
        if(num==17){
            StartCoroutine(coroutine6);
            스킵.interactable=false;
            
        }
        if(num==19){
            스킵.interactable=false;
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            활성화();
            typingText.text=" ";
               //StartCoroutine(coroutine1);
        }
        if(num==20){
            StartCoroutine(coroutine7);
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            num++;
            스킵.interactable=false;
            
        }
        if(num==22){
            스킵.interactable=false;
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
            활성화();
            typingText.text=" ";
               //StartCoroutine(coroutine1);
        }
        if(num==23){
            StartCoroutine(coroutine8);
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            num++;
            스킵.interactable=true;
        }
        if(num==26){
            StartCoroutine(coroutine9);
            num++;
        }
        if(num==29){
            if(livingroom==false){
                StartCoroutine(coroutine10);
                 num++;
                 스킵.interactable=true;
            }
            else {num=32;
            스킵.interactable=false;}
           
            
            
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
            num++;     //StartCoroutine(coroutine1);
        }
        if(num==41){
            StartCoroutine(coroutine14);
            num++;
            
        }
        if(num==44){
            StartCoroutine(coroutine15);
            num++;
            
        }
        if(num==47){
            StartCoroutine(coroutine16);
            num++;
            
        }
        if(num==50){
            StartCoroutine(coroutine17);
            num++;
            
        }
        if(num==53){
            StartCoroutine(coroutine18);
            num++;
            
        }
        if(num==56){
            StartCoroutine(coroutine19);
            num++;
            
        }
        if(num==59){
            StartCoroutine(coroutine20);
            num++;
            
        }if(num==62){
            StartCoroutine(coroutine21);
            num++;
            
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
        if(num==80){
            StartCoroutine(coroutine27);
            num++;
            
        }
        if(num==83){
            StartCoroutine(coroutine28);
            num++;    
        }
        if(num==86){
            StartCoroutine(coroutine29);
            num++;    
        }
        if(num==89){
            StartCoroutine(coroutine30);
            num++;    
        }
        if(num==92){
            StartCoroutine(coroutine31);
            num++;    
        }
        if(num==94){
            SceneManager.LoadScene("8-8"); 
        }

        
        
        
        


    }
}
