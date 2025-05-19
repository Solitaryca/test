using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Dialog_choice : MonoBehaviour
{
    [SerializeField] private bool isEntered;
    public GameObject dialogueBox_Player, dialogueBox_Npc, dialogueBox_Option1, dialogueBox_Option2, dialogueBox_Option3;
    public TextMeshProUGUI dialogueText_Player, dialogueText_Npc, dialogueText_Option1, dialogueText_Option2, dialogueText_Option3;
    public float typingSpeed = 0.05f;

    public class DialogueLine
    {
        public string text;
        public CharacterType type;
        [Header("Branch")]
        public bool isQuestion;
        public string answerOption1;
        public string answerOption2;
        public string answerOption3;
        public int option1IndexJump;
        public int option2IndexJump;
        public int option3IndexJump;
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
    private int selectedOption = 0;

    private void Start()
    {
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
        if (isEntered == true && Input.GetKeyDown(KeyCode.C))
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
                FindAnyObjectByType<crow_sport>().canMove = false;
            }
            else if (dialogueBox_Option1.activeInHierarchy || dialogueBox_Option2.activeInHierarchy || dialogueBox_Option3.activeInHierarchy)
            {
                ConfirmOption();
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
                    dialogueBox_Option1.SetActive(false);
                    dialogueBox_Option2.SetActive(false);
                    dialogueBox_Option3.SetActive(false);
                    FindAnyObjectByType<crow_sport>().canMove = true;
                    currentLine = 0;
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ChangeOption(1);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ChangeOption(-1);
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

        if (dialogueLine.type == CharacterType.Player)
        {
            dialogueBox_Player.SetActive(true);
            dialogueBox_Npc.SetActive(false);
            dialogueText_Player.text = "";
        }
        else if (dialogueLine.type == CharacterType.Npc)
        {
            dialogueBox_Player.SetActive(false);
            dialogueBox_Npc.SetActive(true);
            dialogueText_Npc.text = "";
        }

        string fullText = dialogueLine.text;

        StringBuilder stringBuilder = new StringBuilder();
        int index = 0;

        while (index < fullText.Length)
        {
            char currentChar = fullText[index];

            if (currentChar == '<')
            {
                int tagEndIndex = fullText.IndexOf('>', index);
                if (tagEndIndex != -1)
                {
                    stringBuilder.Append(fullText.Substring(index, tagEndIndex - index + 1));
                    dialogueText_Player.text = stringBuilder.ToString();
                    index = tagEndIndex + 1;
                    yield return null;
                }
            }
            else
            {
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

        if (dialogueLine.type == CharacterType.Player)
        {
            dialogueText_Player.text = fullText;
        }
        else if (dialogueLine.type == CharacterType.Npc)
        {
            dialogueText_Npc.text = fullText;
        }

        isTyping = false;

        // Show option buttons if it's a question
        if (dialogueLine.isQuestion)
        {
            ShowOptions(dialogueLine);
        }
    }

    private void ShowOptions(DialogueLine dialogueLine)
    {
        dialogueBox_Option1.SetActive(!string.IsNullOrEmpty(dialogueLine.answerOption1));
        dialogueBox_Option2.SetActive(!string.IsNullOrEmpty(dialogueLine.answerOption2));
        dialogueBox_Option3.SetActive(!string.IsNullOrEmpty(dialogueLine.answerOption3));

        if (dialogueBox_Option1.activeInHierarchy)
        {
            dialogueText_Option1.text = dialogueLine.answerOption1;
        }
        if (dialogueBox_Option2.activeInHierarchy)
        {
            dialogueText_Option2.text = dialogueLine.answerOption2;
        }
        if (dialogueBox_Option3.activeInHierarchy)
        {
            dialogueText_Option3.text = dialogueLine.answerOption3;
        }
        selectedOption = 0;
        HighlightSelectedOption();
    }

    private void HighlightSelectedOption()
    {
        dialogueBox_Option1.GetComponent<Image>().color = selectedOption == 0 ? Color.yellow : Color.white;
        dialogueBox_Option2.GetComponent<Image>().color = selectedOption == 1 ? Color.yellow : Color.white;
        dialogueBox_Option3.GetComponent<Image>().color = selectedOption == 2 ? Color.yellow : Color.white;
    }

    private void ChangeOption(int direction)
    {
        selectedOption = Mathf.Clamp(selectedOption + direction, 0, 2);
        HighlightSelectedOption();
    }

    private void ConfirmOption()
    {
        var currentDialogue = dialogueLines[currentLine];
        switch (selectedOption)
        {
            case 0:
                if (dialogueBox_Option1.activeInHierarchy && Input.GetKeyDown(KeyCode.C))
                {
                    currentLine = currentDialogue.option1IndexJump;
                }
                break;
            case 1:
                if (dialogueBox_Option2.activeInHierarchy && Input.GetKeyDown(KeyCode.C))
                {
                    currentLine = currentDialogue.option2IndexJump;
                }
                break;
            case 2:
                if (dialogueBox_Option3.activeInHierarchy && Input.GetKeyDown(KeyCode.C))
                {
                    currentLine = currentDialogue.option3IndexJump;
                }
                break;
        }
        dialogueBox_Option1.SetActive(false);
        dialogueBox_Option2.SetActive(false);
        dialogueBox_Option3.SetActive(false);
        UpdateDialogueText();
    }

    private void DisplayFullText()
    {
        var currentDialogue = dialogueLines[currentLine];
        if (currentDialogue.type == CharacterType.Player)
        {
            dialogueText_Player.text = currentDialogue.text;
        }
        else if (currentDialogue.type == CharacterType.Npc)
        {
            dialogueText_Npc.text = currentDialogue.text;
        }
    }
}
