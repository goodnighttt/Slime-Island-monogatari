using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private PlayerMovement playerMovement;
    private void Show()
    {
        containerGameObject.SetActive(true);
    }

    private void Hide()
    {
        containerGameObject.SetActive(false);
    }
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        if(playerMovement.GetInteractbleObject()!=null)
        {
            Show();
        }
        else
        {
            Hide();
        }
    }
}
