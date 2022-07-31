var userConnectedSound = document.getElementById("userConnectedSound");
var gotMessageSound = document.getElementById("gotMessageSound");

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
GetUserMessages();



connection.on("UserDisconnected", function (userId, lastSeen) {
    console.log(userId + " Disconnected");
    $("#userLastSeen_" + userId).html(lastSeen);
    $("#userAvatar_" + userId).removeClass("avatar-online").addClass("avatar-offline");
    SortUsers();
});

connection.on("UserConnected", function (userId, connectionId) {
    console.log(userId + " Connected, ConnectionId => " + connectionId);
    $("#userLastSeen_" + userId).html("Online");
    $("#userAvatar_" + userId).addClass("avatar-online").removeClass("avatar-offline");

    Notify(1, 1);
    SortUsers();
});

connection.on("UpdateUserCount", function (userCount) {
    $("#onlineUserCount").html(userCount);
});

connection.on("WhereIsUser", function (userId, title) {
    console.log(userId + " User is Now Currently At => " + title);
    $("#userWhere_" + userId).html(title);
});

connection.on("GotNewMessage", function (senderId, message) {-
    console.log("GotNewMessage From User => " + senderId + " Message => " + message);
    GetUserMessages();
    Notify(2, 2);

    console.log(_currentMsgUserId);

    if (senderId == _currentMsgUserId) {
        GetMessagesByRecieverId();
    } else {
        console.log("Bana Mesaj Geldi Ama İlgili Pencerem Kapalı :(");
    }
});


//type 1 = online
//type 2 = message
function Notify(blinkCount, type) {

    var total = blinkCount * 2;
    var current = 1;

    var interval = setInterval(() => {

        if (total <= current) {
            clearInterval(interval);
        }

        current++;
        switch (type) {
            case 1:
                userConnectedSound.play();
                $("#chatOffCanvasBtn").toggleClass("newOnline");
                break;
            case 2:
                gotMessageSound.play();
                $("#chatOffCanvasBtn").toggleClass("gotMessage");
                break;
            default:
                break;
        }

    }, 200);

}


function SortUsers() {
    var toSort = document.getElementById('allUsers').children;
    //console.log(toSort);
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

function GetUserMessages() {
    $.ajax({
        "url": "/AppUsers/_GetUserMessages",
        "method": "GET",
        success: function (data) {
            $("#navsMessages").html(data);
            //$("#MoveResponse").fadeIn(0).fadeOut(5000).html("İşlem Tamamlandı");
            //getOrdersProducts();
        },
        error: function (err) {
            console.log(err);
            $("#navsMessages").html("Bir Hata Oluştu !");
        }
    });
}
var _currentMsgUserId = -1;

function OpenMessageModal(id,userName) {
    $("#chatModal").modal('show');
    $("#currentMessageUserName").html(userName);

    _currentMsgUserId = id;
    GetMessagesByRecieverId();
}

function GetMessagesByRecieverId() {
    $.ajax({
        "url": "/AppUsers/_GetChatMessages/" + _currentMsgUserId,
        "method": "GET",
        success: function (data) {
            $("#messagesContainer").html(data);
            setTimeout(function () {
                $("#messagesContainer").animate({ scrollTop: 9999999 }, 100);
            }, 200);


            //$("#MoveResponse").fadeIn(0).fadeOut(5000).html("İşlem Tamamlandı");
            //getOrdersProducts();
        },
        error: function (err) {
            console.log(err);
            $("#messagesContainer").html("Bir Hata Oluştu !");
        }
    });
}

function SendMessage() {

    connection.invoke("SendMessage", _currentMsgUserId, $('#MessageInput').val());
    $('#MessageInput').val("");
    GetMessagesByRecieverId();
    GetUserMessages();
    return false;
}


function AddIncomingMessage() {

}