using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class text_8_6 : MonoBehaviour
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

    private static string text_1="안방으로 가서 여기저기 \n둘러보았다.";
    private static string text_2="쓸만한 것이 보이지 않아. \n다른 방을 살펴봐야 할 것 같다.\n작업실에는 뭔가 있을지도?";


     static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    


    // Start is called before the first frame update
    void Awake(){
        text_8_7.livingroom=false;
        typingText = GameObject.Find("general text").GetComponent<Text>();
        // FadeOut(1.0f);
        // Debug.Log("fadein : awake function");
        
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
        Debug.Log("Scene #8-6 is started");
        //오피스텔 화장실 .img
   
       스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text_8_6.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       StartCoroutine(coroutine);
       스킵.interactable=true;
       
       
    }

    // Update is called once per frame
    void Update()
    {
        if(num==2){
            StartCoroutine(coroutine1);
            num++;
        
               //StartCoroutine(coroutine1);
        }
     
            
        if(num==4){
            SceneManager.LoadScene("8-7");
            
        }
        
        


    }
}
