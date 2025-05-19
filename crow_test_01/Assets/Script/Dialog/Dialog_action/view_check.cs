using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Text;

public class ViewCheck : MonoBehaviour
{
    [SerializeField] private bool isEntered;
    public GameObject dialogueBox_check, dialogueBox_view;
    public TextMeshProUGUI dialogueText_check, dialogueText_view;
    public float typingSpeed = 0.05f;

    public string[] dialogueLines;
    [SerializeField] private int currentLine;
    private bool isTyping;
    private bool isViewing;
    private bool skipText;

    private void Start()
    {
        dialogueBox_check.SetActive(false);
        dialogueBox_view.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isEntered = true;
            dialogueBox_check.SetActive(true);
            KeyCode sureKey = GameManager.GM.sure; 
            string keyName = sureKey.ToString();
            dialogueText_check.text = "°´ " + keyName + " ¼ü²é¿´";
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isEntered = false;
            dialogueBox_check.SetActive(false);
            if (isViewing)
            {
                StopAllCoroutines();
                dialogueBox_view.SetActive(false);
                dialogueBox_check.SetActive(true);
                isViewing = false;
                currentLine = 0;
            }
        }
    }

    private void Update()
    {
        if (isEntered && Input.GetKeyDown(GameManager.GM.sure))
        {
            if (isViewing)
            {
                if (isTyping)
                {
                    skipText = true;
                }
                else
                {
                    NextLine();
                }
            }
            else
            {
                StartViewing();
            }
        }
    }

    private void StartViewing()
    {
        isViewing = true;
        dialogueBox_check.SetActive(false);
        dialogueBox_view.SetActive(true);
        StartCoroutine(TypeText(dialogueLines[currentLine]));
        FindAnyObjectByType<PlayerController>().isInDialog = true;
        FindAnyObjectByType<crow_sport>().canMove = false;
        FindAnyObjectByType<isLighting>().canLight = false;
        FindAnyObjectByType<Backage>().canBackage = false;
    }

    private IEnumerator TypeText(string line)
    {
        isTyping = true;
        skipText = false;

        dialogueText_view.text = "";
        StringBuilder stringBuilder = new();
        int index = 0;

        while (index < line.Length)
        {
            char currentChar = line[index];

            if (currentChar == '<')
            {
                // Handle rich text tags
                int tagEndIndex = line.IndexOf('>', index);
                if (tagEndIndex != -1)
                {
                    stringBuilder.Append(line.Substring(index, tagEndIndex - index + 1));
                    dialogueText_view.text = stringBuilder.ToString();
                    index = tagEndIndex + 1;
                    continue; // Skip to the next iteration to handle text after the tag
                }
            }

            // Handle normal characters
            stringBuilder.Append(currentChar);
            dialogueText_view.text = stringBuilder.ToString();

            index++;
            yield return new WaitForSeconds(typingSpeed);

            if (skipText)
            {
                dialogueText_view.text = line;
                break;
            }
        }

        isTyping = false;
    }

    private void NextLine()
    {
        currentLine++;
        if (currentLine < dialogueLines.Length)
        {
            StartCoroutine(TypeText(dialogueLines[currentLine]));
            FindAnyObjectByType<PlayerController>().isInDialog = true;
            FindAnyObjectByType<Backage>().canBackage = false;
            FindAnyObjectByType<crow_sport>().canMove = false;
            FindAnyObjectByType<isLighting>().canLight = false;
        }
        else
        {
            EndViewing();
            FindAnyObjectByType<PlayerController>().isInDialog = false;
            FindAnyObjectByType<Backage>().canBackage = true;
            FindAnyObjectByType<crow_sport>().canMove = true;
            FindAnyObjectByType<isLighting>().canLight = true;
        }
    }

    private void EndViewing()
    {
        dialogueBox_view.SetActive(false);
        dialogueBox_check.SetActive(true);
        isViewing = false;
        currentLine = 0;
    }
}
