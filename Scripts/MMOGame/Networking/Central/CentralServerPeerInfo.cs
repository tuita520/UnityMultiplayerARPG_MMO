﻿using LiteNetLib.Utils;

namespace MultiplayerARPG.MMO
{
    public class CentralServerPeerInfo : INetSerializable
    {
        public long connectionId;
        public CentralServerPeerType peerType;
        public string networkAddress;
        public int networkPort;
        public string connectKey;
        public string extra;

        public void Deserialize(NetDataReader reader)
        {
            peerType = (CentralServerPeerType)reader.GetByte();
            networkAddress = reader.GetString();
            networkPort = reader.GetInt();
            connectKey = reader.GetString();
            extra = reader.GetString();
        }

        public void Serialize(NetDataWriter writer)
        {
            writer.Put((byte)peerType);
            writer.Put(networkAddress);
            writer.Put(networkPort);
            writer.Put(connectKey);
            writer.Put(extra);
        }
    }
}
