using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VoteR.Models;

namespace VoteR.Hubs
{
    public class VoterHub : Hub
    {
        static List<Item> items = new ItemsList();       
       
        public async Task Vote(string votesForId)
        {
            var voteItem = items.Find(item => item.Id == Convert.ToInt16(votesForId));
            voteItem.Votes++;              
            await Clients.All.SendAsync("UpdateUI", voteItem.Id, voteItem.Votes);       
        }

        public override Task OnConnectedAsync()
        {
            Clients.Caller.SendAsync("SetupUI", items);
            return base.OnConnectedAsync();
        }
    }
}
