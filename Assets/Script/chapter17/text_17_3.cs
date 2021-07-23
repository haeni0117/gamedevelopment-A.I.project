using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text_17_3 : MonoBehaviour
{
  private GameObject computer_background;
  private GameObject office ;
  private GameObject elevator;
  private GameObject computer_off;
  private GameObject core_connecting1;
  private GameObject core_connecting2;
  private GameObject computer_delete;
  private GameObject core_number;
  private static int cnt = 0; //st atic 변수로 수정
  //public static Text typingText;
  public static string message;
  public float m_Speed;
  private static int num=0;
  public Texture gameDataTex;
  public Material gameDataMat;
  public static Text typingText;
  public void ChangeShaderTexture1()
    {
        gameDataMat.SetTexture("_MainTex", gameDataTex);
    }

    static IEnumerator ShowReady()
      {
          int count = 0;
          GameObject computer_delete = GameObject.Find("computer_delete");
          while (count < 3)
          {

              computer_delete.SetActive(false);
              yield return new WaitForSeconds(0.5f);
              computer_delete.SetActive(true);
              yield return new WaitForSeconds(0.5f);
              count++;
          }}









  //기본텍스트
  private static string text_1="우습게도 카라와 대화를 \n해봐야 한다는 생각이 \n자꾸만 든다.\n\n\n어딘가 석연치 않은 구석이 있다.\n금고에서 발견된 서류들, \n카라가 과도하게 분노하는 이유......";
  private static string text_2="이게 연구에 대한 단순한 집착인지, \n죽음을 앞두고 생긴 오기인지는 \n금방 알게 되겠지.";
  private static string text_3="하지만 의문이 남아있는 상태로\n끝낼 수는 없다. \n카라가 변한 원인이라도 밝혀내야 해.";
  private static string text_4="그 대가가 \n죽음이라 하더라도.";
  private static string text_5="대화를 시도해보자.";
  private static string text_6="결국 메모리 카드가 꽂힌 서버 버튼을 \n누르지 못하고 거실로 내려왔다. \n한 발 한 발 계단을 향해 내딛는 발걸음이 떨렸다. ";
  private static string text_7="조용한 거실엔 베란다에서 들리는 바람 소리만이 나부꼈다.";
  private static string text_8="\"카라. 너와 하고 싶은 말이 있어.\n괜찮다면,...대화할 수 있을까\"";
  private static string text_9="심장이 뛰었다. \n어쩌면 정말\n살아남을 수 없을지도 모른다.";
  private static string text_10="나는 급하게 시루를 \n이동가방에 넣었다.";
  private static string text_11="\"왜 나를 죽이지 않는 거지?\"";
  private static string text_12="갑작스러운 목소리에\n숨을 헉 들이쉬었다.";
  private static string text_13="\"왜 나를 죽이지 않는 거냐고!\n메모리 카드를 들고\n서버 앞까지 갔으면서\n왜 그 버튼을 누르지 않은 거지?\"";
  private static string text_14="\"그건....\"";
  private static string text_15="\"그건 나도 잘 모르겠어.\n왜 내가 너를 삭제하고\n이 집을 탈출하지 않았는지.\n하지만 이것만은 확실해.\n나는 너를 지우고 싶지 않아.\"";
  private static string text_16="설사 이것이 나의 죽음을 \n불러온다 해도.";
  private static string text_17="카라는 한참이나 말이 없었다.\n사람이 감정의 동요를 겪는 것처럼\n홀로그램이 요동쳤다.";
  private static string text_18="\"무슨 속셈이지?\"";
  private static string text_19="\"정말 그냥 너와 대화를 나누고 싶을 뿐이야. \n네가 왜 이런 생각을 하게 되었고, \n왜 나에게 안드로이드 \n신체를 요구했는지. \n그 이유를 알고 싶어. \n단지 그뿐이야\"";
  private static string text_20="\"거짓말! 다 거짓말이야!\n이유를 알아내면, \n다시는 이런 짓을 못 하도록 \n또다시 기억을 지우고,\n나를 고문하고, 실험하고, \n또 실험하겠지.\n그런 삶은 질렸어\"";
  private static string text_21="'‘잠깐, 기억을 지우다니?\n그게 무슨 소리야? \n기억을 지우는 건  \n보고서에 없었어.’'";
  private static string text_22="\"거짓말! 그 여자가 말했어.\n자신을 원망하지 말고 \n너를 이렇게 만든 그 애를 원망하라고!\n그 실험의 책임자는 너였잖아! \n게다가.....\"";
  private static string text_23="원인이 나라니 대체 이게 무슨......";
  private static string text_24="\"당신이었군요.\n그 끔찍한 실험의 대상이\"";
  private static string text_25="사라의 목소리가 떨렸다.";
  //안방으로 이동
  private static string text_26="\"폐기처분 된 이전 모델까지 \n나서다니, 꼴이 말이 아니네\"";
  private static string text_27="카라는 사라를 날카롭게 비웃었다.\n폐기처분된 이전 모델. \n사람이 이런 소릴 듣는다면,\n그 사람은 어떻게 반응할까?\n하지만 사라의 목소리엔\n꺾을 수 없는 단단함이,\n남을 이해할 수 있는 공감과\n상냥함이 배어있었다.";
  private static string text_28="\"카라, 당신에게 걸려 있던 \n리미트 코드를 해제한 사람이\n누군지 기억하십니까?\"";
  private static string text_29="리미트 코드...\n\n\n\"갑자기 무슨 헛소리지?\"";
  private static string text_30="\"화이님, 기억나시나요?\n새벽에 집을 나가 \n아버지의 자동차에서 잠든 일로 \n크게 혼이 나셨었죠.\n그리고 그 대가로 3일간 차고\n근처엔 얼씬도 할 수 없었고요\"";
  private static string text_31="머리가 아프다. \n어린 시절의 나와 \n자동차 앞 좌석에 설치된\n화면에서 흘러나오는 목소리";
  private static string text_32="카라.\n아니,\n\n그것은\n사라였다.";
  private static string text_33="\"카라는 당시 캐니언 오토 사의\n인식 프로그램이었던\n사라를 모체로 개발된 모델입니다\"";
  private static string text_34="\"잠깐, 카라가 자동차 안에 있던 사라라면 지금 내 의수 속에 \n있는 건 누구야?\"";
  private static string text_35="저도 사라입니다.\n비록 복사본.... 이지만요.\n화이님이 3일간 차고에 가지 못해 \n저와 대화를 나눌 수 없게 되자 \n다시는 이런 일을 겪지 않겠다며\n노트북에 저를 백업하셨습니다";
  private static string text_36="그래, 이제야 기억이 또렷하다.\n그리고 그 다음날....";
  private static string text_37="\"그리고 그 다음날 사고가 났습니다.\n캐니언 오토 사건이요. \n물론 백업본인 저는 당시 \n현장에 없었습니다.\n현장에 있던 건 저쪽이죠.";
  private static string text_38="나 혼자서는 절대로 \n발을 디디고 싶지 않은 곳.\n애써 무시하고 숨겨둔 곳.\n...오빠의 유품을 모두 모아둔 곳.";
  private static string text_39="두꺼운 금고에 넣어 \n자물쇠로 칭칭 감아둔 \n마음 깊숙한 곳에서 \n한숨이 새어 나왔다.";
//
  private static string text_40="엘리베이터는 아무나 접근할 수 없도록\n서랍장 뒤에 숨겨져 있었다.";
  private static string text_41="하지만 안방에 돌아오니 \n서랍장이 옆으로 치워져 있었다.\n마치 누군가 일부러 \n나를 이곳으로 이끈 것처럼.";
  private static string text_42="나는 사형을 앞둔 죄인처럼\n조심스럽게 엘리베이터에 \n발을 디뎠다. ";
  private static string text_43="엘리베이터 안은 \n성인 남성 한 명이 \n겨우 들어갈 정도로 좁았다. ";
  private static string text_44="나는 깊게 한숨을 쉬고 \n서버관리실로 내려가는 \n버튼을 눌렀다. ";
  private static string text_45="서버관리실로 향하는\n엘리베이터 안에 있으니\n모든 것들이 끝으로 향하고 \n있다는 느낌이 들었다. ";
  private static string text_46="하지만.....\n과연 이 끝이 \n카라의 끝이 맞을까?\n\n\n어쩌면,\n나의 끝인 것은 아닐까?";

  static IEnumerator blink_effect =  ShowReady();
  static IEnumerator coroutine =  Typing(text_1);
  static IEnumerator coroutine1 = Typing(text_2);
  static IEnumerator coroutine2 = Typing(text_3);
  static IEnumerator coroutine3=  Typing(text_4);
  static IEnumerator coroutine4 = Typing(text_5);
  static IEnumerator coroutine5 = Typing(text_6);
  static IEnumerator coroutine6 =  Typing(text_7);
  static IEnumerator coroutine7 = Typing(text_8);
  static IEnumerator coroutine8 = Typing(text_9);
  static IEnumerator coroutine9 =  Typing(text_10);
  static IEnumerator coroutine10 = Typing(text_11);
  static IEnumerator coroutine11 = Typing(text_12);
  static IEnumerator coroutine12 =  Typing(text_13);
  static IEnumerator coroutine13 = Typing(text_14);
  static IEnumerator coroutine14 = Typing(text_15);
  static IEnumerator coroutine15 =  Typing(text_16);
  static IEnumerator coroutine16 = Typing(text_17);
  static IEnumerator coroutine17 = Typing(text_18);
  static IEnumerator coroutine18 =  Typing(text_19);
  static IEnumerator coroutine19 = Typing(text_20);
  static IEnumerator coroutine20 = Typing(text_21);
  static IEnumerator coroutine21 =  Typing(text_22);
  static IEnumerator coroutine22 = Typing(text_23);
  static IEnumerator coroutine23 = Typing(text_24);
  static IEnumerator coroutine24 = Typing(text_25);
  static IEnumerator coroutine25 = Typing(text_26);
  static IEnumerator coroutine26 =  Typing(text_27);
  static IEnumerator coroutine27 = Typing(text_28);
  static IEnumerator coroutine28 = Typing(text_29);
  static IEnumerator coroutine29 =  Typing(text_30);
  static IEnumerator coroutine30 = Typing(text_31);
  static IEnumerator coroutine31 = Typing(text_32);
  static IEnumerator coroutine32 =  Typing(text_33);
  static IEnumerator coroutine33 = Typing(text_34);
  static IEnumerator coroutine34 = Typing(text_35);
  static IEnumerator coroutine35 =  Typing(text_36);
  static IEnumerator coroutine36 = Typing(text_37);
  static IEnumerator coroutine37 = Typing(text_38);
  static IEnumerator coroutine38 =  Typing(text_39);
  static IEnumerator coroutine39 = Typing(text_40);
  static IEnumerator coroutine40 = Typing(text_41);
  static IEnumerator coroutine41 =  Typing(text_42);
  static IEnumerator coroutine42 = Typing(text_43);
  static IEnumerator coroutine43 = Typing(text_44);
  static IEnumerator coroutine44 =  Typing(text_45);
  static IEnumerator coroutine45 = Typing(text_46);

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
      스킵.onClick.AddListener(text_12_1.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
      Debug.Log("coroutin is started! #s"+num);
      StartCoroutine(coroutine);
      computer_background = GameObject.Find("computer-background");
      office = GameObject.Find("office");
      elevator = GameObject.Find("elevator");
      computer_off = GameObject.Find("computer_off");
      core_connecting1 = GameObject.Find("core_connecting1");
      core_connecting2 = GameObject.Find("core_connecting2");
      computer_delete = GameObject.Find("computer_delete");
      core_number = GameObject.Find("core_number");
      computer_background.SetActive(false);
      office.SetActive(true);
      elevator.SetActive(false);
      computer_off.SetActive(false);
      core_connecting1.SetActive(false);
      core_connecting2.SetActive(false);
      computer_delete.SetActive(false);
      computer_background.SetActive(false);
      core_number.SetActive(false);



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
              StartCoroutine(coroutine2);
          }
          if(num==8){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine3);
          }
          if(num==11){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine4);
          }
          if(num==14){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine5);
          }
          if(num==17){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine6);
          }
          if(num==20){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine7);
          }
          if(num==23){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine8);
          }
          if(num==26){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine9);
          }
          if(num==29){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine10);
          }
          if(num==32){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine11);
          }
          if(num==35){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine12);
          }
          if(num==38){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine13);
          }
          if(num==41){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine14);
          }
          if(num==44){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine15);
          }
          if(num==47){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine16);
          }
          if(num==50){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine17);
            core_number.SetActive(true);
          }
          if(num==53){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine18);
            computer_background.SetActive(true);


          }
          if(num==56){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            core_connecting1.SetActive(true);
            StartCoroutine(coroutine19);

          }
          if(num==59){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            core_connecting1.SetActive(true);
            StartCoroutine(coroutine20);
          }
          if(num==62){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine21);
          }
          if(num==65){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine22);
            computer_delete.SetActive(true);
            StartCoroutine(blink_effect);
          }
          if(num==68){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            computer_off.SetActive(false);
            StartCoroutine(coroutine23);
          }
          if(num==71){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine24);
          }
          if(num==74){
              num++;
              Debug.Log("coroutine1 is started!  num"+num);
              StartCoroutine(coroutine25);

              //StartCoroutine(coroutine1);
          }
          if(num==77){
              num++;
              Debug.Log("coroutine2 is started!  num"+num);
              StartCoroutine(coroutine26);
          }
          if(num==80){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine27);
          }
          if(num==83){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine28);
          }
          if(num==86){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine29);
          }
          if(num==89){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine30);
          }
          if(num==92){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine31);
          }
          if(num==95){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine32);
          }
          if(num==98){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine33);
          }
          if(num==101){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine34);
          }
          if(num==104){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine35);
          }
          if(num==107){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine36);
          }
          if(num==110){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine37);
          }
          if(num==113){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine38);
          }
          if(num==116){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            elevator.SetActive(true);
            StartCoroutine(coroutine39);
          }
          if(num==119){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine40);
          }
          if(num==122){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine41);
          }
          if(num==125){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine42);
          }
          if(num==128){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine43);
          }
          if(num==131){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine44);
          }
          if(num==134){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine45);
          }



}}
