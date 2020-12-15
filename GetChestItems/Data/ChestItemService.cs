using CoreRCON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GetChestItems.Data
{
    public class ChestItemService
    {
        public Task<ChestItems[]> GetItems(int x, int y, int z)
        {
            /*IPAddress ipaddress = IPAddress.Parse("127.0.0.1");
            ushort port = 25575;
            string password = "minecraft";
            RCON rcon = new RCON(ipaddress, port, password);

            rcon.ConnectAsync();

            var getdata = rcon.SendCommandAsync($"/data get block {x} {y} {z}");*/

            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new ChestItems
            {
                ItemName = "Iron",
                ItemCount = 4,
                ItemSlot = "1a"

            }).ToArray());

        }
    }
}
