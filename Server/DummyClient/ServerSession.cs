﻿using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using ServerCore;
using System.Collections.Generic;

namespace DummyClient
{
	class ServerSession : Session
    {
        public override void OnConnected(EndPoint endPoint)
        {
            Console.WriteLine($"OnConnected : {endPoint}");

            C_Chat packet = new C_Chat() {  };
            packet.chat = "안녕하세요";

            ArraySegment<byte> s = packet.Write();

            if (s != null)
                Send(s);            
        }

        public override void OnDisconnected(EndPoint endPoint)
        {
            Console.WriteLine($"OnDisconnected : {endPoint}");
        }

        public override int OnRecv(ArraySegment<byte> buffer)
        {
            string recv = Encoding.UTF8.GetString(buffer.Array, buffer.Offset, buffer.Count);
            Console.WriteLine($"[From Server] {recv}");

            return buffer.Count;
        }

        public override void OnSend(int numOfBytes)
        {
            Console.WriteLine($"C Transferred bytes: {numOfBytes}");
        }
    }
}