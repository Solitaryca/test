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

        // 设置对话框和文本
        if (dialogueLine.type == CharacterType.Player)
        {
            dialogueBox_Player.SetActive(true);
            dialogueBox_Npc.SetActive(false);
            dialogueText_Player.text = ""; // 清除之前的文本
        }
        else if (dialogueLine.type == CharacterType.Npc)
        {
            dialogueBox_Player.SetActive(false);
            dialogueBox_Npc.SetActive(true);
            dialogueText_Npc.text = ""; // 清除之前的文本
        }

        // 获取要显示的富文本
        string fullText = dialogueLine.txt;

        // 逐字输出富文本
        StringBuilder stringBuilder = new StringBuilder();
        int index = 0;

        while (index < fullText.Length)
        {
            char currentChar = fullText[index];

            if (currentChar == '<')
            {
                // 处理富文本标签
                int tagEndIndex = fullText.IndexOf('>', index);
                if (tagEndIndex != -1)
                {
                    stringBuilder.Append(fullText.Substring(index, tagEndIndex - index + 1));
                    dialogueText_Player.text = stringBuilder.ToString();
                    index = tagEndIndex + 1;
                    yield return null; // 等待一帧
                }
            }
            else
            {
                // 处理普通字符
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

        // 确保最后的文本完全显示
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
