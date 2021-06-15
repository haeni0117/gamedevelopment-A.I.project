using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#8-3-1-b

public class text_8_3_2: MonoBehaviour
{
    public static Button 스킵 ;
    
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

    //basic component
    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정 
    public static Text typingText; 
    public static GameObject fadeout;


    //skip button
    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
        Debug.Log("d");
    }
    //choice1activation
    public static void a활성화(){
        SceneManager.LoadScene("8-3-3-a");
        // num=44;
        // //a. 안방으로 간다.-> 비활성화
        // GameObject a = GameObject.Find("a");
        // Button aB =a.GetComponent<Button>();
        // Text at = GameObject.Find("aText").GetComponent<Text>();
        // at.text=" ";
        // aB.interactable=false;

        // //b. 2층베란다로 간다. -> 비활성화
        // GameObject b = GameObject.Find("b");
        // Button bB =b.GetComponent<Button>();
        // Text bt = GameObject.Find("bText").GetComponent<Text>();
        // bt.text=" ";
        // bB.interactable=false;
        // bB.onClick.AddListener(text_8_3_2.b활성화);   
    }
    public static void b활성화(){
        SceneManager.LoadScene("8-3-3-b");
        // num=50;   
        //  //a. 안방으로 간다.-> 비활성화
        // GameObject a = GameObject.Find("a");
        // Button aB =a.GetComponent<Button>();
        // Text at = GameObject.Find("aText").GetComponent<Text>();
        // at.text=" ";
        // aB.interactable=false;

        // //b. 2층베란다로 간다. -> 비활성화
        // GameObject b = GameObject.Find("b");
        // Button bB =b.GetComponent<Button>();
        // Text bt = GameObject.Find("bText").GetComponent<Text>();
        // bt.text=" ";
        // bB.interactable=false;
        // bB.onClick.AddListener(text_8_3_2.b활성화);   
    }
    //선택지활성화
    public static void 선택지활성화(){
        //a. 안방으로 간다.
        GameObject a = GameObject.Find("a");
        Button aB =a.GetComponent<Button>();
        Text at = GameObject.Find("aText").GetComponent<Text>();
        at.text="A. 안방으로 간다.";
        aB.interactable=true;

        //b. 2층베란다로 간다. 
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text="B. 2층 베란다로 간다.";
        bB.interactable=true;
        bB.onClick.AddListener(text_8_3_2.b활성화);
    }
    public static void 선택지활성화a(){
        //a. 안방으로 간다.
        GameObject a = GameObject.Find("a");
        Button aB =a.GetComponent<Button>();
        Text at = GameObject.Find("aText").GetComponent<Text>();
        at.text=" ";
        aB.interactable=false;

        //b. 2층베란다로 간다. 
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text="B. 2층 베란다로 간다.";
        bB.interactable=false;
        
    }


    
    private static string text_9="암막 커튼으로 밧줄을 \n만들어야 한다. \n튼튼하게 묶기 위해서는 \n의수의 힘을 조금 \n빌려야 할 것 같다.";
    private static string text_10="\"사라!\"";
    private static string text_11="\"6분 32초 남았습니다.\"";
    private static string text_12="의수의 힘을 빌려\n초등학교 때부터 소방 훈련 \n시간에 지겹도록 배운 두 겹 \n팔자 매듭을 단단히 묶었다.";
    private static string text_13="{밧줄을 획득했다.}";
    private static string text_14="\"살면서 이런 지식을 써먹을 \n일이 생기길 바라진 않았는데.\"";
    private static string text_15="\"이론을 경험에 적용할 때, \n그때서야 비로소 배웠다고 \n할 수 있다. \n철학자 에이바 마틴의 명언입니다. \n지금 바로 사라 버전 26.6이 \n무료로 제공하는 3500개의 \n학습 프로그램을 즐겨보는 건 \n어떠신가요?”";
    private static string text_16="\"사라. 지금은 그럴 때가 아니야.\"";
    private static string text_17="다행히 사라는 짜증이 가득 담긴 \n목소리를 인식했는지 더는 나를 \n귀찮게 하지 않았다.";
    private static string text_18= "나는 황급히 엮은 3미터 길이의 \n암막 커튼을 난간에 묶었다.\n셔츠가 땀으로 흠뻑 젖어 움직일 \n때마다 불쾌하게 끈적거렸다. " ;
    private static string text_19="가스 냄새가 독해지면서 머리가 \n멍해지는 것이 느껴진다. ";
    private static string text_20="커튼 사이를 돌아다니던 시루의 \n움직임도 둔해졌다.";
    private static string text_21="정신 차리자.";
    private static string text_22="이제 끈을 잡고 내려가기만 \n하면 된다. ";
    private static string text_23="어디로 갈까?";
    //a. 안방으로 간다.
    private static string text_24="시간이 없어!\n지금 안방에 가면 쓰러지기\n전에 창문을 깰 수 없을 것이다.";
    //b. 2층 베란다로 간다.
    private static string text_25="밧줄을 다시 한번 단단히 베란다 \n창살에 걸었다.\n몇 번 세게 당겼지만 꿈쩍하지 \n않는다.";
    private static string text_26="\"매듭이 풀릴 일은 없겠네\"";
    private static string text_27="\"운동화 매듭이 고민이신가요?\n드라이브에 \n‘절대 풀리지 않는 매듭을 \n묶는 101가지 방법’\n이라는 기사가 저장되어 있습니다.\n읽어드릴까요?\"";
    private static string text_28= "\"사라\"" ;
    private static string text_29="\"부르셨나요? IA-0210님\"";
    private static string text_30="횡설수설하는 사라를 보며 \n나는 한숨을 쉬고 대답 대신 \n커튼을 붙잡고 조심히 베란다를 \n내려가기 시작했다.";


    
    



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
      
  
    // Start is called before the first frame update
    void Start()
    {
        스킵 =  GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_8_3_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene8-1-1 is started "+num);
        StartCoroutine(coroutine8);

        //a. 안방으로 간다
        GameObject a = GameObject.Find("a");
        Button aB =a.GetComponent<Button>();
        Text at = GameObject.Find("aText").GetComponent<Text>();
        at.text=" ";
        aB.interactable=false;
        aB.onClick.AddListener(text_8_3_2.a활성화);

        //b. 2층 베란다로 간다.
        GameObject b = GameObject.Find("b");
        Button bB =b.GetComponent<Button>();
        Text bt = GameObject.Find("bText").GetComponent<Text>();
        bt.text=" ";
        bB.interactable=false;
        bB.onClick.AddListener(text_8_3_2.b활성화);

        
    }
    // Update is called once per frame
    void Update()
    
    {
        Debug.Log(num);
        if(num==2){
            StartCoroutine(coroutine9);
            num++;
            //StartCoroutine(coroutine1);
        }
        if(num==5){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine10);
            num++;
        }
        if(num==8){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine11);
            num++;
        }
        if(num==11){
            StartCoroutine(coroutine12);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==14){
            StartCoroutine(coroutine13);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
        if(num==17){
            StartCoroutine(coroutine14);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==20){
            StartCoroutine(coroutine15);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==23){
            StartCoroutine(coroutine16);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==26){
            StartCoroutine(coroutine17);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==29){
            StartCoroutine(coroutine18);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==32){
            StartCoroutine(coroutine19);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==32){
            StartCoroutine(coroutine20);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        } 
        if(num==35){
            StartCoroutine(coroutine21);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        } 
        //어디로갈까출력
        if(num==38){
            StartCoroutine(coroutine22);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        } 
        if(num==41){
            // 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
            스킵.interactable=false;
            선택지활성화();
            num++;
        } 
        

    }
}
