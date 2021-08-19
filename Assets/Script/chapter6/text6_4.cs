using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class text6_4 : MonoBehaviour
{
    public void FadeIn(float fadeOutTime, System.Action nextEvent = null){
		StartCoroutine(CoFadeIn(fadeOutTime,nextEvent));
	}

	public void FadeOut(float fadeOutTime, System.Action nextEvent = null){
		StartCoroutine(CoFadeOut(fadeOutTime, nextEvent));
	}
    public static void scenechange(){
        SceneManager.LoadScene("6-3-1");
    }
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
    public static Text typingText; 
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
        Text typingText = GameObject.Find("general text").GetComponent<Text>();
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
        num=8;
    }

    public static void c활성화(){
        num=11;
    }

    private static string text_1="화장실에 들어왔지만, \n여전히 숨이 턱턱 막힌다.\n오빠의 우주비행사 인형, 아로….\n분명히 장례식 날 \n관 위에 올려진 걸 봤는데\n도대체 이게 여기 왜….\n드디어 정말 내가 \n미쳐 버린 건가? ";
    private static string text_2="머릿속에 경고등이 울리고, \n호흡은 전혀 나아질 기미가 보이지 않는다. ";
    private static string text_3="안정을 찾으려면 \n더 좁은 공간으로 \n이동해야 해!";
    private static string text_4="안정을 찾을 만한 공간은 \n아닌 것 같다.";
    private static string text_5="욕조로 뛰어 들어가 \n몸을 옹송그리고\n눈을 꼭 감았다."; //B선택지연결(변기로간다)
    //C선택지(욕조로 간다)
    private static string text_6="하나, 들이마시고\n내쉰다"; //C선택지연결
    private static string text_7="하나, 들이마시고\n내쉰다";
    private static string text_8="사방이 막힌 느낌이 내게 \n서서히 안정감을 가져왔다.";
    private static string text_9="'갑자기 불안감이 몰려올 땐\n눈을 감고 숨을 크게 쉬어요.\n그러면 눈앞에 파란 점이\n하나 보일거에요.\n그 빛을 향해 계속 걸어가요.\n급하지도 느리지도 않게,\n한 발짝 한 발짝...'' ";
    private static string text_10="머릿속에 떠오른\n유년기의 나를 안심시켜주던\n사라의 차분한 목소리를\n되뇌었다. 요동치던 심장이 \n가라앉는 것이 느껴졌다. \n파란 점을 향해, \n한 발짝, 한 발짝....";
    private static string text_11="\"으악!\"";
    private static string text_12="갑자기 차가운 물이 느껴져서 \n눈을 번쩍 떴다. \n빠른 속도로 욕조에 \n물이 차오르고 있었다.\n허둥거리며 몸을 일으키려 했지만, \n두꺼운 벽에 뒤통수를 부딪쳤다. \n손을 뻗어 겨우 벽을 만져보니 \n우둘투둘한 문양의 \n욕조 덮개가 느껴졌다.\n반신욕을 할 때 사용하는 \n욕조 덮개였다.";
    private static string text_13="욕조 밖에서 시루의 \n당황한 울음소리가 들렸다. ";
    private static string text_14="이제 어떡하지?";
    
    
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

        at.text="A.침착하게 생각한다.";
        bt.text="A.의수를 사용한다.";
        ct.text="B.숨을 참고 버틴다.";
        dt.text="B.카라를 부른다.";
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);

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
       스킵.onClick.AddListener(text6_4.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {
        if(num==2){
            StartCoroutine(coroutine1);
            num++;
            스킵.interactable=false;
            //StartCoroutine(coroutine1);
        }
        if(num==4){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            선택지활성화();
            
        }
        if(num==5){
            StartCoroutine(coroutine2);
            num++;
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            
        }
        if(num==7){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            선택지활성화();
        }
        if(num==8){
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            StartCoroutine(coroutine3);
            num++;
        }
        if(num==10){
            a.SetActive(true);
            b.SetActive(true);
            c.SetActive(true);
            선택지활성화();
        }
        if(num==11){
            StartCoroutine(coroutine4);
            스킵.interactable=true;
            num++;
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            
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
        if(num==40){
            SceneManager.LoadScene("6-5");
        }
        
        


    }
}
