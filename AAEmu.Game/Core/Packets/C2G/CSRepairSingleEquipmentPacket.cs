using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;
using AAEmu.Game.Models.Game.Items;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSRepairSingleEquipmentPacket : GamePacket
    {
        public CSRepairSingleEquipmentPacket() : base(0x03a, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            stream.ReadByte();
            var slotType = (SlotType)stream.ReadByte();
            stream.ReadByte();
            var slot = stream.ReadByte();

            _log.Debug("RepairSingleEquipment, SlotType: {0}, Slot: {1}", slotType, slot);
        }
    }
}
