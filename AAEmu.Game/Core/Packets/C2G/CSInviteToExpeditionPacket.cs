using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSInviteToExpeditionPacket : GamePacket
    {
        public CSInviteToExpeditionPacket() : base(0x00c, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var name = stream.ReadString();

            _log.Debug("InviteToExpedition, Name: {0}", name);
        }
    }
}
