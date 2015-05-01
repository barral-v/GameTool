Window = engine.createWindow(800, 600)

Window.onKeyPress(function (event) {
   engine.log("KeyPressed: " + event.keyCode)
})
