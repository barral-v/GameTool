var Window = engine.createWindow({
    height: 600,
    width: 800,
    name: "SuperJeux"
})

Window.onKeyPress(function (event) {
   engine.log("KeyPressed: " + event.Code)
})

Window.onClose(function (event) {
    engine.quit()
})
