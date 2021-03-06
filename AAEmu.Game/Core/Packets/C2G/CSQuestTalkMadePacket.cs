using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSQuestTalkMadePacket : GamePacket
    {
        public CSQuestTalkMadePacket() : base(0x0d6, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var objId = stream.ReadBc();
            var unkId = stream.ReadUInt32();
            var unk2Id = stream.ReadUInt32();
            var unk3Id = stream.ReadUInt32();
            
            _log.Warn("QuestTalkMade, ObjId: {0}, Id: {1}, {2}, {3}", objId, unkId, unk2Id, unk3Id);
        }
    }
}
