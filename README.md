# AginerianInput
This package extends the functionality of Unity's New Input System! Includes binding composites with unlimited modifiers, negatable modifiers, and normalizing mouse input based the size of the screen.

Using composite bindings:
1) Open up an existing or create a new Input Actions Asset
2) Select an existing or create a new Action Map
3) Select an existing or create a new Action, and select an appropriate action type and control type (i.e. "Pass Through" and "Axis")
4) To add a Single Axis Composite with Modifiers, click the plus sign on the action and select "Add Axis with Modifiers Composite"
5) To add a Multiple Axis Composite with Modifiers, click the plus sign on the action and select "Add Vector2/Vector3 with Modifiers Composite"
6) Select a binding for the axis/axes and another for the modifier (i.e. RightArrow + Shift)
7) To add an inverted axis, right click the existing axis binding and select "Duplicate" in the pop-up, select a new binding, and add an "Invert" processor to the binding
8) If multiple axis bindings are used for a specific axis, the binding producing the value with the highest magnitude is selected.
9) To add additional modifiers, right click the existing modifier bing and select "Duplicate" in the pop-up and select the new binding.
10) To negate a modifier, select the modifier and add a "Negate Button" processor to the binding (do NOT use the Invert processor because it won't work for modifiers)
11) If multiple modifiers are used, all non-negated modifiers must be pressed and all negated modifiers must not be pressed in order to produce a non-zero value in the axis/axes.
