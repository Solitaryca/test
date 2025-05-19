using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Talkself : MonoBehaviour
{
    public GameObject dialogueBox;
    public TextMeshProUGUI dialogueText;
    public float typingSpeed = 0.05f;
    public bool isEnd;

    [TextArea(1, 3)]
    public string[] dialogueLines;
    [SerializeField] private int currentLine;
    private bool isTyping;

    private void Start()
    {
        FindAnyObjectByType<PlayerController>().isInDialog = true;
        dialogueBox.SetActive(true);
        dialogueText.text = "";
        StartCoroutine(DisplayLine(dialogueLines[currentLine]));
        FindAnyObjectByType<PlayerController>().isCanControl = false;
        isEnd = false;
    }

    private void Update()
    {
        if (dialogueBox.activeInHierarchy)
        {
            if (Input.GetKeyDown(GameManager.GM.sure))
            {
                if (isTyping)
                {
                    StopAllCoroutines(); 
                    dialogueText.text = dialogueLines[currentLine]; 
                    isTyping = false; 
                }
                else
                {
                    currentLine++;
                    if (currentLine < dialogueLines.Length)
                    {
                        dialogueText.text = "";
                        StartCoroutine(DisplayLine(dialogueLines[currentLine]));
                    }
                    else
                    {
                        FindAnyObjectByType<PlayerController>().isInDialog = false;
                        isEnd = true;
                        dialogueBox.SetActive(false);
                        FindAnyObjectByType<crow_sport>().canMove = true;
                        FindAnyObjectByType<isLighting>().canLight = true;
                        FindAnyObjectByType<Backage>().canBackage = true;
                    }
                }
            }
        }
    }

    private IEnumerator DisplayLine(string line)
    {
        isTyping = true;
        foreach (char letter in line.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        isTyping = false;
    }
}

