using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;
using AAEmu.Game.Models.Game.Items;
using AAEmu.Game.Models.Game.Mails;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCMailSentPacket : GamePacket
    {
        private readonly Mail _mail;
        private readonly (SlotType slotType, byte slot)[] _items;

        public SCMailSentPacket(Mail mail, (SlotType slotType, byte slot)[] items) : base(0x111, 1)
        {
            _mail = mail;
            _items = items;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_mail);
            foreach (var (slotType, slot) in _items) // TODO 10 items
            {
                stream.Write((byte)0);
                stream.Write((byte)slotType);
                stream.Write((byte)0);
                stream.Write(slot);
            }

            return stream;
        }
    }
}
