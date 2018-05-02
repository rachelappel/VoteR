const connection = new signalR.HubConnection("/voterhub");

connection.on("UpdateUI", (votesForId, totalVotes) => {
    const votes = document.getElementById(votesForId);
    votes.textContent = totalVotes;
    console.log(votesFor + " " + totalVotes);
});

connection.on("SetupUI", (items) => {
    for (i = 1; i < items.length; i++) {
        const item = document.getElementById(items[i].id);
        item.textContent = items[i].votes;
        console.log(items[i].id + " " + items[i].votes);
    }    
});

const buttons = document.getElementsByTagName("button");
for (i = 1; i < buttons.length; i++) {
    buttons[i].addEventListener("click", buttonClick, false);    
} 

function buttonClick() {
    console.log(this.value);
    connection.send("Vote", this.value).catch(err => console.error);
    event.preventDefault();
}

connection.start().catch(err => console.error);