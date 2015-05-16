var Window = engine.createWindow({
    height: 600,
    width: 800,
    name: "SuperJeux"
})

Window.onClose(function (event) {
    engine.quit()
})

var Goomba = engine.createNewEntity({
    name: "goomba"
})

Goomba.setPosition(20.0, 30.0)
Goomba.setScale(0.4,0.4)
Goomba.setTexture("goomba.jpg")


var Coin1 = engine.createNewEntity({
    name: "coin1"
})

Coin1.setPosition(20.0, 300.0)
Coin1.setScale(0.2, 0.2)
Coin1.setTexture("coin.png")

var Coin2 = engine.createNewEntity({
    name:"coin2"
})

Coin2.setPosition(100.0, 30.0)
Coin2.setScale(0.2, 0.2)
Coin2.setTexture("coin.png")

var Coin3 = engine.createNewEntity({
    name:"coin3"
})

Coin3.setPosition(400.0, 300.0)
Coin3.setScale(0.2, 0.2)
Coin3.setTexture("coin.png")

engine.setEventLoop(function () {
})

Window.onKeyPress(function (event) {
        if (event.Code == "Up")
            Goomba.move(0.0, -10.0)
        if (event.Code == "Down")
            Goomba.move(0.0, 10.0)
        if (event.Code == "Left")
            Goomba.move(-10.0, 0.0)
        if (event.Code == "Right")
            Goomba.move(10.0, 0.0)

        if (Goomba.checkCollision(Coin1))
            engine.deleteEntity(Coin1)
        else if (Goomba.checkCollision(Coin2))
            engine.deleteEntity(Coin2)
        else if (Goomba.checkCollision(Coin3))
            engine.deleteEntity(Coin3)

    engine.log("KeyPressed: " + event.Code)
})