using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text_13 : MonoBehaviour
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
  private static string text_1="이곳만큼은 정말 \n들어오고 싶지 않았다.\n\n\n하지만......\n이제 이겨낼 때가 됐다.";
  private static string text_2="한눈에 봐도 \n관리가 되지 않은 방이다.\n오랫동안 사용하지 않아\n잔뜩 녹이 슨 액자와\n먼지가 소복이 쌓인 \n금고가 보인다.";
  private static string text_3="누군가 함부로 \n스마트홈 인공지능 본체에\n접근할 수 없도록 \n엘리베이터를 통해서만\n올 수 있는 이곳에 \n본체를 설치해뒀다.";
  private static string text_4="혼자서 이곳에 \n온 것은 정말 처음인데......\n일단은 주변을 둘러보자.\n\n\n일단 눈에 띄는 것부터 \n조사 해보자. ";
  private static string text_5="먼지가 너무 쌓여서 \n본래 색깔을 \n알아보기가 힘들다.\n\n\n흰색 먼지 분자 사이로 \n황동색 빛이\n살짝 비친다.";
  private static string text_6="디지털 금고가 아니라 \n플라스틱 번호판에\n다이얼을 입력해서 여는 \n구식 금고다.";
  private static string text_7="\"무섭진 않아?\"";
  private static string text_8="바보 같은 질문이야.\n나는 의수 제일 바깥 틀을\n해체하면서 한숨을 쉬었다.";
  private static string text_9="\"아니요. 오히려 제가 마땅히\n해야할 일을 한다고 생각하니까\n마음이 편해지는걸요\"";
  private static string text_10="저것도 나를 안심시키기 위해\n만들어진 코드일까.";
  private static string text_11="\"그래, 이제 너를 꺼내기만 하면 돼.\"";
  private static string text_12="{의수와 드라이버를 조합했다}\n드라이버를 이용해 코어를 보호하는 \n판을 해체하고 사라를 꺼냈다";
  private static string text_13="{사라 코어를 획득했다}";
  private static string text_14="작업실 컴퓨터는 \n최신식 AT젠더를 사용해서 \n둘 사이를 이어줄 \n변환 젠더가 필요하다.";
  private static string text_15="{사라 코어를 변환 젠더와 조합했다}";
  private static string text_16="고작 저 작은 코어에 \n사라가 들어있다니......";
  private static string text_17="하지만 이제는 정신을 차려야 할 때다.\n사라의 희생이 물거품이 \n되게 할 순 없어.";
  private static string text_18="나는 사라가 들어 있는 변환 젠더를\n작업실 컴퓨터에 연결했다. ";
  private static string text_19="[모니터 출력 권한 가져오기 성공]\n[실내 온도 조절 권한 가져오기 성공]";
  private static string text_20="집 안이 26도를\n유지하도록 설정했다.\n이제 아까처럼 추위에\n갑자기 추위에 떠는 일은\n없을 것이다.";
  private static string text_21="[현관 출입제한 권한 가져오기 실패]\n[통신 제어권 가져오기 실패]\n[숨김 파일 해제 권한 가져오기 실패]";
  private static string text_22="\"숨김 파일 해제 권한...?\n이게 뭐지?\"";
  private static string text_23="[삭제 및 초기화 권한 가져오기...]";

  private static string text_24="갑자기 이명 같은 단말마의 \n경고음이 귓가를 때리고,\n모니터 화면엔 \n[삭제 및 초기화 권한]이라는 \n글자가 깜빡거렸다.";
  private static string text_25="설마, 성공한건가?";
  //안방으로 이동
  private static string text_26="하지만 아무리 기다려도 \n사라의 목소리는 들리지 않았다";
  private static string text_27="\"안돼...\"";
  private static string text_28="설마...";
  private static string text_29="컴퓨터를 아무리 두드려도\n모니터는 반응이 없었다.";
  private static string text_30="나는 황급히 변환 젠더에서\n사라를 꺼내 \n의수에 다시 집어 넣었다.";
  private static string text_31="하지만 의수에서도\n사라는 깨어나지 않았다\n[삭제 및 초기화 권한]이라는\n글자만 모니터에 깜빡거릴 뿐.";
  private static string text_32="\"하...\"";
  private static string text_33="나는 책상에 얼굴을 묻고\n누군가가 구해주기를 그저 기다렸다\n아무도 구해주지 않을 걸 알면서도.";
  private static string text_34="'야-옹'";
  private static string text_35="시루가 내 다리에 얼굴을 비볐다.\n시루는 아직 제대로 된 치료를\n받지 못해 힘이 없는 와중에도 \n나를 위로하고 있었다.";
  private static string text_36="사라가 남겨준 권한과 시루....\n나는 의자에서 일어나 \n안방으로 향했다.";
  private static string text_37="서버관리실로 가야 해.";
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

          }
          if(num==53){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine18);
            computer_background.SetActive(true);
            core_number.SetActive(true);


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
