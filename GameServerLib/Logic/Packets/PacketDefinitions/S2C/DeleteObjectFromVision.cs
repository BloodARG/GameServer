using LeagueSandbox.GameServer.Logic.GameObjects;
using LeagueSandbox.GameServer.Logic.Packets.PacketHandlers;

namespace LeagueSandbox.GameServer.Logic.Packets.PacketDefinitions.S2C
{
    public class DeleteObjectFromVision : BasePacket
    {
        public DeleteObjectFromVision(GameObject o)
            : base(PacketCmd.PKT_S2C_DELETE_OBJECT, o.NetId)
        {
        }
    }
}