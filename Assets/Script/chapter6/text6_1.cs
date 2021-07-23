using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text6_1 : MonoBehaviour
{// Start is called before the first frame update
   public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정
    public static Text typingText;
    public static GameObject fadeout;
    //장소버튼 + 게임오브젝트
    public static GameObject livingroom;
    public static GameObject office;
    public static GameObject guestroom;
    public static GameObject bedroom;

    public static Button livingroom_b;
    public static Button office_b;
    public static Button guestroom_b;
    public static Button bedroom_b;

    public static Text livingroom_t;
    public static Text office_t;
    public static Text guestroom_t;
    public static Text bedroom_t;



    private static string text_1="어디부터 찾아볼까?";
    static IEnumerator coroutine =  Typing(text_1);

    public static void enterbedroom(){
      SceneManager.LoadScene("6-1-1");
    }
    public static void enteroffice(){
      SceneManager.LoadScene("6-1-2");
    }
    public static void enterlivingroom(){
      SceneManager.LoadScene("6-1-3");
    }
    public static void enterguestroom(){
      SceneManager.LoadScene("6-1-4");
    }
    public void choiceactivation(){
      bedroom_t.text="1.안방에 들어간다.";
      office_t.text="2.작업실에 들어간다.";
      livingroom_t.text="3.거실에 들어간다.";
      guestroom_t.text="4.게스트룸에 들어간다.";
      livingroom_b.interactable=true;
      office_b.interactable=true;
      bedroom_b.interactable=true;
      guestroom_b.interactable=true;
    }



    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num+=1;
    }

    static IEnumerator Typing(string message)
    {
        Text typingText = GameObject.Find("general text").GetComponent<Text>();
        Debug.Log(typingText);
        Debug.Log(message);

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


  void Awake(){
    livingroom_b = GameObject.Find("livingroom").GetComponent<Button>();
    office_b = GameObject.Find("office").GetComponent<Button>();
    bedroom_b = GameObject.Find("bedroom").GetComponent<Button>();
    guestroom_b = GameObject.Find("guestroom").GetComponent<Button>();
    livingroom_t = GameObject.Find("livingroomtext").GetComponent<Text>();
    office_t = GameObject.Find("officetext").GetComponent<Text>();
    bedroom_t = GameObject.Find("bedroomtext").GetComponent<Text>();
    guestroom_t = GameObject.Find("guestroomtext").GetComponent<Text>();
    livingroom_b.interactable=false;
    office_b.interactable=false;
    bedroom_b.interactable=false;
    guestroom_b.interactable=false;
    livingroom_b.onClick.AddListener(enterlivingroom);
    office_b.onClick.AddListener(enterbedroom);
    guestroom_b.onClick.AddListener(enterguestroom);
    office_b.onClick.AddListener(enteroffice);
    bedroom_t.text=" ";
    office_t.text=" ";
    livingroom_t.text=" ";
    guestroom_t.text=" ";



  }
    // Start is called before the first frame update
   void Start()
    {
       Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text6_1.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       스킵.interactable=false;
        Debug.Log("coroutin is started! #6-1 num"+num);
        StartCoroutine(coroutine);
        Invoke("choiceactivation",2f);

    }

//     // Update is called once per frame
    void Update(){

        //Debug.Log(num);
        //     //StartCoroutine(coroutine1);
        // }
        // if(num==5){
        //     Debug.Log("coroutine is started!  num"+num);
        //     StartCoroutine(coroutine2);
        //     num++;
        // }
        // if(num==8){
        //     Debug.Log("coroutine is started!  num"+num);
        //     StartCoroutine(coroutine3);
        //     num++;
        // }
        // if(num==11){
        //     StartCoroutine(coroutine4);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;
        // }
        // if(num==14){
        //     StartCoroutine(coroutine5);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        //
        // if(num==17){
        //     StartCoroutine(coroutine6);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==20){
        //     StartCoroutine(coroutine7);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==23){
        //     StartCoroutine(coroutine8);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==26){
        //     StartCoroutine(coroutine9);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==29){
        //     StartCoroutine(coroutine10);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==32){
        //     StartCoroutine(coroutine11);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==35){
        //     StartCoroutine(coroutine12);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==38){
        //     StartCoroutine(coroutine13);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==41){
        //     StartCoroutine(coroutine14);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==44){
        //     StartCoroutine(coroutine15);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==47){
        //     StartCoroutine(coroutine16);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==50){
        //     StartCoroutine(coroutine17);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==53){
        //     StartCoroutine(coroutine18);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        // }
        // if(num==56){
        //     SceneManager.LoadScene("4-2");
        //     num++;//activate button
        // }


    }
}
