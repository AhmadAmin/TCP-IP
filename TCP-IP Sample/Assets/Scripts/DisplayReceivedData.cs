using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayReceivedData : MonoBehaviour
{
    Text displayText;
    TCPServer tcpServer;
    // Start is called before the first frame update
    void Start()
    {
        displayText = GetComponent<Text>();
        tcpServer = FindObjectOfType<TCPServer>();
    }

    // Update is called once per frame
    void Update()
    {
        displayText.text = tcpServer.messageReceived;
    }
}
