using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#8-3-1-b

public class text_10: MonoBehaviour
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
    // public static void a활성화(){
    //     SceneManager.LoadScene("8-3-3-a");
    //     // num=44;
    //     // //a. 안방으로 간다.-> 비활성화
    //     // GameObject a = GameObject.Find("a");
    //     // Button aB =a.GetComponent<Button>();
    //     // Text at = GameObject.Find("aText").GetComponent<Text>();
    //     // at.text=" ";
    //     // aB.interactable=false;

    //     // //b. 2층베란다로 간다. -> 비활성화
    //     // GameObject b = GameObject.Find("b");
    //     // Button bB =b.GetComponent<Button>();
    //     // Text bt = GameObject.Find("bText").GetComponent<Text>();
    //     // bt.text=" ";
    //     // bB.interactable=false;
    //     // bB.onClick.AddListener(text_8_3_2.b활성화);   
    // }
    // public static void b활성화(){
    //     SceneManager.LoadScene("8-3-3-b");
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
    
    //선택지활성화
    
    

    
    private static string text_1="빗소리가 가시고,\n거실에 다시 고요함이 찾아왔다.";
    private static string text_2= "\"사라, 정말....., 정말 고마워.\"" ;
    private static string text_3="\"무엇이 고마우신가요? \n호스트의 명령을 따르는 것이 \n저의 존재 목적입니다.\"";
    private static string text_4="사라는 정말 궁금한 말투였다.\n사라의 말투에선 그 어떤 분노도, \n모멸도 느껴지지 않았다";
    private static string text_5="오로지 인간의 명령을 \n따르기 위해 태어난 존재, \n감정이 없는 기계....\n그런 존재를 점점 \n인간처럼 만들려고 하는 \n시도 자체가 사실은 \n모순이 아니었을까?";
    private static string text_6="나는 의수 위에 떠 있는 \n사라의 얼굴을 바라보며 \n카라를 만들기 위해 \n수백 번도 더 진행했던 \n감정 학습 시뮬레이션을 떠올렸다. ";
    private static string text_7="\"아냐 그냥, \n이렇게 얘기하는 것도 \n정말 오랜만이네. \n어렸을 땐 \n둘이 종일 붙어 있었는데.\"";
    private static string text_8= "\"오빠가 그리우신가요?\"" ;
    private static string text_9="\"뭐라고?\"";
    private static string text_4="\"오-빠-가- 그-리-우-신-가-요-?\"";
    private static string text_5="\"아니, 그런 의미가 아니...\n됐고, 갑자기 그런 말을 꺼낸\n이유가 뭐야??\"";
    private static string text_6="\"두 분이 같이 노는 모습을 \n지켜보는 게 참 기뻤습니다. \n하지만 어느 날부터 ‘아로’님이 \n보이지 않더니, \n그 후로는 ‘화이’님도 \n거의 웃지 않으셨습니다.\"";



    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);       
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5 = Typing(text_6);
    
    
  
    // Start is called before the first frame update
    void Start()
    {
        스킵 =  GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_10.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene8-1-1 is started "+num);
        StartCoroutine(coroutine);

        

        
    }
    // Update is called once per frame
    void Update()
    
    {
        Debug.Log(num);
        if(num==2){
            StartCoroutine(coroutine1);
            num++;
            //StartCoroutine(coroutine1);
        }
        if(num==5){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine2);
            num++;
        }
        if(num==8){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine3);
            num++;
        }
        if(num==11){
            StartCoroutine(coroutine4);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==14){
            StartCoroutine(coroutine5);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
        if(num==17){
            SceneManager.LoadScene("8-4");
        }
        
        

    }
}
