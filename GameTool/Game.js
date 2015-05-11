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

var Entity1 = engine.createNewEntity({
    name: "testentity"
})

Entity1.setPosition(20.0, 30.0)
Entity1.setSize(20.0, 60.0)
Entity1.setColor(255, 0, 0)

var Entity2 = engine.createNewEntity({
    name: "testentity2"
})

Entity2.setPosition(200.0, 200.0)
Entity2.setSize(100.0, 40.0)
Entity2.setColor(0, 255, 0)

