# GameTool

## Starting

All the code must be put in the Game.js file at the root of the project

##### Declare a window

```javascript
var Window = engine.createWindow({
    height: 600,
    width: 800,
    name: "MyGameName"
})
```

##### Stopping the engine and close the game

You must put this line of code in the file to stop and unload the game:

```javascript
engine.quit()
```

## Events

##### Windows Events

To manage an event write:

```javascript
 Window.onKeyPress(function (event) {
   //insert code here
})
```

Here is a list of all events that are catched by the window:

- OnClose :  This event **must** contain at least the `engine.quit()` line.
- OnGainedFocus

The next two events use the class *EventJoystickButton* defined in the file with the same name.

- onJoystickButtonPressed 
- onJoystickButtonReleased

The next two events use the class *EventJoystickConnect* defined in the file with the same name.

- onJoystickConnected
- onJoystickDisconnected

The next event use the class *EventJoystickMove* defined in the file with the same name, the Axis codes are defined [here](http://www.sfml-dev.org/documentation/2.2-fr/classsf_1_1Joystick.php#a48db337092c2e263774f94de6d50baa7).

- onJoystickMoved

The next two events use the class *EventKey* defined in the file with the same name, the Key codes are defined [here](http://www.sfml-dev.org/documentation/2.2-fr/classsf_1_1Keyboard.php#acb4cacd7cc5802dec45724cf3314a142).

- onKeyPress
- onKeyReleased

- onLostFocus

The next two events use the class *EventMouseButton* defined in the file with the same name, the Button codes are defined [here](http://www.sfml-dev.org/documentation/2.2-fr/classsf_1_1Mouse.php#a4fb128be433f9aafe66bc0c605daaa90).

- onMouseButtonPressed
- onMouseButtonReleased

- onMouseEntered
- onMouseLeft

The next event use the class *EventMouseMove* defined in the file with the same name.

- onMouseMoved

The next event use the class *EventMouseWheel* defined in the file with the same name.

- onMouseWheelMoved

The next event use the class *EventSize* defined in the file with the same name.

- onResized

The next event use the class *EventSensor* defined in the file with the same name, the Type codes are defined [here](http://www.sfml-dev.org/documentation/2.2-fr/classsf_1_1Sensor.php#a687375af3ab77b818fca73735bcaea84).

- onSensorChanged

The next event use the class *EventText* defined in the file with the same name.

- onTextEntered

The next three events use the class *EventTouch* defined in the file with the same name.

- onTouchBegan
- onTouchEnded
- onTouchMoved
