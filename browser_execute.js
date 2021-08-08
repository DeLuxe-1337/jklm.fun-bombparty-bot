var Wordsocket = new WebSocket("ws://localhost/Word");

var Username = "DeLuxe"; //Replace this with your game username!

Wordsocket.onmessage = function (event) {
    socket.emit("setWord", event.data, true);
}

setInterval(function(){ 
    if(document.querySelector("body > div.main.page > div.bottom > div.round > div.otherTurn > span.player").innerText == Username) {
        var Letters = document.querySelector("body > div.main.page > div.middle > div.canvasArea > div.round > div").innerText;
        Wordsocket.send(Letters);
    } 
}, 1000);
