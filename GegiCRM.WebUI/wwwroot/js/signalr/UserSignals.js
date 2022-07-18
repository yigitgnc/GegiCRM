var userConnectedSound = document.getElementById("userConnectedSound");

const connection = new signalR.HubConnectionBuilder()
    .withUrl("/UserHub")
    .configureLogging(signalR.LogLevel.Information)
    .build();

async function start() {
    await connection.start().then(function () {
        console.log("User Hub Bağlandı !");
        var title = document.title.replace("GegiCRM - ", "");
        connection.invoke("WhereAmI", title);

    }).catch(function (err) {
        console.log("Hub Error");
        console.log(err);
        setTimeout(start, 5000);
    });
};

connection.onclose(async () => {
    await start();
});

// Start the connection.
start();




connection.on("UserDisconnected", function (userId, lastSeen) {
    console.log(userId + " Disconnected");
    $("#userLastSeen_" + userId).html(lastSeen);
    $("#userAvatar_" + userId).removeClass("avatar-online").addClass("avatar-offline");
    SortUsers();
});

connection.on("UserConnected", function (userId, userCount) {
    console.log(userId + " Connected");
    $("#userLastSeen_" + userId).html("Online");
    $("#userAvatar_" + userId).addClass("avatar-online").removeClass("avatar-offline");

    GotMessage(1, "newOnline")
    userConnectedSound.play();
    SortUsers();
});

connection.on("UpdateUserCount", function (userCount) {
    $("#onlineUserCount").html(userCount);
});

connection.on("WhereIsUser", function (userId, title) {
    console.log(userId + " User is Now Currently At => " + title);
    $("#userWhere_" + userId).html(title);
});





function SortUsers() {
    var toSort = document.getElementById('allUsers').children;
    console.log(toSort);
    toSort = Array.prototype.slice.call(toSort, 0);


    toSort.sort(function (a, b) {
        if (a.innerHTML.includes("avatar-online") && !b.innerHTML.includes("avatar-online")) {
            return -1;
        } else {
            return 1;
        }

    });

    var parent = document.getElementById('allUsers');
    parent.innerHTML = "";

    for (var i = 0, l = toSort.length; i < l; i++) {
        parent.appendChild(toSort[i]);
    }

}