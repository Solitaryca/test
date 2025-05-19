using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class DialogueSystem : MonoBehaviour 
{
    [SerializeField] private Dialogue dialogue;
    [SerializeField] private GameObject dialogBox;
    [SerializeField] private TextMeshProUGUI dialog;
    [SerializeField] private TextMeshProUGUI characterName;
    [SerializeField] private CharacterType type;
    private int index;
    private bool isInTurn;
    private bool isDownC;

    public InputActions inputActions;

    public bool IsDownC { get => isDownC; set => isDownC = value; }

    private void Awake()
    {
        inputActions = new InputActions();
        inputActions.Gameplay.interactive.started += Interactive_started; ;
    }

    private void Interactive_started(InputAction.CallbackContext obj)
    {
        IsDownC = true;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.C) && isInTurn)
        {
            Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) => isInTurn = true;
    private void OnTriggerExit2D(Collider2D collision) => isInTurn = false;

    private void Play()
    {
        dialogBox.SetActive(true);
        DialogNode node = dialogue.dialogNodes[Mathf.Clamp(index++, 0, dialogue.dialogNodes.Length - 1)];
        dialog.text = node.dialog;
        characterName.text = node.characterName;
        if (index - 1 == dialogue.dialogNodes.Length)
        {
            dialogBox.SetActive(false);
        }
    }
}
