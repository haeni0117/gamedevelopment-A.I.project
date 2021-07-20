using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text_17_2 : MonoBehaviour
{

  private static int cnt = 0; //st atic 변수로 수정
  //public static Text typingText;
  public static string message;
  public float m_Speed;
  private static int num=0;
  public Texture gameDataTex;
  public Material gameDataMat;
  public static Text typingText;


    // static IEnumerator ShowReady()
    //   {
    //       int count = 0;
    //       GameObject computer_delete = GameObject.Find("computer_delete");
    //       while (count < 3)
    //       {
    //
    //           computer_delete.SetActive(false);
    //           yield return new WaitForSeconds(0.5f);
    //           computer_delete.SetActive(true);
    //           yield return new WaitForSeconds(0.5f);
    //           count++;
    //       }}









  //기본텍스트
  private static string text_1="감정을 가진 인공지능을 \n개발하는 건 평생의 \n꿈이자 목표였다.\n\n계속되는 실패로\n절망했던 나날들......\n\n\n“다시 그때로 돌아갈 순 없어.";
  private static string text_2="이런 오류로 동료들의 노력마저 물거품으로 만들 수는 없다.\n추가 연구를 위해서는\n최소한의 자료라도 서버로 전송해야 한다.";
  private static string text_21="감정을 가진 인공지능을 \n개발하는 건 평생의 \n꿈이자 목표였다.\n\n계속되는 실패로\n절망했던 나날들......\n\n\n“다시 그때로 돌아갈 순 없어.";
  private static string text_22="떨리는 손으로 \n카라의 메모리 카드가 꽂힌 서버의\n전원 버튼을 눌렀다.";
  private static string text_3="과부하가 온 것처럼\nCPU가 맹렬한 소리를 내며 움직였다.\n이제 5분 뒤면 이 현관을 막고 서던 \n카라는 없다. ";
  private static string text_4="‘돌이킬 수 없는 강을 건넌 거야.’\n\n\n나는 숨소리조차 들리지 않을 만큼\n고요한 거실을 빠르게 지나갔다.";
  private static string text_5="\"여전히 공기중 산소 비율이 낮습니다.\n5분 안에 다시 회복될 가능성은 \n78%지만 혹시 모르니 \n빨리 나가는 것이 좋겠습니다.\"";
  private static string text_6="나는 사라의 말에 고개를 끄덕이고 \n현관문 앞에 놓인 캐리어에 \n시루를 넣었다. \n시루도 상황을 아는 건지 평소에는\n그렇게도 싫어하던 캐리어에\n순순히 들어갔다.";
  private static string text_7="\"금방 치료해줄게.\"";
  private static string text_8="시루가 대답이라도 하듯 작게 울었다.\n나는 캐리어 손잡이를 꼭 쥐고\n지문 인식기에 검지를 올렸다.\n솟구치는 아드레날린 때문에\n의지와는 상관없이 손이 계속 \n덜덜 떨렸다.\n\n\n‘제발....’";
  private static string text_9="'삐빅-' '철컥'\n\n조심스럽게 손잡이를 돌리니\n부드럽게 돌아가는 게 느껴졌다.";
  private static string text_10="이제 한 발자국만 나가면 \n이 집을 벗어날 수 있다.";


  static IEnumerator coroutine =  Typing(text_1);
  static IEnumerator coroutine1 = Typing(text_2);
  static IEnumerator coroutine11 =  Typing(text_21);
  static IEnumerator coroutine12 = Typing(text_22);
  static IEnumerator coroutine2 = Typing(text_3);
  static IEnumerator coroutine3=  Typing(text_4);
  static IEnumerator coroutine4 = Typing(text_5);
  static IEnumerator coroutine5 = Typing(text_6);
  static IEnumerator coroutine6 =  Typing(text_7);
  static IEnumerator coroutine7 = Typing(text_8);
  static IEnumerator coroutine8 = Typing(text_9);
  static IEnumerator coroutine9 =  Typing(text_10);


  public static void 스킵버튼클릭(){
      Debug.Log("skipbutton is clicked! num="+num);
      num+=1;
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
          Debug.Log("user didn't skip the text+num"+num);}



    void Start()
    {
      Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
      스킵.onClick.AddListener(text_17_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
      Debug.Log("coroutin is started! #s"+num);
      StartCoroutine(coroutine);

    }

    // Update is called once per frame
    void Update()
    {


          // GameObject skipButton= GameObject.Find("skipButton");
          // Button skipButtonb = skipButton.GetComponent<Button>();
          // skipButtonb.onClick.AddListener(스킵버튼누르기);

          //Debug.Log(num);
          if(num==2){
              num++;
              Debug.Log("coroutine1 is started!  num"+num);
              StartCoroutine(coroutine1);

              //StartCoroutine(coroutine1);
          }
          if(num==5){
              num++;
              Debug.Log("coroutine2 is started!  num"+num);
              StartCoroutine(coroutine11);
          }
          if(num==8){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine12);
          }
          if(num==11){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine2);
          }
          if(num==14){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine3);
          }
          if(num==17){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine4);
          }
          if(num==20){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine5);
          }
          if(num==23){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine6);
          }
          if(num==26){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine7);
          }
          if(num==29){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine8);
          }
          if(num==32){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine9);
          }
          // if(num==35){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine12);
          // }
          // if(num==38){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine13);
          // }
          // if(num==41){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine14);
          // }
          // if(num==44){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine15);
          // }
          // if(num==47){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine16);
          // }
          // if(num==50){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine17);
          //   core_number.SetActive(true);
          // }
          // if(num==53){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine18);
          //   computer_background.SetActive(true);
          //
          //
          // }
          // if(num==56){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   core_connecting1.SetActive(true);
          //   StartCoroutine(coroutine19);
          //
          // }
          // if(num==59){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   core_connecting1.SetActive(true);
          //   StartCoroutine(coroutine20);
          // }
          // if(num==62){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine21);
          // }
          // if(num==65){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine22);
          //   computer_delete.SetActive(true);
          //   StartCoroutine(blink_effect);
          // }
          // if(num==68){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   computer_off.SetActive(false);
          //   StartCoroutine(coroutine23);
          // }
          // if(num==71){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine24);
          // }
          // if(num==74){
          //     num++;
          //     Debug.Log("coroutine1 is started!  num"+num);
          //     StartCoroutine(coroutine25);
          //
          //     //StartCoroutine(coroutine1);
          // }
          // if(num==77){
          //     num++;
          //     Debug.Log("coroutine2 is started!  num"+num);
          //     StartCoroutine(coroutine26);
          // }
          // if(num==80){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine27);
          // }
          // if(num==83){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine28);
          // }
          // if(num==86){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine29);
          // }
          // if(num==89){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine30);
          // }
          // if(num==92){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine31);
          // }
          // if(num==95){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine32);
          // }
          // if(num==98){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine33);
          // }
          // if(num==101){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine34);
          // }
          // if(num==104){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine35);
          // }
          // if(num==107){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine36);
          // }
          // if(num==110){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine37);
          // }
          // if(num==113){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine38);
          // }
          // if(num==116){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   elevator.SetActive(true);
          //   StartCoroutine(coroutine39);
          // }
          // if(num==119){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine40);
          // }
          // if(num==122){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine41);
          // }
          // if(num==125){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine42);
          // }
          // if(num==128){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine43);
          // }
          // if(num==131){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine44);
          // }
          // if(num==134){
          //   num++;
          //   Debug.Log("coroutine2 is started!  num"+num);
          //   StartCoroutine(coroutine45);
          // }



}}
