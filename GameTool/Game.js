var Window = engine.createWindow({
    height: 600,
    width: 800,
    name: "SuperJeux"
})

Window.onClose(function (event) {
    engine.quit()
})

var Entity1 = engine.createNewEntity({
    name: "testentity"
})

Entity1.setPosition(20.0, 30.0)
Entity1.setSize(100.0, 100.0)
Entity1.setTexture("goomba.jpg")

var Entity2 = engine.createNewEntity({
    name: "testentity2"
})

Entity2.setPosition(200.0, 200.0)
Entity2.setSize(100.0, 40.0)
Entity2.setColor(0, 255, 0)

Window.onKeyPress(function (event) {
    if (event.Code == "Up")
        Entity1.move(0.0, -10.0)
    else if (event.Code == "Down")
        Entity1.move(0.0, 10.0)
    else if (event.Code == "Left")
        Entity1.move(-10.0, 0.0)
    else if (event.Code == "Right")
        Entity1.move(10.0, 0.0)
    engine.log("KeyPressed: " + event.Code)
})