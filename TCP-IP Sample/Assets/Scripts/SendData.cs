using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendData : MonoBehaviour
{
    [SerializeField]
    Text dataToSend;
    TCPClient tcpClient;

    // Start is called before the first frame update
    void Start()
    {
        tcpClient = FindObjectOfType<TCPClient>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SendDataToServer()
    {
        tcpClient.SendMessage(dataToSend.text);
    }
}
