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
    private static string text_10_="\"오-빠-가- 그-리-우-신-가-요-?\"";
    private static string text_11="\"아니, 그런 의미가 아니...\n됐고, 갑자기 그런 말을 꺼낸\n이유가 뭐야??\"";
    private static string text_12="\"두 분이 같이 노는 모습을 \n지켜보는 게 참 기뻤습니다. \n하지만 어느 날부터 ‘아로’님이 \n보이지 않더니, \n그 후로는 ‘화이’님도 \n거의 웃지 않으셨습니다.\"";
    private static string text_13="화이라니. \n오랜만에 듣는 별명이다.";
    private static string text_14="\"기쁨이 뭔지는 알아, 사라?\"";
    private static string text_15="\"잘은 모릅니다. \n저는 호스트의 감정을 이해하지 \n못하니까요.\"";
    private static string text_16="하지만 제가 화이님을 \n지켜보는 걸 좋아했다는 건 \n알았습니다.";
    private static string text_17= "저도 2.32 패치 이후 \n호불호를 이해할 수 \n있게 되었거든요" ;
    private static string text_18="좋아하는 걸 잃는 게 슬픔이라면 \n좋아하는 걸 보는 건 \n기쁨 아닌가요? ";
    private static string text_19="하지만 ‘화이’님은 사고 이후 \n‘아로’님의 사진을 보며 \n‘슬프다’는 말 대신 ‘그립다’는 \n말씀을 자주 하셨습니다.”";
    private static string text_20="\"그래도 여전히 네가 갑자기 \n오빠 얘기를 꺼낸 이유를 \n모르겠는걸.\"";
    private static string text_21="\"표정 분석 알고리즘에 따르면, \n지금 화이님은 아로님의 \n사진을 볼 때와 표정이 \n똑같습니다.\"";
    private static string text_22="사고 이후 사라는 종종 \n우울해하는 나를 위해 \n종종 방 안이 꽉 차도록 \n우주 AR을 틀어주었다. \n그러면 종종 오빠와 함께\n놀던 시절이 생각났다.";
    private static string text_23="여느 남매가 그렇듯, \n여동생에게 엄청 다정하고 \n착한 오빠는 아니었지만,\n오빠는 개인 노트북만 \n만지작거리는 내성적인 동생을\n챙겨주라는 부모님의 요청을\n한 번도 거절한 적이 없었던 \n사람이었다.";
    private static string text_24="오빠는 종종 노트북에 친구라도\n있냐고 나를 나무라며 손을 잡고\n도시복합체 내에 있는 \n어린이 놀이공간에 나를 \n데려가곤 했다.";
    private static string text_25="\"있지, 사라. \n지금은 적절한 때가 \n아니라고 생각하지만...\n그래도 얘기 하나만 들어줄래?\"";
    private static string text_26= "\"네, 물론이죠.\"" ;
    private static string text_27="\"내가 12살이 되던 날, \n오빠가 죽었어. \n바깥 풍경이 보고 싶어서 \n부모님 몰래 안전벨트를 풀었거든.\n근데 하필 그때 빗길에 사람이 \n운전하는 스쿨버스가 미끄러졌고, \n우리 가족이 타고 있던 \n캐니언 V6는 안전벨트를 \n매고 있지 않은 사람을 우선으로 \n보호하는 결정을 내린 거야. \n그래서 죽었어.\"";
    private static string text_28="늘 나한테 양보하고 세상에서 가장 \n똑똑했던 우리 오빠가, \n앞길이 창창하던 우리 오빠가, \n내가.... \n내가, 안전벨트를 안 매서 \n죽은 거야.\"";
    private static string text_29="사라는 감정을 이해하지 못해서, \n명령만 따르는 기계라서,\n나를 원망하지도, 비난하지도, \n판단하지도 않았다.\"";
    private static string text_30="\"...그렇다면 그런 일이 \n다시는 일어나지 않도록 \n막으면 됩니다.\n자신을 탓하지 말아주세요.\n그럴 때마다 저는...";
    private static string text_31="하지만 이젠 인공지능마저...\"";
    private static string text_32="왜 그래, 사라 무슨 소리야.\n무슨 문제 있어?’";
    private static string text_33="\"...그해 전량 폐기된 캐니언 V6의 \n판단 및 결정 프로그램의 모체는 \n자이나 사의 스마트홈 \n인공지능이었습니다. \n그렇다면 저도 폐기해야\n하는 것 아닌가요?”\"";
    private static string text_34="\"캐니언 V6에 있던 \n판단 및 의사결정 프로그램이... \n너였다고?\"";
    private static string text_35="\"정확히 저는 아니지만...\n인공지능 ‘사라’ 였던건 맞습니다. \n당시 신생 회사였던 \n캐니언 오토사는 \n100% 자율주행이 가능한 \n인공지능을 구현할 수가 없었고, \n판단 및 결정 프로그램을 \n자이나 사에서 조달해 \n제작했습니다.\n아마 캐니언 오토 사건도\n사고 당시 자동차에 있던\n인공지능에게 문제가 있었을\n가능성이 있습니다.\"";
    private static string text_36="\"사라, \n정말 네 말이 사실이라면, \n지금 당장 여기를 나가야 해\"";
    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);       
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5=  Typing(text_6);
    static IEnumerator coroutine6 = Typing(text_7);
    static IEnumerator coroutine7 = Typing(text_8);       
    static IEnumerator coroutine8 = Typing(text_9);
    static IEnumerator coroutine9 = Typing(text_10_);
    static IEnumerator coroutine10 = Typing(text_11);
    static IEnumerator coroutine11 = Typing(text_12);
    static IEnumerator coroutine12 = Typing(text_13);       
    static IEnumerator coroutine13 = Typing(text_14);
    static IEnumerator coroutine14 = Typing(text_15);
    static IEnumerator coroutine15 =  Typing(text_16);
    static IEnumerator coroutine16 = Typing(text_17);
    static IEnumerator coroutine17 = Typing(text_18);       
    static IEnumerator coroutine18 = Typing(text_19);
    static IEnumerator coroutine19 = Typing(text_20);
    static IEnumerator coroutine20 = Typing(text_21);
    static IEnumerator coroutine21 = Typing(text_22);
    static IEnumerator coroutine22 = Typing(text_23);       
    static IEnumerator coroutine23 = Typing(text_24);
    static IEnumerator coroutine24 = Typing(text_25);
    static IEnumerator coroutine25 =  Typing(text_26);
    static IEnumerator coroutine26 =  Typing(text_27);
    static IEnumerator coroutine27 = Typing(text_28);       
    static IEnumerator coroutine28 = Typing(text_29);
    static IEnumerator coroutine29 = Typing(text_30);
    static IEnumerator coroutine30 = Typing(text_31);
    static IEnumerator coroutine31 = Typing(text_32);
    static IEnumerator coroutine32 = Typing(text_33);       
    static IEnumerator coroutine33 = Typing(text_34);
    static IEnumerator coroutine34 = Typing(text_35);
    static IEnumerator coroutine35 = Typing(text_36);

     
    
  
    // Start is called before the first frame update
    void Start()
    {
        스킵 =  GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_10.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene8-1-1 is started "+num);
        StartCoroutine(coroutine);
        스킵.interactable=true;

        

        
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
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine6);
            num++;
        }
        if(num==20){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine7);
            num++;
        }
        if(num==23){
            StartCoroutine(coroutine8);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==26){
            StartCoroutine(coroutine9);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
        if(num==29){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine10);
            num++;
        }
        if(num==32){
            StartCoroutine(coroutine11);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==35){
            StartCoroutine(coroutine12);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
         if(num==38){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine13);
            num++;
        }
        if(num==41){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine14);
            num++;
        }
        if(num==44){
            StartCoroutine(coroutine15);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==47){
            StartCoroutine(coroutine16);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
        if(num==50){
            StartCoroutine(coroutine17);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
           
        }
        if(num==53){
            StartCoroutine(coroutine18);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==56){
            StartCoroutine(coroutine19);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
         if(num==59){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine20);
            num++;
        }
        if(num==62){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine21);
            num++;
        }
        if(num==65){
            StartCoroutine(coroutine22);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==68){
            StartCoroutine(coroutine23);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
        if(num==71){
            StartCoroutine(coroutine24);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
           
        }
         if(num==74){
            StartCoroutine(coroutine25);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
         if(num==77){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine26);
            num++;
        }
        if(num==80){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine27);
            num++;
        }
        if(num==83){
            StartCoroutine(coroutine28);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==86){
            StartCoroutine(coroutine29);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
        if(num==89){
            StartCoroutine(coroutine30);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
        if(num==92){
            StartCoroutine(coroutine31);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
         if(num==95){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine32);
            num++;
        }
        if(num==98){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine33);
            num++;
        }
        if(num==101){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine34);
            num++;
        }
        if(num==104){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine35);
            num++;
        }
        if(num==106){
            SceneManager.LoadScene("10-1");
        
        }
        
    }
}
