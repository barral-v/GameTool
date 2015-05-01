var Window = engine.createWindow({
    height: 600,
    width: 800
})

Window.on("keyPress", function (event) {
    engine.log("KeyPressed: " + event.keyCode)
})