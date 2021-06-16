using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#8-3-1-b

public class text_10_4: MonoBehaviour
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


    
    private static string text_9="작업실 컴퓨터 화면에\n자이나 사의 로고가 깜빡거린다.\n아빠는 캐니언 오토사가 \n파산한 후 캐니언 V6에 사용되던 \n판단 및 의사결정 프로그램은 \n전량 폐기되어 다시는 사회에 \n사용될 일이 없다고 말씀하셨다.";
    private static string text_10="하지만 사라의 말대로 \nV6의 알고리즘이 \n자이나 사의 스마트홈이라면, \n캐니언 오토사는 왜 그 사실을 \n언론에 발표하지 않은 걸까? ";
    private static string text_11="그랬다면 파산만은 \n면할 수 있었을 텐데….\n머릿속이 혼란스럽다.";
    private static string text_12="사라를 카라에게 보내기 위해서는\n이 컴퓨터에 인공지능 코어를 \n연결하면 된다. ";
    private static string text_13="{AI코어를 작업실 컴퓨터에 사용했다.}";
    private static string text_14="컴퓨터 OS를 인공지능 자가\n진단 모드로 변경하고 \n창고에서 가져온 코어를 \n컴퓨터에 연결했다.";
    private static string text_15="코어가 너무 예전 모델이라 \n컴퓨터가 인식하지 \n못하는 것 같다.\n다른 방법이 없을까?";
    private static string text_16="{변환 젠더와 AI코어를 조합했다}";
    private static string text_17="화장실에서 발견한\n연결 젠더를 챙겨두길 잘했다. \n버전 별 호환이 가능한 \n젠더에 연결하니 \n모니터에‘RC-492’라는 \n코드명이 깜빡거린다.";
    private static string text_18="{구버전 사라를 획득했다!}" ;
    private static string text_19="이제 구버전 사라를 컴퓨터에\n연결하자.";
    private static string text_20="{구버전 사라를 작업실 컴퓨터에 사용했다}";
    private static string text_21="현관문 잠금부터 \n전자기기 통신 제어권까지 \n전기가 연결된 모든 것들을 \n조절하는 권한이 \nKM-468에 묶여 있다. ";
    private static string text_22="권한을 한꺼번에 되찾아오는\n마스터 키를 입력했지만\n역시나 듣지 않는다.\n각 권한에 알맞은 코드를 입력해 \n하나씩 권한을 \n되찾아와야 할 것 같다. ";
    

    
    



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
    
      
  
    // Start is called before the first frame update
    void Start()
    {
        스킵 =  GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_10_4.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene10-4 is started "+num);
        StartCoroutine(coroutine8);

       
        
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
    

    }
}
