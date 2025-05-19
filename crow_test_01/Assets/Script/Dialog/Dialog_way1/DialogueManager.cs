using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using System.Text;

public class DialogueManager : MonoBehaviour
{
    public bool canDialogue;
    [SerializeField] private bool isEntered;
    public GameObject dialogueBox_Player, dialogueBox_Npc;
    public TextMeshProUGUI dialogueText_Player, dialogueText_Npc;
    public float typingSpeed = 0.05f;

    public class DialogueLine
    {
        public string txt;
        public CharacterType type;
    }

    public enum CharacterType
    {
        Player,
        Npc
    }

    public DialogueLine[] dialogueLines;
    [SerializeField] private int currentLine;
    private Coroutine typingCoroutine;
    private bool isTyping;

    private void Start()
    {
        canDialogue = true;
        Update();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isEntered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isEntered = false;
        }
    }

    private void Update()
    {
        if (canDialogue==true && isEntered == true && Input.GetKeyDown(KeyCode.C))
        {
            if (isTyping)
            {
                StopCoroutine(typingCoroutine);
                isTyping = false;
                DisplayFullText();
            }
            else if (!dialogueBox_Player.activeInHierarchy && !dialogueBox_Npc.activeInHierarchy)
            {
                currentLine = 0;
                UpdateDialogueText();
                FindAnyObjectByType<PlayerController>().isInDialog = true;
            }
            else
            {
                currentLine++;
                if (currentLine < dialogueLines.Length)
                {
                    UpdateDialogueText();
                }
                else
                {
                    dialogueBox_Player.SetActive(false);
                    dialogueBox_Npc.SetActive(false);
                    FindAnyObjectByType<PlayerController>().isInDialog = false;
                    currentLine = 0;
                }
            }
        }
    }

    private void UpdateDialogueText()
    {
        if (dialogueLines.Length == 0 || currentLine >= dialogueLines.Length)
        {
            return;
        }

        var currentDialogue = dialogueLines[currentLine];
        typingCoroutine = StartCoroutine(TypeText(currentDialogue));
    }

    private IEnumerator TypeText(DialogueLine dialogueLine)
    {
        isTyping = true;

        // ���öԻ�����ı�
        if (dialogueLine.type == CharacterType.Player)
        {
            dialogueBox_Player.SetActive(true);
            dialogueBox_Npc.SetActive(false);
            dialogueText_Player.text = ""; // ���֮ǰ���ı�
        }
        else if (dialogueLine.type == CharacterType.Npc)
        {
            dialogueBox_Player.SetActive(false);
            dialogueBox_Npc.SetActive(true);
            dialogueText_Npc.text = ""; // ���֮ǰ���ı�
        }

        // ��ȡҪ��ʾ�ĸ��ı�
        string fullText = dialogueLine.txt;

        // ����������ı�
        StringBuilder stringBuilder = new StringBuilder();
        int index = 0;

        while (index < fullText.Length)
        {
            char currentChar = fullText[index];

            if (currentChar == '<')
            {
                // �����ı���ǩ
                int tagEndIndex = fullText.IndexOf('>', index);
                if (tagEndIndex != -1)
                {
                    stringBuilder.Append(fullText.Substring(index, tagEndIndex - index + 1));
                    dialogueText_Player.text = stringBuilder.ToString();
                    index = tagEndIndex + 1;
                    yield return null; // �ȴ�һ֡
                }
            }
            else
            {
                // ������ͨ�ַ�
                stringBuilder.Append(currentChar);
                if (dialogueLine.type == CharacterType.Player)
                {
                    dialogueText_Player.text = stringBuilder.ToString();
                }
                else if (dialogueLine.type == CharacterType.Npc)
                {
                    dialogueText_Npc.text = stringBuilder.ToString();
                }

                index++;
                yield return new WaitForSeconds(typingSpeed);
            }
        }

        // ȷ�������ı���ȫ��ʾ
        if (dialogueLine.type == CharacterType.Player)
        {
            dialogueText_Player.text = fullText;
        }
        else if (dialogueLine.type == CharacterType.Npc)
        {
            dialogueText_Npc.text = fullText;
        }

        isTyping = false;
    }


    private void DisplayFullText()
    {
        var currentDialogue = dialogueLines[currentLine];
        if (currentDialogue.type == CharacterType.Player)
        {
            dialogueText_Player.text = currentDialogue.txt;
        }
        else if (currentDialogue.type == CharacterType.Npc)
        {
            dialogueText_Npc.text = currentDialogue.txt;
        }
    }
}
