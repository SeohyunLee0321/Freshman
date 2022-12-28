using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //���� ���� ���
    public enum GameState
    {
        Ready,
        Run,
        Pause,
        GameOver
    }

    //���� ���� ����
    public GameState gState;

    //UI �ؽ�Ʈ ����
    public Text stateLabel;

    //�÷��̾� ���� ������Ʈ ����
    GameObject player;

    //�÷��̾� ���� ������Ʈ ����
    PlayerMove playerM;

    //�̱���
    public static GameManager gm;

    //�ɼ� �޴� UI ������Ʈ
    public GameObject optionUI;

    private void Awake()
    {
        if(gm == null)
        {
            gm = this;
        }
    }

    void Start()
    {
        //�ʱ� ���� ���´� �غ� ���·� ����
        gState = GameState.Ready;

        //���� ���� �ڷ�ƾ �Լ� ����
        StartCoroutine(GameStart());

        //�÷��̾� ������Ʈ �˻�
        player = GameObject.Find("Player");

        playerM = player.GetComponent<PlayerMove>();
    }

    IEnumerator GameStart()
    {
        //Ready...��� ���� ǥ��
        stateLabel.text = "Ready...";

        //Ready  ������ ������ ��Ȳ������ ǥ��
        stateLabel.color = new Color32(233, 182, 12, 255);

        //2�ʰ� ���
        yield return new WaitForSeconds(2.0f);

        //Go! ��� ������ ����
        stateLabel.text = "Go!";

        //0.5�ʰ� ���
        yield return new WaitForSeconds(0.5f);

        //Go! ������ �����.
        stateLabel.text = "";

        //���� ���¸� �غ� ���¿��� ���� ���·� ��ȯ
        gState = GameState.Run;
    }
    
    void Update()
    {
        //�÷��̾��� ph�� 0 ���Ϸ� ��������...
        if(playerM.hp <= 0)
        {
            //���� ���� ���� ���
            stateLabel.text = "Game over...";

            //���� ���� ������ ������ ���������� ����
            stateLabel.color = new Color32(255, 0, 0, 255);

            //���� ���¸� ���� ���� ���·� ��ȯ
            gState = GameState.GameOver;
        }
    }

    //�ɼ� �޴� �ѱ�
    public void OpenOptionWindow()
    {
        //���� ���¸� pause�� ����
        gState = GameState.Pause;

        //�ð��� �����
        Time.timeScale = 0;

        //�ɼ� �޴� â�� Ȱ��ȭ
        optionUI.SetActive(true);
    }

    //�ɼ� �޴� ����(����ϱ�)
    public void CloseOptionWindow()
    {
        //���� ���¸� run���·� ����
        gState = GameState.Run;

        //�ð��� 1��� �ǵ���
        Time.timeScale = 1.0f;

        //�ɼ� �޴� â ��Ȱ��ȭ
        optionUI.SetActive(false);
    }

    //���� �����(����� �ٽ� �ε�)
    public void GameRestart()
    {
        //�ð��� 1��� �ǵ���
        Time.timeScale = 1.0f;

        //���� ���� �ٽ� �ε��Ѵ�
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //���� �����ϱ�
    public void GameQuit()
    {
        //���ø����̼� ����
        Application.Quit();
    }
}
